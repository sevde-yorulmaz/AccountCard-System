using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LTS.Controllers
{
    public class AccountCardSubGroupController : Controller
    {
        AccountCardSubGroupManager cardSubGroupManager = new AccountCardSubGroupManager(new EfAccountCardSubGroupDal());
        public IActionResult Index()
        {
            var cardSubgroup = cardSubGroupManager.GetAll();
            return View(cardSubgroup);
        }
        [HttpGet]
        public IActionResult AddCardSubGroup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCardSubGroup(AccountCardSubGroup cardSubGroup)
        {
            cardSubGroup.Status = true;
            cardSubGroupManager.Add(cardSubGroup);
            return RedirectToAction("Index", "AccountCardSubGroup");
        }
        [HttpGet]
        public IActionResult EditCardSubGroup(int id)
        {
            AccountCardSubGroup cardSubGroup = cardSubGroupManager.GetById(id);
            return View(cardSubGroup);
        }
        [HttpPost]
        public IActionResult EditCardSubGroup(AccountCardSubGroup cardSubGroup)
        {
            cardSubGroupManager.Update(cardSubGroup);
            return RedirectToAction("Index", "AccountCardSubGroup");
        }
        public IActionResult DeleteCardSubGroup(int id)
        {
            AccountCardSubGroup cardSubGroup = cardSubGroupManager.GetById(id);
            cardSubGroup.Status = false;
            cardSubGroupManager.Update(cardSubGroup);
            return RedirectToAction("Index", "AccountCardSubGroup");
        }
    }
}
