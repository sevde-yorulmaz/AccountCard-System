using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LTS.Controllers
{
    public class AccountCardTypeController : Controller
    {
        AccountCardTypeManager accountCardTypeManager = new AccountCardTypeManager(new EfAccountCardTypeDal());
        public IActionResult Index()
        {
            var cardtypevalue = accountCardTypeManager.GetAll();

            return View(cardtypevalue);
        }
        [HttpGet]
        public IActionResult AddCardType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCardType(AccountCardType accountCardType)
        {
            accountCardType.Status = true;
            accountCardTypeManager.Add(accountCardType);
            return RedirectToAction("Index", "AccountCardType");
        }
        [HttpGet]
        public IActionResult EditCardType(int id)
        {
            AccountCardType accountCardType = accountCardTypeManager.GetById(id);
            return View(accountCardType);
        }
        [HttpPost]
        public IActionResult EditCardType(AccountCardType accountCardType)
        {
            accountCardTypeManager.Update(accountCardType);
            return RedirectToAction("Index", "AccountCardType");
        }
        public IActionResult DeleteCardType(int id)
        {
            AccountCardType cardType = accountCardTypeManager.GetById(id);
            cardType.Status = false;
            accountCardTypeManager.Update(cardType);
            return RedirectToAction("Index", "AccountCardType");
        }
    }
}
