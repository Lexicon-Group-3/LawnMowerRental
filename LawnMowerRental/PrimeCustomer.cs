using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
    public class PrimeCustomer : Customer
    {
        public int BonusPoints { get; set; }

        public PrimeCustomer(string customerId, string name, string phoneNumber, string address, string type) : base(customerId, name, phoneNumber, address, type)
        {
            BonusPoints = 0;
        }

        
        public void AddBonusPoints(int rentalCost)
        {
            BonusPoints += rentalCost;
        }
    }
}
