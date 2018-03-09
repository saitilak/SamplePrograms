using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //program1
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Enter three numbers you want to multiply:");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("product of three given numbers is:", number1 * number2 * number3);


            var a = Console.ReadLine();
        }
    }
}
