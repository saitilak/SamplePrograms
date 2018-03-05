using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.finding_odd_number_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 7, 8, 6 };
            int oddNum=0;
            for (int sze=0;sze<number.Length;sze++)
            {
                if ((number[sze] % 2) != 0)
                    oddNum++;
            }

            if (oddNum > 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}
