using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.Auth;
using ERP.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP.Controllers
{
    [Authorize(Roles = "Administrators")]
    
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<ApplicationUser>userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [Route("Admin/UsersManangement")]
        public IActionResult UsersManangement()
        {
            var users = _userManager.Users;
            return View(users);
        }
        [HttpGet]
        [Route("Admin/AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        [Route("Admin/AddUser")]
        public async Task<IActionResult> AddUser(AddUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email

            };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("UsersManangement", _userManager.Users);
            }
            foreach(IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(model);  
        }
        [HttpGet]
        [Route("Admin/EditUser")]
        public async Task<IActionResult> EditUser(string id)
        {
            var user =await _userManager.FindByIdAsync(id);
            if (user==null)
            {
                return RedirectToAction("UsersManangement", _userManager.Users);
            }
            var model = new EditUserViewModel()
            {
                UserName = user.UserName,
                Email = user.Email
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.id);

            if(user !=null)
            {
                user.UserName = model.UserName;
                user.Email = model.Email;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UsersManangement", _userManager.Users);
                }

                ModelState.AddModelError("", "user Not something Error Updated");
                return View(model);
            }
            return RedirectToAction("UsersManangement", _userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("UsersManangement");
                else
                    ModelState.AddModelError("", "Something went wrong while deleting this user.");
            }
            else
            {
                ModelState.AddModelError("", "This user can't be found");
            }
            return RedirectToAction("UsersManangement", _userManager.Users);
        }

        //Roles Managment
        [Route("Admin/RolesManagement")]
        public IActionResult RolesManagement()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }
        [Route("Admin/AddRole")]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        [Route("Admin/AddRole")]
        public async Task<IActionResult> AddRole(AddRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var role = new IdentityRole
            {
                Name = model.RoleName
            };
            IdentityResult result =await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("RolesManagement", _roleManager.Roles);
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(model);
        }
        [HttpGet]
        [Route("Admin/EditRole/{Id}")]
        public async Task<IActionResult> EditRole(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);
            if (role ==null)
            {
                return RedirectToAction("RolesManagement", _roleManager.Roles);

            }
            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name,
                Users = new List<string>()
            };
            foreach (var user in _userManager.Users)
            {
                if( await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }
        [HttpPost]
        [Route("Admin/EditRole")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role !=null)
            {
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("RolesManagement", _roleManager.Roles);
                }
                ModelState.AddModelError("", "Role not updated, something went wrong.");
                return View(model);
            }

            return RedirectToAction("RolesManagement", _roleManager.Roles);
        }
        [HttpPost]

        public async Task<IActionResult> DeleteRole(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);
            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                
                    return RedirectToAction("RolesManagement", _roleManager.Roles);
                ModelState.AddModelError("", "Something went wrong while deleting this role.");
            }
            else
            {
                ModelState.AddModelError("", "This role can't be found.");

            }

            return View("RolesManagement", _roleManager.Roles);
        }

        // Users In Roles
        [Route("Admin/AddUserToRole")]
        public async Task<IActionResult> AddUserToRole(string RoleId)
        {
            var role = await _roleManager.FindByIdAsync(RoleId);
            if (role == null)
              return View("RolesManagement", _roleManager.Roles);
            var model = new UserRoleViewModel
            {
                RoleId = role.Id
            };
            foreach (var user in _userManager.Users)
            {
                if (!await _userManager.IsInRoleAsync(user,role.Name))
                {
                    model.Users.Add(user);
                }
            }

            return View(model);
        }
        [HttpPost]
        [Route("Admin/AddUserToRole")]
        public async Task<IActionResult> AddUserToRole(UserRoleViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            var result =await _userManager.AddToRoleAsync(user, role.Name);
            if (result.Succeeded)
            {
                return View("RolesManagement", _roleManager.Roles);
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

     
        public async Task<IActionResult> DeleteUserFromRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if(role == null)
                return View("RolesManagement", _roleManager.Roles);
            var model = new UserRoleViewModel
            {
                RoleId = role.Id
            };
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user,role.Name))
                {
                    model.Users.Add(user);
                }
               
            }
            return View(model);
        }
        [HttpPost]
        [Route("Admin/DeleteUserFromRole")]
        public async Task<IActionResult> DeleteUserFromRole(UserRoleViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            var result =await _userManager.RemoveFromRoleAsync(user, role.Name);
            if (result.Succeeded)
            {
                return View("RolesManagement", _roleManager.Roles);
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

    }
}
