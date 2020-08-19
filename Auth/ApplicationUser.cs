using ERP.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Auth
{
    public class ApplicationUser:IdentityUser
    {
        public int AccAcountId { get; set; }
        public AccAccount AccAccount { get; set; }
    }
}
