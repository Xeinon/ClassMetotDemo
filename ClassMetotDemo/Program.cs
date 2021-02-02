using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
            Id = 1,
            CustomerId = 001,
            Name = "Orhan",
            LastName = "Çelik",
            };
            

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerId = 002;
            customer2.Name = "Veli";
            customer2.LastName = "Kanat";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerId = 003;
            customer3.Name = "Ali";
            customer3.LastName = "Burgul";
                     
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            
            customerManager.List();
            customerManager.Delete(customer1);


        }
    }
}
