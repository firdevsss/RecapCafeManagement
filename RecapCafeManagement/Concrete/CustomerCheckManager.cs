using RecapCafeManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapCafeManagement.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
