using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using LTS.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace LTS.Controllers
{
    public class AccountCardController : Controller
    {
       AccountCardManager cardManager=new AccountCardManager(new EfAccountCardDal());
        AccountCardGroupManager groupManager = new AccountCardGroupManager(new EfAccountCardGroupDal());
        AccountCardKindManager cardKindManager = new AccountCardKindManager(new EfAccountCardKindDal());
        AccountCardSubGroupManager SubGroupManager= new AccountCardSubGroupManager(new EfAccountCardSubGroupDal());
        AccountCardTypeManager typeManager=new AccountCardTypeManager(new EfAccountCardTypeDal());
        public IActionResult Index()
        {
            var card = cardManager.GetAll().Where(x=>x.Status==true);
            var group=groupManager.GetAll().Where(x => x.Status == true);
            var kind = cardKindManager.GetAll().Where(x => x.Status == true);
            var type=typeManager.GetAll().Where(x => x.Status == true);
            var subGroup = SubGroupManager.GetAll().Where(x => x.Status == true);
            GetAllAccountCardViewModel getAllAccountCard = new GetAllAccountCardViewModel() 
            {
                cards = card.ToList(),
                cardGroups= group.ToList(),
                cardKinds= kind.ToList(),
                cardSubGroups= subGroup.ToList(),
                cardTypes= type.ToList(),
            
            };
            //var JsonAccountCard=JsonConvert.SerializeObject(getAllAccountCard);
            //return Json(JsonAccountCard);
            return View(getAllAccountCard);
        }

        [HttpGet]
        public IActionResult AddAccountCard()
        {
            AddAccountCardViewModel addAccount=new AddAccountCardViewModel()
            {
                cardGroups=groupManager.GetAll(),
                cardKinds=cardKindManager.GetAll(),
                cardTypes=typeManager.GetAll(),
                cardSubGroups=SubGroupManager.GetAll()
            };
            return View(addAccount);
        }
        [HttpPost]
        public IActionResult AddAccountCard(AddAccountCardViewModel addAccount)
        {
            var type=typeManager.GetById(addAccount.accountCard.AccountCardTypeId);
            var kind=cardKindManager.GetById(addAccount.accountCard.AccountCardKindId);
            var group = groupManager.GetById(addAccount.accountCard.AccountCardGroupId);
            var subgroup=SubGroupManager.GetById(addAccount.accountCard.AccountCardSubGroupId);
            if (ModelState.IsValid)
            {
                addAccount.accountCard.Address=addAccount.address;
                addAccount.accountCard.Degree=addAccount.degree;
                addAccount.accountCard.TaxAdministration=addAccount.taxAdministration;
                addAccount.accountCard.TaxNumber=addAccount.taxNumber;
                addAccount.accountCard.TCNo=addAccount.tcNo;
                addAccount.accountCard.Status = addAccount.status;

                AccountCard accountCard = new AccountCard();

                accountCard.Status = addAccount.accountCard.Status;
                accountCard.AccountCardGroup=group;
                accountCard.AccountCardSubGroup=subgroup;
                accountCard.AccountCardKind = kind;
                accountCard.AccountCardType=type;
                accountCard.Address = addAccount.accountCard.Address;
                accountCard.Degree = addAccount.accountCard.Degree;
                accountCard.TaxAdministration = addAccount.accountCard.TaxAdministration;
                accountCard.TaxNumber = addAccount.accountCard.TaxNumber;
                accountCard.TCNo = addAccount.accountCard.TCNo;

                if (accountCard != null)
                {
                    cardManager.Add(addAccount.accountCard);
                    return RedirectToAction("Index", "AccountCard");
                }
            }
            return View(addAccount);                       
            
        }
        [HttpGet]
        public IActionResult EditAccountCard(int id)
        {
            AccountCard account = cardManager.GetById(id);

            return View(account);
        }
        [HttpPost]
        public IActionResult EditAccountCard(AccountCard accountCard)
        {
            cardManager.Update(accountCard);
            return RedirectToAction("Index", "AccountCard");
        }
        public IActionResult DeleteAccountCard(int id)
        {
            AccountCard card = cardManager.GetById(id);
            card.Status = false;
            cardManager.Update(card);
            return RedirectToAction("Index", "AccountCard");
        }
    }
}
