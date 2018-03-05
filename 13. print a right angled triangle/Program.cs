using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.print_a_right_angled_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int height;
            Console.WriteLine("Enter the required number:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the required height");
            height = Convert.ToInt32(Console.ReadLine());
            for(int i=height;i>0;i--)
            {
                for(int j=i;j>0;j--)
                {
                    Console.Write(number);
                }
                Console.Write("\n");
            }
        //    string a;
        //    a=Console.ReadLine();
        //    Console.WriteLine(a);
        }
    }
}
