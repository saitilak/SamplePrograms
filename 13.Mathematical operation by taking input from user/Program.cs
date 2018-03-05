using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Mathematical_operation_by_taking_input_from_user
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, finalOutput=0;
            char operator1;
            Console.WriteLine("Enter the number1 on which you want to perform operation:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2 on which you want to perform operation:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator that you want to perform:");
            operator1 = Convert.ToChar(Console.ReadLine());
           
            switch (operator1)
            {
                case '+':
                    finalOutput = number1 + number2;
                    Console.WriteLine("Sum of two given numbers is: " + finalOutput);
                    break;
                case '-':
                    finalOutput = number1 - number2;
                    Console.WriteLine("difference of two given numbers is: " + finalOutput);
                    break;
                case '*':
                    finalOutput = number1 * number2;
                    Console.WriteLine("Product of two given numbers is: " + finalOutput);
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Zero cannot be used as denominator");
                    }
                    else
                    {
                        finalOutput = number1 / number2;
                        Console.WriteLine("Quotient of two given numbers is: " + finalOutput);
                    }
                    break;
                default:
                    Console.WriteLine("Given input is not valid");
                    break;

                    }
            Console.ReadLine();
        }
    }
}
