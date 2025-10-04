using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStayCalculator
{
    public class DetailsOfStay
    {
        public void Details(out int theAmountOfPeople, out int theAmountOfNights)
        {
            Console.WriteLine("How many people will be stayin in your room in total (Including yourself):");
            theAmountOfPeople = Convert.ToInt32(Console.ReadLine());
            while (theAmountOfPeople <= 0 || theAmountOfPeople > 5)
            {
                Console.WriteLine("Please enter a valid number (must be between 1 and 5):");
                theAmountOfPeople = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("How many nights will your stay be:");
            theAmountOfNights = Convert.ToInt32(Console.ReadLine());
            while (theAmountOfNights <= 0 || theAmountOfNights > 30)
            {
                Console.WriteLine("Please enter a valid number (must be between 1 and 30):");
                theAmountOfNights = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
