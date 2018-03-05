using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.To_calculate_and_print_electricity_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerId, unitsConsumed;
            double surcharge=0.00,totalBill, powerUsageCost;
            string customerName;
            Console.WriteLine("Enter the customerId");
            customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer name");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter the units consumed");
            unitsConsumed = Convert.ToInt32(Console.ReadLine());

            if(unitsConsumed>0 && unitsConsumed<199)
            {
                powerUsageCost = unitsConsumed * 1.20;
                if (powerUsageCost > 400)
                {
                    surcharge = (powerUsageCost*15)/100;
                }
                
                totalBill = powerUsageCost + surcharge;
                Console.WriteLine("Mr." + customerName);
                Console.WriteLine("You have consumed " + unitsConsumed + " units for this month");
                Console.WriteLine("Your usage cost is: " + powerUsageCost);
                Console.WriteLine("Your surcharge is:" + surcharge);
                if (totalBill < 100)
                {
                    Console.WriteLine("Your total bill is Rs.100");
                }
                else
                {
                    Console.WriteLine("Your total bill is : Rs." + totalBill);
                }
            
            }
            else if (unitsConsumed > 199 && unitsConsumed < 400)
            {
                powerUsageCost = unitsConsumed * 1.50;
                if (powerUsageCost > 400)
                {
                    surcharge = (powerUsageCost * 15) / 100;
                }
                totalBill = powerUsageCost + surcharge;
                Console.WriteLine("Mr." + customerName);
                Console.WriteLine("You have consumed " + unitsConsumed + "for this month");
                Console.WriteLine("Your usage cost is: " + powerUsageCost);
                Console.WriteLine("Your surcharge is:" + surcharge);
                Console.WriteLine("Your total bill is : " + totalBill);

            }
            else if (unitsConsumed > 399 && unitsConsumed < 600)
            {
                powerUsageCost = unitsConsumed * 1.80;
                if (powerUsageCost > 400)
                {
                    surcharge = (powerUsageCost * 15) / 100;
                }
                totalBill = powerUsageCost + surcharge;
                Console.WriteLine("Mr." + customerName);
                Console.WriteLine("You have consumed " + unitsConsumed + "for this month");
                Console.WriteLine("Your usage cost is: " + powerUsageCost);
                Console.WriteLine("Your surcharge is:" + surcharge);
                Console.WriteLine("Your total bill is : " + totalBill);

            }
            else if (unitsConsumed > 599)
            {
                powerUsageCost = unitsConsumed * 2;
                if (powerUsageCost > 400)
                {
                    surcharge = (powerUsageCost * 15) / 100;
                }
                totalBill = powerUsageCost + surcharge;
                Console.WriteLine("Mr." + customerName);
                Console.WriteLine("You have consumed " + unitsConsumed + "for this month");
                Console.WriteLine("Your usage cost is: " + powerUsageCost);
                Console.WriteLine("Your surcharge is:" + surcharge);
                Console.WriteLine("Your total bill is : " + totalBill);

            }

            Console.ReadLine();
        }
    }
}
