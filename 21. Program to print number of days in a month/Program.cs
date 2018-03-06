using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Program_to_print_number_of_days_in_a_month
{
    class Program
    {
        static void Main(string[] args)
        {
            int calendarMonth;
            Console.WriteLine("Enter the month to get the number of days:");
            calendarMonth=Convert.ToInt32(Console.ReadLine());
            switch (calendarMonth)
            {
                case 1:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                case 2:
                    Console.WriteLine("No.of days in given month is 28");
                    break;
                case 3:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                case 4:
                    Console.WriteLine("No.of days in given month is 30");
                    break;
                case 5:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                case 6:
                    Console.WriteLine("No.of days in given month is 30");
                    break;
                case 7:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                case 8:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                case 9:
                    Console.WriteLine("No.of days in given month is 30");
                    break;
                case 10:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                case 11:
                    Console.WriteLine("No.of days in given month is 30");
                    break;
                case 12:
                    Console.WriteLine("No.of days in given month is 31");
                    break;
                default:
                    Console.WriteLine("supplied integer doesn't represent a valid month");
                    break;
            }
            Console.ReadLine();

        }
    }
}
