using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using LTS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LTS.Controllers
{
    public class AccountCardGroupController : Controller
    {
        AccountCardGroupManager cardGroupManager = new AccountCardGroupManager(new EfAccountCardGroupDal());
        AccountCardSubGroupManager SubGroupManager = new AccountCardSubGroupManager(new EfAccountCardSubGroupDal());

        public IActionResult Index()
        {
            var cardgroup = cardGroupManager.GetAll();
            return View(cardgroup);
        }
        [HttpGet]
        public IActionResult AddCardGroup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCardGroup(AccountCardGroup cardGroup)
        {
            cardGroup.Status = true;
            cardGroupManager.Add(cardGroup);
            return RedirectToAction("Index", "AccountCardGroup");
        }
        
        [HttpGet]
        public IActionResult EditCardGroup(int id)
        {
            AccountCardGroup cardGroup = cardGroupManager.GetById(id);
            return View(cardGroup);
        }
        [HttpPost]
        public IActionResult EditCardGroup(AccountCardGroup cardGroup)
        {
            cardGroupManager.Update(cardGroup);
            return RedirectToAction("Index", "AccountCardGroup");
        }
        public IActionResult DeleteCardGroup(int id)
        {
            AccountCardGroup accountCardGroup = cardGroupManager.GetById(id);
            accountCardGroup.Status = false;
            cardGroupManager.Update(accountCardGroup);
            return RedirectToAction("Index", "AccountCardGroup");
        }
    }
}
