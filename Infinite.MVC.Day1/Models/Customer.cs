using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinite.MVC.Day1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1001 ,Name="Balaji",MobileNo="6483682663" },
                new Customer{Id=1002 ,Name="Pooja",MobileNo="64863882663" },
                new Customer{Id=1003 ,Name="Kiran",MobileNo="64836852663" }
            };
        }
    }
}