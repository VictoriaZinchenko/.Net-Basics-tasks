using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1_.NET
{
    class Exercise3
    {
        public static void FindFibonacciNumber(int number)
        {


            if (number > 48)
            {
                Console.WriteLine("Sorry, the program can only count up to 48 members of the Fibonacci series.");

            }

            else if((number >= ' ' && number <= '/') || (number >= ':' && number <= '`')) {
                Console.WriteLine("Sorry");
            }

            else if (number < 1)
            {
                Console.WriteLine("The Fibonacci series does not have such an element.");
            }

            else
            {
                int firstNumber = 1;
                int secondNumber = 1;
                int sum = 0;

                int count = 2;
                while (count <= number)
                {
                    sum = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = sum;
                    count++;
                }
                Console.WriteLine("The member of the Fibonacci series : " + firstNumber);
            }
            Console.ReadLine();
        }
    }
}
