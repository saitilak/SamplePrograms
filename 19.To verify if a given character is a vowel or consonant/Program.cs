using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.To_verify_if_a_given_character_is_a_vowel_or_consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1;
            Boolean identified=false;
            char[] vowels1 = {'a','e','i','o','u','A','E','O','U','I' };
            char[] consonant1 = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm','n','p','q','r','s','t','v','w','x','y','z','B','C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Enter the character that you want to verify:");
            character1 = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < vowels1.Length; i++)
            {
                if (character1 == vowels1[i])
                {
                    Console.WriteLine("Enter character is a vowel");
                    identified = true;
                    break;
                }
                
            }

            if(identified==false)
            {
                for (int j = 0; j < consonant1.Length; j++)
                {

                    if (character1 == consonant1[j])
                    {
                        Console.WriteLine("Enter character is a consonant");
                        identified = true;
                        break;
                    }
                   
                }
            }
            if (identified == false)
            {
                Console.WriteLine("Entered value is not an alphabet");
            }

                Console.ReadLine();

        }
    }
}
