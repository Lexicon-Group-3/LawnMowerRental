using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
    public class Store
    {
        //customers list
        //mowers list
        //rental list
        //calling this class to other classes to check availability
      public static  List<Mower> mowers { get; set; } = new List<Mower>
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

    }
}
