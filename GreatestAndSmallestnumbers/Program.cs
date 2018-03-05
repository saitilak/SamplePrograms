using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestAndSmallestnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            int greatest=0, smallest=0;
            for (int arraylength = 0; arraylength < 3; arraylength++)
            {
                Console.WriteLine("Enter value for number[" + arraylength + "]");
                number[arraylength] = Convert.ToInt32(Console.ReadLine());
            }
            if (number[1] > number[0])
            {
                if (number[1] > number[2])
                {
                    greatest = Convert.ToInt32(number[1]);
                    if (number[0] > number[2])
                        smallest = Convert.ToInt32(number[2]);
                    else
                        smallest = Convert.ToInt32(number[0]);
                }
                else
                    greatest = Convert.ToInt32(number[2]);
                smallest = Convert.ToInt32(number[0]);
            }
            else if (number[0] > number[2])
            {
                greatest = Convert.ToInt32(number[0]);
                if (number[1] > number[2])
                    smallest = Convert.ToInt32(number[2]);
                else
                    smallest = Convert.ToInt32(number[1]);
            }
            else
                greatest = Convert.ToInt32(number[2]);
            if (number[1] > number[2])
                smallest = Convert.ToInt32(number[2]);
            else
                smallest = Convert.ToInt32(number[1]);

            Console.WriteLine("Greatest of all the three numbers:"+greatest);
            Console.WriteLine("Smallest of all the three numbers:"+smallest);
            var a= Console.ReadLine();
        }
    }
}
