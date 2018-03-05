using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.sum_of_digits_in_a_given_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 0;

            Console.WriteLine("Enter a number to get the sum of digits");
            number1 = Convert.ToInt32(Console.ReadLine());

            while (number1 > 10)
            {
                number2 = number2 + (number1 % 10);
                number1 = number1 / 10;

            }

            Console.WriteLine("sum of digits of a given number" + (number2 + number1));
            var a = Console.ReadLine();
        }
    }
}
