using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Program_to_print_floyd_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width = 1;
            int number = 1;
            int reminder;
            Console.WriteLine("Enter the required height:");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    reminder = number % 2;
                    Console.Write(reminder);
                    number++;
                }
                width++;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
