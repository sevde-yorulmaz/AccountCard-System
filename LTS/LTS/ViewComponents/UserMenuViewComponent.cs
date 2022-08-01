using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LTS.ViewComponents
{
    public class UserMenuViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _user;

        public UserMenuViewComponent(UserManager<AppUser> user)
        {
            _user = user;
        }

        public async Task<IViewComponentResult> InvokeAsync()//Giriş yapan kişinin bilgileri görünsün
        {
            AppUser users = await _user.GetUserAsync(HttpContext.User);
            return View("Default.cshtml", users);
        }
    }
}
