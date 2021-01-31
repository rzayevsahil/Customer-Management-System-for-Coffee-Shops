using customer_management_system_for_coffee_shops.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace customer_management_system_for_coffee_shops.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
