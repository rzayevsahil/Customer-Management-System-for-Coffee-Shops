using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Adapters;
using customer_management_system_for_coffee_shops.Concrete;
using customer_management_system_for_coffee_shops.Entities;
using System;

namespace customer_management_system_for_coffee_shops
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1985, 1, 6),
                FirstName = "Engin",
                LastName = "Demiroğ",
                NationalityId = "28861499108"
            });


            Console.ReadLine();
        }
    }

    
}
