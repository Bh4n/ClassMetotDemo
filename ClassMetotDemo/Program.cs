using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirsName = "Bahan";
            customer1.LastName = "Morova";
            customer1.Address = "Ankara_TR";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirsName = "Enes";
            customer2.LastName = "Bahan";
            customer2.Address = "Malatya_TR";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.List(customer2);
            customerManager.Delete(customer1);
        }
    }
}
