using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.sumofintegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)

                Console.WriteLine(3 * (number1 + number2));
            else
                Console.WriteLine(number1 + number2);
        }
    }
}
