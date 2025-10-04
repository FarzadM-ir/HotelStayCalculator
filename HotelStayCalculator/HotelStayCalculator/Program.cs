using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();
            greetings.Greet();
            GetPersonalInfo getPersonalInfo = new GetPersonalInfo();
            getPersonalInfo.PersonalInfo(out string firstName, out string lastName, out int age);
            Console.WriteLine("Well done,now we need you to specify some details about your stay for us to calculate the cost of your stay...");
            DetailsOfStay detailsOfStay = new DetailsOfStay();
            detailsOfStay.Details(out int theAmountOfPeople, out int theAmountOfNights);
            Console.WriteLine("Almost there,now you can choose each one of our services that you like:");
            Services services = new Services();
            services.Service(out bool foodService, out bool cleaningService, out string food, out string cleaning);
            Console.WriteLine("Thank you for your time, now wait for us to calculate the total cost of your stay...");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("The amount of people that will be stayin in your room (Including yourself):" + theAmountOfPeople);
            Console.WriteLine("The amount of nights you'll be staying with us: " + theAmountOfNights);
            Console.WriteLine("Is food service included with your room: " + food);
            Console.WriteLine("Is cleaning service included with your room: " + cleaning);
            Console.WriteLine("Press enter to confirm");
            Console.ReadLine();
            TotalCost totalCost = new TotalCost();
            Console.WriteLine("Total cost adds up to: " + totalCost.Cost(theAmountOfPeople, theAmountOfNights, foodService, cleaningService )+" USD");
            Console.WriteLine("Press enter to finalize");
            Console.ReadLine();
            Console.WriteLine(".");
            Console.WriteLine("....Thank you for choosing us and we hope you'll have a wonderfull stay....");
            Console.ReadKey();
        }
    }
}
