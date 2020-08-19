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
        public string UserName { get; set; }
        // [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
 
    }
}
