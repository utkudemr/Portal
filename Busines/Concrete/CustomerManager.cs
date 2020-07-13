using Busines.Abstract;
using Busines.Constants;
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
        public CustomerManager(IStarbucksService starbucks, IPortalService portal, ICompanyService company)
        {
            _portal = portal;
            _starbucks = starbucks;
            _company = company;
        }


        public bool Add(Customer customer)
        {
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

       
    }
}
