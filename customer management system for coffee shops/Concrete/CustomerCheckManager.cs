using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace customer_management_system_for_coffee_shops.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
