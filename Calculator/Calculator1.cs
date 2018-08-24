using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class Calculator1:Calculator_operations
    {

        public int multiplication(int a, int b)
        {
            if ((a * b) < int.MaxValue && (a * b) > int.MinValue)
            {
                return (a * b);
            }
            else
            {
                Console.WriteLine("Multiplication of entered values is greater than allowed value for an integer");
                return (-1);
            }
        }
        public int division(int a, int b)
        {
            if (b != 0)
            {
                if ((a / b) < int.MaxValue && (a / b) > int.MinValue)
                {
                    return (a / b);
                }
                else
                {
                    return (-1);
                }

            }
            else
            {
                Console.WriteLine("Denominator cannot be zero");
                return (-2);
            }
        }
    }
}
