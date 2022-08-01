using DataAccessLayer.Concrete.EntityFramework.Context;
using EntityLayer.Concrete;
using LTS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LTS.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly DataContext _data;
        private readonly SignInManager<AppUser> _signInManager;

        public UserController(UserManager<AppUser> userManager, DataContext data, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _data = data;
            _signInManager = signInManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetUser()//kullanıcı Lisesini getirecek
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUser)//yeni kullanıcı ekleme
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Name=addUser.name,
                    SurName=addUser.surname,
                    PhoneNumber=addUser.phone,
                    Email=addUser.mail,
                    UserName=addUser.username
                    
                };
                var result = await _userManager.CreateAsync(user, addUser.password);
                if (result.Succeeded)
                {
                    return RedirectToAction("GetUser", "User");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(addUser);
            
        }
        [HttpGet]
        public IActionResult EditUser(int id)//kullanıcı bilgileri güncelleme
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            EditUserViewModel editUser = new EditUserViewModel() 
            { 
                Id=user.Id,
                name=user.Name,
                surname=user.SurName,
                phone=user.PhoneNumber,
                mail=user.Email,
                username=user.UserName
            
            
            };
            return View(editUser);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel editUser)
        {
            var uservalue = _userManager.Users.Where(x => x.Id == editUser.Id).FirstOrDefault();
            uservalue.Name = editUser.name;
            uservalue.SurName = editUser.surname;
            uservalue.PhoneNumber=editUser.phone;
            uservalue.Email = editUser.mail;
            uservalue.UserName = editUser.username;
            var result = await _userManager.UpdateAsync(uservalue);
            if (result.Succeeded)
            {
                _data.SaveChanges();
                return RedirectToAction("GetUser", "User");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteUser(int id)//kullanıcı silme
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var result = await _userManager.DeleteAsync(user);//Databaseden direk kullanıcıyı siler tekrar geri alınamaz
            if (result.Succeeded)
            {
                return RedirectToAction("GetUser", "User");
            }
            return RedirectToAction("DeleteUser", "User");
        }
        public PartialViewResult UserNavbarPartial()//Side-Bar burada 
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> UserProfileEdit()//Giriş yapan kişinin kendi profilini görüp düzenlemesi
        {
            AppUser users = await _userManager.GetUserAsync(HttpContext.User);
            
            InformationUser getUser = new InformationUser()
            {
                user = users,
                
            };
            return View(getUser);

        }
        [HttpPost]
        public async Task<IActionResult> UserProfileEdit(InformationUser user)
        {
            var values = _userManager.Users.Where(x => x.Id == user.user.Id).FirstOrDefault();
            values.Name = user.user.Name;
            values.SurName = user.user.SurName;
            values.UserName = user.user.UserName;
            values.PhoneNumber = user.user.PhoneNumber;
            values.Email = user.user.Email;

            var result = await _userManager.UpdateAsync(values);

            if (result.Succeeded)
            {
                _data.SaveChanges();
                return RedirectToAction("UserProfileEdit", "User");
            }
            return View();

        }
    }
}
