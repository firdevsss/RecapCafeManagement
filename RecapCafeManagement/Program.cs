using RecapCafeManagement.Abstract;
using RecapCafeManagement.Concrete;
using System;

namespace RecapCafeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new SturbucksCustomerManager() ;
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2004, 09, 11),FirstName="firdevs",LastName="inal",IdentityId="292389284832",Id = 3});

            Console.ReadLine();
        }
    }
}
