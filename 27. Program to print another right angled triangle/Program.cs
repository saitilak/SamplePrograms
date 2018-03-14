using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Program_to_print_another_right_angled_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width=1;
            int number = 1;
            Console.WriteLine("Enter the required height:");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write(number);
                    number++;
                }
                width++;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
