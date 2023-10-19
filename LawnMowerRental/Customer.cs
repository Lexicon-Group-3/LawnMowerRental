using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
    public class Customer
    {
       public int CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        static List <Customer> customers = new List<Customer>();

        //Create a constructor
        public Customer() 
        {
        }

        public Customer(int customerId, string name, string phoneNumber, string address)
        {
            CustomerId = customerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

       public void RegisterCustomer(Customer customer)
        {
            Console.WriteLine("Register New Customer");

            Console.WriteLine("Enter customer Id: ");
            string customerId = Console.ReadLine();

            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter customer phone: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();

            bool exists = customers.Any(customerId => customerId.Equals(customer.CustomerId));

            if (exists)
            {
                Console.WriteLine($"The customer with the Id {CustomerId} is registered already.");
            }
            else
            {
                customers.Add(customer);
                Console.WriteLine("The customer is added successfully.");
            }

        }

    }
}
