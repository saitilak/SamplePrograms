using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Calculator_operations
    {
        //int number = Math.Max(int);
        public int add(int a, int b)
        {
            if ((a + b) < int.MaxValue)
            {
                return (a + b);
            }
            else
            {
                Console.WriteLine("Sum of entered values is greater than allowed value for an integer");
                return (-1);
            }
        }
        public int difference(int a, int b)
        {
            if ((a - b) < int.MaxValue && (a-b) >int.MinValue )
            {
                return (a - b);
            }
            else
            {
                Console.WriteLine("Difference of entered values is greater than allowed value for an integer");
                return (-1);
            }
        }
       
    }
}
