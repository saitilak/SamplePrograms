using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Print_equilateral_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height;
            int width=1;
            int number = 1;
            int spaceDecrement;
            
            Console.WriteLine("Enter the height:");
            Height = Convert.ToInt32(Console.ReadLine());
            spaceDecrement = Height;
            for (int i = 1; i <= Height; i++)
            {
                for(int space= spaceDecrement - 1;space>0;space--)
                {
                    Console.Write(" ");
                    
                }
                spaceDecrement--;

                for (int j= 1;j<= width;j++ )
                {
                    Console.Write(number);
                    Console.Write(" ");
                    number++;
                }
                width++;
                Console.WriteLine();

            }
            Console.ReadLine();
           

        }
    }
}
