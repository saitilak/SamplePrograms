using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Program_to_find_if_a_number_is_perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int sum = 0;
            Console.WriteLine("Enter the number to verify if it is a Perfect Number");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Positive divisors are:");
            for (int i=1;i<inputNumber;i++)
            {
                if((inputNumber%i)==0)
                {
                    sum = sum + i;
                    
                    Console.Write(i);
                }
            }
            Console.WriteLine("Sum of divisors:" + sum);
            if(sum==inputNumber)
            {
                Console.WriteLine("Given number is a Perfect number");
            }
            else
            {
                Console.WriteLine("Given number is not a perfect number");
            }
            Console.ReadLine();
        }
    }
}
