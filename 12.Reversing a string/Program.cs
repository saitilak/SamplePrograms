using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Reversing_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter"+ i +"character");
                inputString[i] = Console.ReadLine();
            }
            for(int i=2;i>=0;i--)
            {
                Console.Write(inputString[i]);
            }
            Console.ReadLine();
        }
    }
}
