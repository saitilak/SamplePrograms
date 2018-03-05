using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.print_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            for (number1 = 1; number1 < 100; number1++)
            {
                if (number1 == 1 || number1 % 2 != 0)
                    Console.WriteLine(number1);
            }
            Console.WriteLine("Enter option:");

            var a = Console.ReadLine();
        }
    }
}
