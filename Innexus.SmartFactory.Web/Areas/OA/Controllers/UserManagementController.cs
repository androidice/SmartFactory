using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Innexus.SmartFactory.Web.Areas.OA.Controllers
{
    [Area(Infrastructure.Section.Areas.OA)]
    [Authorize]
    public class UserManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}