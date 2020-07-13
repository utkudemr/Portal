
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IList<Customer> GetList(int compId);
        bool Add(Customer customer);
    }
}
