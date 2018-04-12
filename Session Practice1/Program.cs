using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            simpleCalculator a = new complexCalculator();
            int total=a.sum(4, 5);
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
