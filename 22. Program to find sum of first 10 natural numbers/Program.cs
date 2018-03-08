using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Program_to_find_sum_of_first_10_natural_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum=0;

            Console.Write("The first 10 natural numbers are:");

            for(int i=0;i<number1.Length;i++)
            {
                Console.Write(number1[i]);
                sum = sum + number1[i];

            }
            Console.WriteLine('\n');
            Console.WriteLine("Sum of first ten natural numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
