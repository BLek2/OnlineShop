using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models.AnotherModels
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string NameCustomer { get; set; }
        public string SurnameCustomer { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string WayToDeliver { get; set; }
        public string WayToPay { get; set; }
        public DateTime DateTime { get; set; }
    }
}