using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace customer_management_system_for_coffee_shops.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager //, ICustomerCheckService
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                //true dönerse kayd et
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }
        
    }
}
