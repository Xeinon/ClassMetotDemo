using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();

        public void Add(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine(customer.Name + " " + customer.LastName + " " + "Müşteri eklendi!");
        }

        public void List()
        {
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.Name + " " + customer.LastName);
            }
        }

        public void Update(Customer customer)
        {

            Console.WriteLine("Müşteri güncellendi");
        }

        public void Delete(Customer customer)
        {
            customerList.Remove(customer);
            Console.WriteLine(customer.Name + " " + customer.LastName + " " + "Müşteri listeden çıkarıldı");
        }
    }
}
