using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MultiplytwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[4];
            int[] secondArray = new int[4];
            int[] multArray = new int[4];

            for (int arraylength = 0; arraylength < 4; arraylength++)
            {
                Console.WriteLine("Enter element" + arraylength + "for first array");
                firstArray[arraylength] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter element" + arraylength + "for second array");
                secondArray[arraylength] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine(String.Format("first array is: [ {0} ]", String.Join(",",firstArray)));
            Console.WriteLine(String.Format("second array is: [ {0} ]", String.Join(",", secondArray)));
            for (int arraylength = 0; arraylength < 4; arraylength++)
            {
                multArray[arraylength] = firstArray[arraylength] * secondArray[arraylength];
            }

            Console.WriteLine(String.Format("After multiplication is: [ {0} ]", String.Join(",", multArray)));
            Console.ReadKey();
        }
    }
}
