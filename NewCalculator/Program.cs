using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace NewCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator1 calc = new Calculator1();
            calc.add(20, 30);
            calc.difference(30, 20);
            calc.division(15, 3);
            calc.multiplication(2, 2);
        }
    }
}
