using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    public class EditUserViewModel
    {
        public string id { get; set; }
        [Required]
        [Display(Name ="اسم المستخدم")]
        public string UserName { get; set; }
        // [Required]
        [Display(Name ="البريد الالكترونى")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
 
    }
}
