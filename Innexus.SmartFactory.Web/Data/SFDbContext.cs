using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Innexus.SmartFactory.Web.Data
{
    public class SFDbContext : IdentityDbContext
    {
        public SFDbContext(DbContextOptions<SFDbContext> options)
            : base(options)
        {
        }
    }
}
