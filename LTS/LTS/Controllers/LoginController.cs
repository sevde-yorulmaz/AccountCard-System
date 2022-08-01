using EntityLayer.Concrete;
using LTS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LTS.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {
        private SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            LoginViewModel login = new LoginViewModel();
            return View(login);
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginView.UserName, loginView.Password, true, true); //ilk true parolayı hatırlasın mı?ikinci true ise eğer 5 defa yanlış giriş yaparsa o zaman belli bir süre sisteme girişi engellencek
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AccountCard");
                }
                else
                {
                    return View(loginView);
                }
            }
            return View(loginView);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
