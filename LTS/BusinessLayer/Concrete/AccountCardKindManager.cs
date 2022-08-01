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
    public class AccountCardKindManager:IAccountCardKindService
    {
        private IAccountCardKindDal _cardKindDal;

        public AccountCardKindManager(IAccountCardKindDal cardKindDal)
        {
            _cardKindDal = cardKindDal;
        }

        public void Add(AccountCardKind entity)
        {
            _cardKindDal.Add(entity);   
        }

        public void Delete(AccountCardKind entity)
        {
            _cardKindDal.Delete(entity);    
        }

        public List<AccountCardKind> GetAll()
        {
            return _cardKindDal.GetAll();   
        }

        public AccountCardKind GetById(int id)
        {
            return _cardKindDal.GetById(id);    
        }

        public void Update(AccountCardKind entity)
        {
            _cardKindDal.Update(entity);    
        }
    }
}
