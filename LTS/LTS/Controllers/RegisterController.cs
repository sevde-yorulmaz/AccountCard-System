using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using LTS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LTS.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (registerViewModel.Password == registerViewModel.ConfirmPassword && registerViewModel.PhoneNumber==registerViewModel.PhoneNumberConfirm)
                {
                    AppUser user = new AppUser()
                    {
                        UserName = registerViewModel.UserName,
                        Email = registerViewModel.Email,
                        Name = registerViewModel.Name,
                        SurName = registerViewModel.SurName,
                        PhoneNumber = registerViewModel.PhoneNumber,
                    };
                    UserValidator validator = new UserValidator();
                    ValidationResult validationResult=validator.Validate(user);
                    if (validationResult.IsValid)
                    {
                        var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Login");
                        }
                        else
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in validationResult.Errors)
                        {
                            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                        }
                    }
                    
                }
            }
            return View(registerViewModel);
        }
    }
}
