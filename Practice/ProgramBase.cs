using System;

namespace Practice
{
    internal class ProgramBase
    {
        public static void FizzBuzz()
        {
            //create list 1-100
            for (int i = 1; i < 100; i++)
            {
                bool Fizz = i % 3 == 0;
                bool Buzz = i % 5 == 0;

                if (Fizz && Buzz)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (Buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else if (Fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}