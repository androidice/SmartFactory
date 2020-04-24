using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Innexus.SmartFactory.Web.Infrastructure.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetConnectionString(this IConfiguration config) => 
            config.GetConnectionString("DefaultConnection");
    }
}
