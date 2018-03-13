using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Program_to_print_a_different_right_angle_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;

            Console.WriteLine("Enter the required height:");
            height = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<= height;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
