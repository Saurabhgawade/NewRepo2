using entitycodefirstfinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace entitycodefirstfinal.Controllers
{
  
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly SignInManager<IdentityUser> _signinmanager;
        public AccountController(UserManager<IdentityUser>usermanager,SignInManager<IdentityUser> signin)
        {
            _usermanager = usermanager;
            _signinmanager = signin;
        }
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

               var result= await _usermanager.CreateAsync(user, registerobj.Password);
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
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(Signin signinobj)
        {
            if (ModelState.IsValid)
            {
               var result= await _signinmanager.PasswordSignInAsync(signinobj.Email, signinobj.PassWord, signinobj.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError(string.Empty, "invalid");
            }
            return View("SignIn", signinobj);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signinmanager.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
