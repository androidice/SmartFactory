using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Innexus.SmartFactory.Data.Models;
using Innexus.SmartFactory.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Innexus.SmartFactory.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login() {
            LoginFormModel vm = new LoginFormModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginFormModel vm)
        {
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                var user = await this.userManager.FindByEmailAsync(vm.UserName);
                bool isLogin = await this.userManager.CheckPasswordAsync(user, vm.Password);
                if (user != null && isLogin)
                {

                    var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
                    identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

                    await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme,
                        new ClaimsPrincipal(identity));

                    return RedirectToAction(nameof(HomeController.Pages),
                                            Infrastructure.Section.Controllers.HOME);
                }
                else {
                    ModelState.AddModelError("", "Invalid UserName or Password");
                }
            }
 
            return View(vm);
        }

    }
}