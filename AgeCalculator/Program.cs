using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the age Calculator CLI App");
            Console.WriteLine("Type your birth year");
            int birthYear;
            int.TryParse(Console.ReadLine(), out birthYear);
            Console.WriteLine("Your Age is " + CalculteAge(birthYear));

            Console.ReadKey();
        }
        static int CalculteAge(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }
    }
}
