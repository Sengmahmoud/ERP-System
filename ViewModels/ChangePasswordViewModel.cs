using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string UserName{ get; set; }
        [Required]
        [DataType(DataType.Password)]
         [Display(Name = "كلمة السر الحالية")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة السر الجديدة")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد كلمة السر الجديدة")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
