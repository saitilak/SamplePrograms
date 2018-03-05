using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Program_to_check_if_a_triangle_can_be_formed
{
    class Program
    {
        static void Main(string[] args)
        {
            int angle1, angle2, angle3, totalAngle;
            Console.WriteLine("Enter values for three angles:");
            angle1 = Convert.ToInt32(Console.ReadLine());
            angle2= Convert.ToInt32(Console.ReadLine());
            angle3 = Convert.ToInt32(Console.ReadLine());
            totalAngle = angle1 + angle2 + angle3;

            if (totalAngle==180)
            {
                Console.WriteLine("Triangle can be formed");
            }
            else
            {
                Console.WriteLine("Triangle can't be formed");
            }
            Console.ReadLine();
        }
    }
}
