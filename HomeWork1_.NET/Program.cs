using System;
using System.Globalization;
using System.Threading;

namespace HomeWork1_.NET
{
    class Program
    {


        static void Main(string[] args)
        {
            Exercise1.FizzBuzz();
            
            Console.Write("\n" + "Enter a latin alphanumeric string : ");
            string str = Console.ReadLine();
            Exercise2.DetectString(str);

            try
            {
                Console.WriteLine("Enter a n-th Fibonacci number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Exercise3.FindFibonacciNumber(number);
            }
            catch (FormatException e)
            {
                Console.Write("Input string was not in a correct format! " + "\n");
            }
            try { 

            Console.Write("Enter an expression for calculation : ");
                string exp = Console.ReadLine();
                Exercise4.GetCalc(exp);
            }
            catch (FormatException e)
            {
                Console.Write("Input string was not in a correct format! " + "\n");
            }
            Console.ReadLine();
        }
    }
}





























