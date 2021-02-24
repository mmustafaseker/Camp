using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mustafa Şeker

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Mustafa";
            customer1.LastName = "Şeker";
            customer1.TcNumber = "123456789";

            //bilgeAdam

            CoorprateCustomer customer2 = new CoorprateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "45321";
            customer2.CompanyName = "BilgeAdam";
            customer2.TaxNumber = "12345678965";

            //önemli bir nokta
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorprateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            //gerçek müşteri - tüzel müşteri
            //SOLID
        }
    }
}
