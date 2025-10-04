using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStayCalculator
{
    public class Services
    {
        public void Service(out bool foodService, out bool cleaningService, out string food, out string cleaning)
        {
            Console.WriteLine("Would you like our full breakfast,lunch and dinner service (yes or no) :");
            food = Console.ReadLine().ToLower();
            if (food == "yes")
            {
                foodService = true;
            }
            else if (food == "no")
            {
                foodService = false;
            }
            else
            {
                while (food != "yes" && food != "no")
                {
                    Console.WriteLine("Please enter a valid answer(yes or no): ");
                    food = Console.ReadLine().ToLower();
                }
                if (food == "yes")

                {
                    foodService = true;

                }

                else
                {
                    foodService = false;
                }
            }
            Console.WriteLine("What about our cleaning service(yes or no):");
            cleaning = Console.ReadLine().ToLower();
            if (cleaning == "yes")
            {
                cleaningService = true;
            }
            else if (cleaning == "no")
            {
                cleaningService = false;
            }
            else
            {
                while (cleaning != "yes" && cleaning != "no")
                {
                    Console.WriteLine("Please enter a valid answer(yes or no): ");
                    cleaning = Console.ReadLine().ToLower();
                }
                if (cleaning == "yes")

                {
                    cleaningService = true;
                }
                else
                {
                    cleaningService = false;
                }
            }
        }
    }
}
