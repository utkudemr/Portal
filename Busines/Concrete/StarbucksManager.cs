using Busines.Abstract;
using Busines.Results;
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
        public Result Add(Customer customer)
        {
            if (_mernis.isExist(customer) == false)
            {
                return new Result(false, "Kullanıcı bulunamadı");
            }
            _customer.Add(customer);
            return new Result(true, "Başarıyla eklendi");
        }

        public IList<Customer> GetList(int compId)
        {
            return _customer.GetList(a => a.CompanyId == compId);
        }

       
    }
}
