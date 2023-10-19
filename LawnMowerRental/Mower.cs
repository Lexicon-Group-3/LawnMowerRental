using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
    public class Mower
    {
        public int MowerId { get; set; }
        public string MowerModel { get; set; }
        public bool Availability { get; set; }
        public int Price { get; set; }

        public Mower()
        {
        }

        public Mower(int mowerId, string mowerModel, bool availability, int price)
        {
            MowerId = mowerId;
            MowerModel = mowerModel;
            Availability = availability;
            Price = price;


        }
        

        public  void AvailableLawnMowers()
        {
            List<Mower> mowers = new List<Mower>
        {
            new Mower() { MowerId = 1, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 2, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 },
            new Mower() { MowerId = 3, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 4, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 5, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 6, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 },
            new Mower() { MowerId = 7, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 8, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 9, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 10, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 11, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 12, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 13, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 },
            new Mower() { MowerId = 14, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = true, Price = 250 },
            new Mower() { MowerId = 15, MowerModel = "HUSQVARNA LB 448S KLIPPO™", Availability = false, Price = 250 }
        };
           
            var availableMowers = mowers.Where(mower => mower.Availability)
                .ToList();

            Console.WriteLine("Available Lawn Mowers:");
            foreach (var mower in availableMowers)
            {
                Console.WriteLine($"Mower ID: {mower.MowerId}, Model: {mower.MowerModel}, Availability: {mower.Availability} Price: {mower.Price}");
            }

        }
        static Mower FindAvailableLawnMower(int mowerId)
        {
            return mowers.FirstOrDefault(m => m.MowerId == mowerId && m.Availability == true);
        }
    }   


    }
