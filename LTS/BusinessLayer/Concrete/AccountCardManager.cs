using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AccountCardManager:IAccountCardService
    {
        private IAccountCardDal _accountCardDal;

        public AccountCardManager(IAccountCardDal accountCardDal)
        {
            _accountCardDal = accountCardDal;
        }

        public void Add(AccountCard entity)
        {
            _accountCardDal.Add(entity);    
        }

        public void Delete(AccountCard entity)
        {
            _accountCardDal.Delete(entity); 
        }

        public List<AccountCard> GetAll()
        {
            return _accountCardDal.GetAll();    
        }

        public AccountCard GetById(int id)
        {
            return _accountCardDal.GetById(id);    
        }

        public void Update(AccountCard entity)
        {
            _accountCardDal.Update(entity); 
        }
    }
}
