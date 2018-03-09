using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Program_to_compute_sum_and_avg_of_given_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number;
            int size, sum = 0;
            double average=0.000;
            Console.WriteLine("Enter count of numbers you want to get sum and avg:");
            size = Convert.ToInt32(Console.ReadLine());
            number = new int[size];

            for(int i=0;i< size;i++)
            {
                Console.WriteLine("Enter " + i + "number:");
                number[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + number[i];
             
            }
            average = Convert.ToDouble(sum / size);

            Console.WriteLine("Total sum of entered numbers is : " + sum);
            Console.WriteLine("Average of given numbers is : " + average);

            Console.ReadLine();
           
        }
    }
}
