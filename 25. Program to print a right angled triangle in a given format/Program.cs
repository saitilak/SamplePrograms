using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Program_to_print_a_right_angled_triangle_in_a_given_format
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,height;
            var strConcat="1";
            Console.WriteLine("Enter value for height:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strConcat);
            for (number=2;number<=height;number++)
            {
                strConcat = string.Format("{0}{1}",strConcat,number);
                Console.WriteLine(strConcat);
                  
            }
            Console.Read();

            
        }
    }
}
