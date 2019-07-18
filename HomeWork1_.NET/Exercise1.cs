using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1_.NET
{
    class Exercise1
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.Write("FizzBuzz "); }
                else if (i % 3 == 0) { Console.Write("Fizz "); }
                else if (i % 5 == 0) { Console.Write("Buzz "); }
                else { Console.Write(i + " "); }
            }
            Console.ReadLine();
        }
    }
}
