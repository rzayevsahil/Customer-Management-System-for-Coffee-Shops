using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace customer_management_system_for_coffee_shops.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        

        public bool CheckIfRealPerson(Customer customer)
        {
            
             //return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
            return TaskAsync(customer).Result;
        }

        public static async Task <bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var durum = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
            return durum.Body.TCKimlikNoDogrulaResult;
        }
    }
}
