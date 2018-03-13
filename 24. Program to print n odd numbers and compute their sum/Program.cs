using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Program_to_print_n_odd_numbers_and_compute_their_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,sum=0;

            Console.WriteLine("Enter number of terms");
            number = Convert.ToInt32(Console.ReadLine());

            var number1 = new int[number];
            var count = 0;
            for (int i = 1; i > 0; i++)
            {
                if (count == number)
                {
                    break;
                }
                else if ((i % 2) != 0)
                {
                    number1[count] = i;
                    sum = sum + number1[count];
                    count++;
                }
               
            }
            Console.WriteLine(String.Format("Odd numbers array is: [ {0} ]", String.Join(",", number1)));
            Console.WriteLine("Sum of first " + number + " odd numbers is:" + sum);
            Console.ReadLine();
        }
    }
}
