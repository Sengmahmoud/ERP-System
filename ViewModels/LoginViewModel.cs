using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "أسم المستخدم")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة السر")]
        public string Password { get; set; }
    }
}
