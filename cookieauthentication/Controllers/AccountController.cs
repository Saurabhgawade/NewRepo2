using cookieauthentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace cookieauthentication.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly SignInManager<IdentityUser> _signinmanager;
        public AccountController(UserManager<IdentityUser> usermanager,SignInManager<IdentityUser> signinmanager)
        {
            _usermanager = usermanager;
            _signinmanager = signinmanager;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register registerobj)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = registerobj.Email, Email = registerobj.Email };
                var result = await _usermanager.CreateAsync(user, registerobj.Password);

                if (result.Succeeded)
                {
                    await _signinmanager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Employees");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                
            }
            return View("Index");

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
                var result = await _signinmanager.PasswordSignInAsync(loginobj.Email, loginobj.Password, isPersistent: false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "employees");
                }
                ModelState.AddModelError(string.Empty, "not registered");
            }
            return View("Login", loginobj);
        }
    }
}
