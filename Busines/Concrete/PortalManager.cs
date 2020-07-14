using Busines.Abstract;
using Busines.Results;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrete
{
    public class PortalManager : IPortalService
    {
        ICustomerDal _customer;
        public PortalManager(ICustomerDal customer)
        {
            _customer = customer;
        }
        public Result Add(Customer customer)
        {
             _customer.Add(customer);
            return new Result(true,"Başarıyla eklendi");
        }

       

        public IList<Customer> GetList(int compId)
        {
           return _customer.GetList(a => a.CompanyId == compId);
        }

      
    }
}
