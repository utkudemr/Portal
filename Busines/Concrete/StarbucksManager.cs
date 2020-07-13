using Busines.Abstract;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StarbucksManager : IStarbucksService
    {
        IMernisService _mernis;
        ICustomerDal _customer;
        public StarbucksManager(IMernisService mernis, ICustomerDal customer)
        {
            _mernis = mernis;
            _customer = customer;
        }
        public bool Add(Customer customer)
        {
            if (_mernis.isExist(customer) == false)
            {
                return false;
            }
            _customer.Add(customer);
            return true;
        }

        public IList<Customer> GetList(int compId)
        {
            return _customer.GetList(a => a.CompanyId == compId);
        }

       
    }
}
