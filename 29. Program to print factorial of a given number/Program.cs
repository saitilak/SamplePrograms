using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Program_to_print_factorial_of_a_given_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int Factorial;
            Console.WriteLine("Enter the number for which factorial is required:");
            number1 = Convert.ToInt32(Console.ReadLine());
            numberFactorial numberFactorial1 = new numberFactorial();
            Factorial=numberFactorial1.numberFactorialFunction(number1);
            Console.WriteLine("Factorial of the number is " + Factorial);
            Console.ReadLine();
        }
    }
}
