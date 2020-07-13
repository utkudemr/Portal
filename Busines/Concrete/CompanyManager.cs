using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _company;
        public CompanyManager(ICompanyDal company)
        {
            _company = company;
        }
        public Company Get(int id)
        {
            return _company.Get(a=>a.Id==id);
        }

        public IList<Company> GetList()
        {
            return _company.GetList();
        }
    }
}
