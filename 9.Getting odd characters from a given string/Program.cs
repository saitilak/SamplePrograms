using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Getting_odd_characters_from_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleText;
            Console.WriteLine("enter a sample string:");
            sampleText = Console.ReadLine();
            var fp = "";
            Console.WriteLine(sampleText);
           // Console.ReadLine();
            for(int i=0;i< sampleText.Length; i++)
            {
                if((i+1)%2 == 1)
                {
                    fp = fp + sampleText[i];
                }
            }
            Console.WriteLine(fp);
            Console.ReadLine();
        }
    }
}
