using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int nextId = 0;
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Customer customer { get; set; }
        public Mower mower { get; set; }
        
        public Rental() { }
        /*
        public Rental(DateTime rentalDate, DateTime returnDate, int customerId, int RentedMowerId)
        {
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            customerId = customer.CustomerId;
            RentedMowerId = mower.MowerId;
        }
        */
        public Rental(DateTime rentalDate, DateTime returnDate, Customer customerId, Mower mowerId)
        {
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            customer = customerId;
            mower = mowerId;
        }
        public void RentMower()
        {
            Console.WriteLine("Rent a Lawn Mower.");
            Console.WriteLine("Enter the customer Id, please.");
            string userInput = Console.ReadLine();
            
            List<Customer> customers = new List<Customer>();
            
            bool customer = customers.Exists(x => x.CustomerId.Equals(userInput));
            if (customer = false)
            {
                Console.WriteLine("Customer is not registered. Please register the customer first.");
                return;
            }
            Console.WriteLine("Enter the mower Id.");
             int RentedMowerId = Convert.ToInt32(Console.ReadLine());


            /*
            Mower mower = new Mower() { MowerId = 1, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            RentedMowerId = mower.MowerId;
            */
             
            if (Mower.FindAvailableLawnMower(mowerId))
            {
                Console.WriteLine($"The lawn mawer with the Id {RentedMowerId} is not available. Please enter another mower Id");
                return;
            }
            

            Console.WriteLine("Enter the rent date.");
            DateTime RentalDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the return date.");
            DateTime ReturnDate = Convert.ToDateTime(Console.ReadLine());

             List<Rental> rentals = new List<Rental>();

            Rental rental = new Rental();
            RentalId = nextId++;
            mower.Availability = false;
            rentals.Add(rental);

            Console.WriteLine($"The Rental Id is: {nextId++}");
            Console.WriteLine("The rent is registered successfully");

        }
    }
}
