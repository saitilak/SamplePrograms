using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.sum_of_numbers_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int total = 0;

            for(int sze=0;sze<number.Length;sze++)
            {
                total = total + number[sze];
            }
            Console.WriteLine("sum of digits is:" + total);
            Console.ReadLine();
        }
    }
}
