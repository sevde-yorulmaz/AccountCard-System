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
    public class AccountCardGroupManager : IAccountCardGroupService
    {
        private IAccountCardGroupDal _cardGroupDal;

        public AccountCardGroupManager(IAccountCardGroupDal cardGroupDal)
        {
            _cardGroupDal = cardGroupDal;
        }

        public void Add(AccountCardGroup entity)
        {
            _cardGroupDal.Add(entity);  
        }

        public void Delete(AccountCardGroup entity)
        {
            _cardGroupDal.Delete(entity);   
        }

        public List<AccountCardGroup> GetAll()
        {
            return _cardGroupDal.GetAll();
        }

        public AccountCardGroup GetById(int id)
        {
            return _cardGroupDal.GetById(id);
        }

        public void Update(AccountCardGroup entity)
        {
            _cardGroupDal.Update(entity);   
        }
    }
}
