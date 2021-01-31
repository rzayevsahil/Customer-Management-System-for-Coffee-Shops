using customer_management_system_for_coffee_shops.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace customer_management_system_for_coffee_shops.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
