using Busines.Abstract;
using Busines.Constants;
using Busines.Results;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerInsert
    {
        IStarbucksService _starbucks;
        IPortalService _portal;
        ICompanyService _company;
        ICustomerDal _customer;
        public CustomerManager(IStarbucksService starbucks, IPortalService portal, ICompanyService company, ICustomerDal customer)
        {
            _portal = portal;
            _starbucks = starbucks;
            _company = company;
            _customer = customer;
        }


        public Result Add(Customer customer)
        {
            if(!isExist(customer.Tc,customer.CompanyId))
            {
                return new Result(false, "Kullanıcı mevcut");
            }
            var companyName = _company.Get(customer.CompanyId).Name;
            if (companyName == CompanyNames.Starbucks)
            {
                return _starbucks.Add(customer);
            }
            else
            {
                return  _portal.Add(customer);
            }
        }

        public bool isExist(long tc,int compId)
        {
            var user = _customer.Get(a=>a.Tc==tc && a.CompanyId==compId);
            if(user==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
