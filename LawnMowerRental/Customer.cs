using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        

        //Create a constructor
        public Customer()
        {
        }

        public Customer(string customerId, string name, string phoneNumber, string address, string type)
        {
            CustomerId = customerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Type = type;
        }

        static List<Customer> customers = new List<Customer>();
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

            Console.WriteLine("Is the customer basic or prime?");
            string type = Console.ReadLine();

            if (Exists(customerId))
            {
                Console.WriteLine("The customer is already registered.");
                return; 
            }
            else
            {
                if (type == "basic")
                {
                    Customer newCustomer = new Customer(customerId, name, phoneNumber, address, type);
                    customers.Add(newCustomer);
                    Console.WriteLine("The customer is registered successfully.");
                }
                else if (type == "prime")
                {
                    Console.WriteLine("Please complete the payment of 500 SEK. Type 'done' when completed.");
                    
                    string userType = Console.ReadLine();
                    Customer newCustomer = new Customer(customerId, name, phoneNumber, address, type);
                    customers.Add(newCustomer);
                    Console.WriteLine("The customer is registered successfully.");

                }
                else
                {
                    Console.WriteLine("Invalid customer type.");
                    
                }
            }
        }
        public static bool Exists(string customerId)
        {

            return customers.Any(customer => customer.CustomerId == customerId);
        }
    }
}
