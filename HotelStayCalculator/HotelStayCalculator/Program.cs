using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStayCalculator
{
    internal class Program
    {
        static void Greetings()
        {
            Console.WriteLine("Hello and welcome");
            Console.WriteLine("Thank you for choosing us");
        }
        static void GetPersonalInfo(out string firstName, out string lastName, out int age)
        {
            Console.WriteLine("Please enter your personal information as asked below...");
            Console.WriteLine("First name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Age:");
            age = Convert.ToInt32(Console.ReadLine());
            while (age < 18)
            {
                Console.WriteLine("Please enter a valid number (must be atleast 18 years old):");
                age = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void DetailsOfStay(out int theAmountOfPeople, out int theAmountOfNights)
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

        static void Services(out bool foodService, out bool cleaningService, out string food, out string cleaning)
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
        static int TotalCost(int theAmountOfPeople, int theAmountOfNights, bool foodService, bool cleaningService)
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
        static void Main(string[] args)
        {
            Greetings();
            GetPersonalInfo(out string firstName, out string lastName, out int age);
            Console.WriteLine("Well done,now we need you to specify some details about your stay for us to calculate the cost of your stay...");
            DetailsOfStay(out int theAmountOfPeople, out int theAmountOfNights);
            Console.WriteLine("Almost there,now you can choose each one of our services that you like:");
            Services(out bool foodService, out bool cleaningService, out string food, out string cleaning);
            Console.WriteLine("Thank you for your time, now wait for us to calculate the total cost of your stay...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("The amount of people that will be stayin in your room (Including yourself):" + theAmountOfPeople);
            Console.WriteLine("The amount of nights you'll be staying with us: " + theAmountOfNights);
            Console.WriteLine("Is food service included with your room: " + food);
            Console.WriteLine("Is cleaning service included with your room: " + cleaning);
            Console.WriteLine("Press enter to confirm");
            Console.ReadLine();
            Console.WriteLine("Total cost adds up to: " + TotalCost(theAmountOfPeople, theAmountOfNights, foodService, cleaningService));
            Console.WriteLine("Press enter to finalize");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("....Thank you for choosing us and we hope you'll have a wonderfull stay....");
            Console.ReadKey();
        }
    }
}
