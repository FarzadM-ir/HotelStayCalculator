using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStayCalculator
{
    public class TotalCost
    {
        public int Cost(int theAmountOfPeople, int theAmountOfNights, bool foodService, bool cleaningService)
        {
            int ratePerNight = 200;
            int ratePerPerson = 50;
            int foodCost;
            if (foodService == true)
            {
                foodCost = 10;
            }
            else
            {
                foodCost = 0;
            }
            int cleaningCost;
            if (cleaningService == true)
            {
                cleaningCost = 10;
            }
            else
            {
                cleaningCost = 0;
            }

            return (theAmountOfPeople * ratePerPerson) + (theAmountOfNights * ratePerNight) + (foodCost * theAmountOfPeople * theAmountOfNights) + (cleaningCost * theAmountOfPeople * theAmountOfNights);
        }
    }
}
