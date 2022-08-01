using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LTS.Controllers
{
    public class AccountCardKindController : Controller
    {
        AccountCardKindManager cardKindManager = new AccountCardKindManager(new EfAccountCardKindDal());
        public IActionResult Index()
        {
            var cardKind = cardKindManager.GetAll();
            return View(cardKind);
        }
        [HttpGet]
        public IActionResult AddCardKind()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCardKind(AccountCardKind accountCardKind)
        {
            accountCardKind.Status = true;
            cardKindManager.Add(accountCardKind);
            return RedirectToAction("Index", "AccountCardKind");
        }
        [HttpGet]
        public IActionResult EditCardKind(int id)
        {
            AccountCardKind accountCardKind = cardKindManager.GetById(id);
            return View(accountCardKind);
        }
        [HttpPost]
        public IActionResult EditCardKind(AccountCardKind accountCardKind)
        {
            cardKindManager.Update(accountCardKind);
            return RedirectToAction("Index", "AccountCardKind");
        }
        public IActionResult DeleteCardKind(int id)
        {
            AccountCardKind accountCardKind = cardKindManager.GetById(id);
            accountCardKind.Status = false;
            cardKindManager.Update(accountCardKind);
            return RedirectToAction("Index", "AccountCardKind");
        }
    }
}
