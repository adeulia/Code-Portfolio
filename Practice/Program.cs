using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            Argentina();
            
            program p = new program;
            p.miyuki();
        }
        
        void Texas()
        {
            string input = "hello";
            foreach (var result in input)
            {
                Console.WriteLine(result);
            }
        }
        
        void Miyuki()
        {
            Console.WriteLine("Not a static class; have to instanitate the program to call this method.");
            
            var myList = new List<int>(){1,2,3,4,5}
            myList.Sort();
            int i = myList.BinarySearch(5);
            Console.WriteLine(i);
            
        }

        static void Argentina()
        {
            //aggreate function
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int result = numbers.Aggregate((a, b) => (a + b));
            // 1 + 2 = 3
            // 3 + 3 = 6
            // 6 + 4 = 10
            // 10 + 5 = 15
            // 15 + 6 = 21
            // 21 + 7 = 28

            //for loop function            
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                //sum = sum + numbers[i];
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(result);
        }
    }
}
