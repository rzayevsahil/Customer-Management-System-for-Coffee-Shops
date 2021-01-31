using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace customer_management_system_for_coffee_shops.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
