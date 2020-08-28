using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.Auth;
using ERP.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser>signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        [Route("Account/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user =await _userManager.FindByNameAsync(model.UserName);
            if (user !=null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (await _userManager.IsInRoleAsync(user,"Administrators") || await _userManager.IsInRoleAsync(user,"Employees"))
                        return RedirectToAction("Index", "Home");
                    else if (await _userManager.IsInRoleAsync(user, "Users"))
                        return RedirectToAction("Details","Home",new {AccountId=user.AccAcountId });
                    else
                        return Content("Dont Have Role");
                }
                
            }
            ModelState.AddModelError("", "username/Password Not Found");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user =await _userManager.FindByNameAsync(model.UserName);
            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                 user = await _userManager.FindByIdAsync(user.Id);
                if (user != null)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }
                return RedirectToAction("Index", "Home");
            }
         ModelState.AddModelError("","somthung error");
            return View(model);
        }


    }
}
