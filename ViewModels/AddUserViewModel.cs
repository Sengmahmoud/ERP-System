using ERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [Display(Name ="أسم المستخدم")]
        public string UserName { get; set; }
       // [Required]
        [Display(Name ="البريد الالكترونى")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name ="كلمة السر")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name ="الحساب")]
        public int AccountId { get; set; }
        public IEnumerable<AccAccount> AccAccounts { get; set; }
    }
}
