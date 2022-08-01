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
    public class AccountCardTypeManager:IAccountCardTypeService
    {
        private IAccountCardTypeDal _cardTypeDal;

        public AccountCardTypeManager(IAccountCardTypeDal cardTypeDal)
        {
            _cardTypeDal = cardTypeDal;
        }

        public void Add(AccountCardType entity)
        {
            _cardTypeDal.Add(entity); 
        }

        public void Delete(AccountCardType entity)
        {
            _cardTypeDal.Delete(entity);
        }

        public List<AccountCardType> GetAll()
        {
            return _cardTypeDal.GetAll();
        }

        public AccountCardType GetById(int id)
        {
            return _cardTypeDal.GetById(id);
        }

        public void Update(AccountCardType entity)
        {
            _cardTypeDal.Update(entity);
        }
    }
}
