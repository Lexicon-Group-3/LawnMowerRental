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
        List<Mower> Mowers = Store.mowers;

        public int RentalId { get; set; }
        public int nextId = 0;
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Customer customer { get; set; }
        public Mower mower { get; set; }
        
        public Rental() { }
        
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
             int rentedMowerId = Convert.ToInt32(Console.ReadLine());


            Mower mower1 = new Mower();
            Mower availableMower = mower1.FindAvailableLawnMower(rentedMowerId);
            if (availableMower == null)
            {
                Console.WriteLine($"The lawn mawer with the Id {rentedMowerId} is not available. Please enter another mower Id");
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
        public int Rentalcost()
        {
            Console.WriteLine("Enter the rented mower Id.");
            int input = Convert.ToInt32(Console.ReadLine());
            Mower mower = Mowers.Find(m => m.MowerId == input);
            if( mower != null)
            {
                Console.WriteLine("enter the number of the days rented: ");
                int rentalDays = Convert.ToInt32(Console.ReadLine());
                int rentalcost = rentalDays * mower.Price;
                Console.WriteLine($"The rental cost is: {rentalcost}");
                return rentalcost;
            }
            else
            {
                Console.WriteLine("Invalid mower Id.");
                return 0;
            }
        }
    }
}
