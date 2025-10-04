using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStayCalculator
{
    public class GetPersonalInfo
    {
        public void PersonalInfo(out string firstName, out string lastName, out int age)
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
    }
}
