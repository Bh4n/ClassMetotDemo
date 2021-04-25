using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirsName+" "+customer.LastName +" eklendi");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Id: "+customer.Id+"\nİsim: "+customer.FirsName + "\nSoyad: " + customer.LastName + "\nAdres: " + customer.Address);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirsName + " " + customer.LastName + " güncellendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirsName + " " + customer.LastName + " silindi");
        }

    }
}
