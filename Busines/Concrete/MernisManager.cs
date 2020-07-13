using Busines.KpsServiceReference;
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MernisManager : IMernisService
    {
        public bool isExist(Customer user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return  client.TCKimlikNoDogrula(Convert.ToInt64(user.Tc),user.Firstname.ToUpper(),user.Lastname.ToUpper(),user.Dateofbirth.Year);
        }
    }
}
