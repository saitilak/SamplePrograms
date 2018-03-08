using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] number1= { 37, 75, 51, 65, 99, 80 };
            int pass=0, fail=0;
            //Console.WriteLine("Enter a number");
            //number1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number1.Length; i++)
            {
                //if ((number1[i] > 1) && (number1[i] <= 100))
                //{
                if (number1[i] >= 35)
                {
                    //if (number1[i] >= 60)
                    //{
                    //    Console.WriteLine("You have passed subject" + i + " with first class.");
                    //}
                    //else if (number1[i] >= 50 && number1[i] < 60)
                    //{
                    //    Console.WriteLine("You have passed subject" + i + " with second class.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("You have passed subject" + i + " with third class.");
                    //}
                    pass++;

                }
                else
                {
                    fail++;
                    break;
                }

            }
            if(fail>0)
            {
                Console.WriteLine("Better Luck Next Time");
            }
            else
            {
                Console.WriteLine("You have successfully cleared all subjects");
            }
              
                        Console.ReadLine();
        }
    }
}
