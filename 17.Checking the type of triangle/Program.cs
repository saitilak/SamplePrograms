using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Checking_the_type_of_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1, side2, side3;

            Console.WriteLine("enter values for all the sides of a triangle");
            side1 = Convert.ToInt32(Console.ReadLine());
            side2 = Convert.ToInt32(Console.ReadLine());
            side3 = Convert.ToInt32(Console.ReadLine());

            if ((side1 == side2) && (side2 == side3))
                Console.WriteLine("Given dimensions are of a Equilateral triangle");
            else if (((side1 == side2) && (side2 != side3))
                )
                Console.WriteLine("Given dimensions are of a Isosceles triangle");
            else if((side1!=side2)&&(side2!=side3)&&(side1!=side3))
                Console.WriteLine("Given dimensions are of a scalene triangle");

            Console.ReadLine();
        }
    }
}
