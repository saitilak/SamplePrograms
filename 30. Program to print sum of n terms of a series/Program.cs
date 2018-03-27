using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Program_to_print_sum_of_n_terms_of_a_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTerms;
            double sum = 0.000;
            Console.WriteLine("Enter number of terms:");
            numberOfTerms = Convert.ToInt32(Console.ReadLine());
            if(numberOfTerms>0)
            { 
            for (int i=1;i<=numberOfTerms;i++)
                {
                    double temporary = Convert.ToDouble(1 / i);
                    sum = sum + temporary;
                    Console.WriteLine(i);
                    Console.WriteLine("Sum of entered terms is: " + sum);
                }
                //Console.WriteLine("Sum onf entered terms is: " + sum);
            }
            else
            {
                Console.WriteLine("Enter a positive integer greater than 0");
            }
            Console.ReadLine();
        }
    }
}
