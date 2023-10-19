using LawnMowerRental;
using System;
using System.Diagnostics.Metrics;
using System.IO;


public class Program
{
    static void Main(string[] args)
    {

        Customer customerInstance = new Customer();
        Rental rental = new Rental();
        Mower mower = new Mower();

        bool exitRequested = false;

        while (!exitRequested)
        {
            DisplayMenu();

            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice))
            {
                Console.WriteLine("User choice: " + choice);

                switch (choice)
                {
                    case 1:
                        Customer customer = new Customer();
                        customer.RegisterCustomer(customerInstance);
                        break;

                    case 2:
                        rental.RentMower();
                        break;
                        /*
                    case 3:
                        customerInstance.ListCustomers();
                        break;

                    case 4:
                        customerInstance.ListCustomersWithRentals();
                        break;
                        */
                    case 5:
                        Mower mowerInstance = new Mower();
                        mowerInstance.AvailableLawnMowers();
                        break;

                    case 6:
                        exitRequested = true;
                        Console.WriteLine("Exiting the app.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    public static List<Mower> InitializeMowers()
    {
        new Mower() { MowerId = 1, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 2, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 };
            new Mower() { MowerId = 3, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 4, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 5, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 6, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 };
            new Mower() { MowerId = 7, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 8, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 9, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 10, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 11, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 12, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
            new Mower() { MowerId = 13, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 };
            new Mower() { MowerId = 14, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 };
        new Mower() { MowerId = 15, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 };
        


        return new List<Mower>();
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Lawn Mower Rental System");
        Console.WriteLine("1. Add a new customer");
        Console.WriteLine("2. Register a new rental");
        Console.WriteLine("3. Display the list of customers");
        Console.WriteLine("4. Display the list of customers with rentals");
        Console.WriteLine("5. Display available Lawn Mowers in stock");
        Console.WriteLine("6. Exit the app");
        Console.WriteLine("Enter an option:");
    }
}
