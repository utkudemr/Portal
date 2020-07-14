using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busines.Results;

namespace Busines.Abstract
{
    public interface ICustomerInsert
    {
        Result Add(Customer customer);
    }
}
