using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Program_to_print_factorial_of_a_given_number
{
    class numberFactorial
    {

        public int numberFactorialFunction(int number)
        {
            int total = 1;
            for (int i = 1; i <= number; i++)
            {
                total = total * i;
            }
            return total;
        }
    }
}