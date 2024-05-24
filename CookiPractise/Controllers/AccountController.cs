using CookiPractise.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace CookiPractise.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;
        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser>signInManager)
        {
            _userManager = userManager;
            _signinManager = signInManager;        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register registerobj)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = registerobj.Email, Email = registerobj.Email };
              var result= await  _userManager.CreateAsync(user, registerobj.Password);
                if (result.Succeeded)
                {
                   await _signinManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Employees");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login loginobj)
        {
            if (ModelState.IsValid)
            {
               var result=await _signinManager.PasswordSignInAsync(loginobj.Email, loginobj.Password,loginobj.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Employees");
                }
            }
            ModelState.AddModelError(string.Empty, "login credential wrong");
            return View("Login",loginobj);
        }

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return View("Login");
        }

    }
}
