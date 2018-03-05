using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Returning_boolean_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Enter value for number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for number2");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 % 2 == 0 && number2 % 2 == 0)
                Console.WriteLine("True");
            else if (number1 % 2 != 0 && number2 % 2 != 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}
