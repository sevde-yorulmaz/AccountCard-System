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
    public class AccountCardSubGroupManager:IAccountCardSubGroupService
    {
        private IAccountCardSubGroupDal _cardSubGroupDal;

        public AccountCardSubGroupManager(IAccountCardSubGroupDal cardSubGroupDal)
        {
            _cardSubGroupDal = cardSubGroupDal;
        }

        public void Add(AccountCardSubGroup entity)
        {
            _cardSubGroupDal.Add(entity);
        }

        public void Delete(AccountCardSubGroup entity)
        {
            _cardSubGroupDal.Delete(entity);    
        }

        public List<AccountCardSubGroup> GetAll()
        {
           return  _cardSubGroupDal.GetAll();
        }

        public AccountCardSubGroup GetById(int id)
        {
           return _cardSubGroupDal.GetById(id);
        }

        public void Update(AccountCardSubGroup entity)
        {
            _cardSubGroupDal.Update(entity);
        }
    }
}
