using System;
using System.Collections.Generic;
using System.Text;
namespace RecapCafeManagement.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
