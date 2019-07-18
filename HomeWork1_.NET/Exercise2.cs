using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1_.NET
{
    class Exercise2
    {
        static char[] vowels = new char[6] { 'a', 'e', 'i', 'o', 'u', 'y' };
        static char[] digits = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void DetectString(String str) {
                      
                char sign = str[0];
                if (isContainsVowels(sign))
                {
                    Console.WriteLine("The string starts with vowel.");
                }
                else if (isContainsDigits(sign))
                {
                    Console.WriteLine("The string starts with digit.");
                }
                else
                {
                    Console.WriteLine("The string starts with consonant or another char.");
                }
                Console.ReadLine();
            }

            static bool isContainsVowels(char sign)
            {
                foreach (char c in vowels)
                    if (sign == c)
                    {
                        return true;
                    }
                return false;
            }

            static bool isContainsDigits(char sign)
            {
                foreach (char k in digits)
                    if (sign == k)
                    {
                        return true;
                    }
                return false;
            }
        }
    }

    

