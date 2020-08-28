using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    public class AddRoleViewModel
    {
        [Required]
        [Display(Name = "الصلاحية")]
        public string RoleName { get; set; }
    }
}
