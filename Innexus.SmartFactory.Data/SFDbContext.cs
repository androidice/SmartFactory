using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Innexus.SmartFactory.Data.Models;

namespace Innexus.SmartFactory.Web.Data
{
    public class SFDbContext 
        : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public SFDbContext(DbContextOptions<SFDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
