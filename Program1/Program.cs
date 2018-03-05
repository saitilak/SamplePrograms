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
            //Program1
            //int number1;
            //int number2;
            //int number3;
            //number1 = Convert.ToInt32(Console.ReadLine());
            //number2 = Convert.ToInt32(Console.ReadLine());
            //number3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Product of three given numbers is:", number1 * number2 * number3);

            //Program2

            //int firstNumber;
            //int secondNumber;
            //int intermediate;

            //firstNumber = Convert.ToInt32(Console.ReadLine());
            //secondNumber = Convert.ToInt32(Console.ReadLine());
            //intermediate = secondNumber;
            //secondNumber = firstNumber;
            //firstNumber = intermediate;

            //Console.WriteLine("After swapping first number is", firstNumber);
            //Console.WriteLine("After swapping second number is", secondNumber);

            //Program3

            //int number1;
            //int number2 = 1;

            //number1 = Convert.ToInt32(Console.ReadLine());

            //for (;number2<=10;number2++)
            //{
            //    Console.WriteLine("Multiplacation" + number1 + 'X'+ number2 +'='+ number1 * number2);

            //    Console.WriteLine("Multiplacation {0} * {1} = {2}", number1, number2 , number1 * number2);
            //}


            //Program4

            //int number1;
            //int number2;

            //number1 = Convert.ToInt32(Console.ReadLine());
            //number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1 == number2)

            //    Console.WriteLine(3 * (number1 + number2));
            //else
            //    Console.WriteLine(number1 + number2);

            ////Program5

            //int number1;

            //for (number1 = 1; number1 < 100; number1++)
            //{
            //    if (number1==1||number1 % 2 != 0)
            //        Console.WriteLine(number1);
            //}
            //Console.WriteLine("Enter option:");

            //var a = Console.ReadLine();

            // Program6
            /*
            int number1;
            int number2 = 0;

            Console.WriteLine("Enter a number to get the sum of digits");
            number1 = Convert.ToInt32(Console.ReadLine());

            while(number1>10)
            {
                number2 = number2 + number1 % 10;
                number1 = number1 / 10;
                
            }

            Console.WriteLine("sum of digits of a given number" + (number2+number1));
            var a = Console.ReadLine();
        }
    }
}
