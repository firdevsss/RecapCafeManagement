using System;
using System.Collections.Generic;
using System.Text;

namespace RecapCafeManagement.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual
            void Save(Customer customer)
        {
            Console.WriteLine("Veritabanına Kaydedildi :" + customer.FirstName);
        }
    }
}
