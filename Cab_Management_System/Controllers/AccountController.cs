using Cab_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cab_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser>userManager,SignInManager<IdentityUser>signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUser registerobj)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = registerobj.Email, Email = registerobj.Email };

                var result=await _userManager.CreateAsync(user, registerobj.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: true);
                    return RedirectToAction("Index", "Cabs");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                

            }
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignIn signInobj)
        {
            if (ModelState.IsValid)
            {
               var result= await _signInManager.PasswordSignInAsync(signInobj.Email, signInobj.Password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Cabs");
                }
                ModelState.AddModelError(string.Empty, "Invalid password");
            }
            return View("SignIn", signInobj);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return View("Register");
        }
    }
}
