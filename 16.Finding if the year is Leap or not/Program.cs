using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Finding_if_the_year_is_Leap_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            Console.WriteLine("Enter the year to verify");
            number1 = Convert.ToInt32(Console.ReadLine());

            if(number1%4==0)
            {
                if ((number1 % 100 == 0) && (number1 % 400 == 0))
                    Console.WriteLine("Supplied year is a leap year");
                else
                    Console.WriteLine("Supplied year is not a leap year");
            }
            else
                Console.WriteLine("Supplied year is not a leap year");

            Console.ReadLine();
        }
    }
}
