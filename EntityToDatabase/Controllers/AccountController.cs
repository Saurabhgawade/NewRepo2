using EntityToDatabase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Identity.Client;

namespace EntityToDatabase.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;
        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser>signInManager)
        {
            _userManager = userManager;
            _signinManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();

        }
        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Students");
        }
        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUser registeruser)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = registeruser.Email, Email = registeruser.Email };

                var result=await _userManager.CreateAsync(user, registeruser.Password);

                if (result.Succeeded)
                {
                   await _signinManager.SignInAsync(user, isPersistent:false);

                    return RedirectToAction("Index", "Students");
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
            return View("Login");
        }
        public async Task<IActionResult>Login(LoginUser loginuser)
        {
            if (ModelState.IsValid)
            {
                var result = await _signinManager.PasswordSignInAsync(loginuser.Email, loginuser.Password,loginuser.RememberMe,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Students");
                }
                ModelState.AddModelError(string.Empty, "Invalid username password");
                
            }
            return View("Login",loginuser);
        }
    }
   
}
