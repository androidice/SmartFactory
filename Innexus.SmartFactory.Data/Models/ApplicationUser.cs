using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Innexus.SmartFactory.Data.Models
{
    public class ApplicationUser: IdentityUser
    {
        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
