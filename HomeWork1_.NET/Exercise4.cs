using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1_.NET
{
    class Exercise4
    {
        public static void GetCalc(string str)
        {
                  int result;

            
                if (str.Contains('-') || str.Contains('+'))
                {

                    for (int i = 1; i < str.Length; i++)
                    {
                        if (str[i] == '+' || str[i] == '-')
                        {
                            int position = i;
                            string num1 = str.Substring(0, position);
                            string num2 = str.Substring(position + 1);
                            switch (str[i])
                            {
                                case '+':
                                    {
                                        result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                                        Console.WriteLine(result.ToString());
                                        break;
                                    }

                                case '-':
                                    {
                                        result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
                                        Console.WriteLine(result.ToString());
                                        break;
                                    }

                            }

                        }
                    }

                }
                else { Console.WriteLine("You should use the character '+' or '-' for mathematical calculations."); }

            Console.ReadLine();
        }
       }
    }

     
