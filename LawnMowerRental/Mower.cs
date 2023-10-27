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
        List<Mower> mowers = Store.mowers;
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
          
           
            var availableMowers = mowers.Where(mower => mower.Availability)
                .ToList();

            Console.WriteLine("Available Lawn Mowers:");
            foreach (var mower in availableMowers)
            {
                Console.WriteLine($"Mower ID: {mower.MowerId}, Model: {mower.MowerModel}, Availability: {mower.Availability} Price: {mower.Price}");
            }

        }
        
        public Mower FindAvailableLawnMower(int mowerId)
        {
            return mowers.FirstOrDefault(m => m.MowerId == mowerId && m.Availability == true);
        }
        
    }   


 }
