using RecapCafeManagement.Abstract;
using RecapMernisServiceReferans;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapCafeManagement.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.IdentityId),
                customer.FirstName,customer.LastName.ToUpper(),customer.Id,customer.DateOfBirth.Year);
        }
    }
}
