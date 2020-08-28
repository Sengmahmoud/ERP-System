using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ERP.Models;
using ERP.Interfaces;
using ERP.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace ERP.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IAccount _account;

        public HomeController(IAccount account)
        {
            
           _account = account;
        }

        [Authorize(Roles = "Administrators, Employees")]
        // GET: /Home/
        public IActionResult Index()
        {
            var accounts = _account.GetAccAccounts().ToList();
            var model = new AccountViewModel()
            {
                Accounts=accounts
               
            };

           
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Administrators, Employees , Users")]
        public string Index(int AccountId , DateTime fromdate , DateTime todate)
            {
            try
            {
              
                var details = _account.getDetailts(AccountId,fromdate,todate);
                foreach (var item in details)
                {
                    if (item.Credit==0 )
                    {
                        item.Credit = null;
                     
                    }
                    if (item.Debit==0)
                    {
                        item.Debit = null;
                    }
                }
                   
           String jsonResult = JsonConvert.SerializeObject(details);
                return jsonResult;
            }

            catch
            {
                return "error";
            }
        }
        [Authorize(Roles = "Users")]
        [Route("Home/Details/{AccountId}")]
        public IActionResult Details(int AccountId)
        {
            var account = _account.GetAccAccount(AccountId);
            var model = new AccountViewModel()
            {
               Accounts=account

            };


            return View(model);
        }
      
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
