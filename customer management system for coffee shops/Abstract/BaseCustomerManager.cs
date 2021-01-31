using System;
using System.Collections.Generic;
using System.Text;
using customer_management_system_for_coffee_shops.Entities;

namespace customer_management_system_for_coffee_shops.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : " + customer.FirstName);
        }
    }
}
