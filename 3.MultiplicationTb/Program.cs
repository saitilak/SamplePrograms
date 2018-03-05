using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MultiplicationTb
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 1;

            number1 = Convert.ToInt32(Console.ReadLine());

            for (; number2 <= 10; number2++)
            {
                Console.WriteLine("multiplication" + number1 + 'x' + number2 + '=' + number1 * number2);

                Console.WriteLine("multiplication {0} * {1} = {2}", number1, number2, number1 * number2);
            }
        }
    }
}
