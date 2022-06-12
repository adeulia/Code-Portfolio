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
            WeatherUtilites.Report("Houston", 37, 15);

            FizzBuzz();

        }

        void Argentina()
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
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(result);
        }
    }

    class Pointer
    {
        public struct Point
        {
            public int Z;
            public int X;
            public int Y;

            public override string ToString()
            {
                return $"({X},{Y},{Z})";
            }
        }
    }
    
    public class WeatherUtilites
    {
        static float FahrenheitToCelsius(float tempFahrenheit)
        {
            float tempCelsius = tempFahrenheit - 32 / 1.8f;
            return tempCelsius;
        }

        static float CelsiusToFahrenheit(float tempCelsius)
        {
            float tempFahrenheit = tempCelsius * 1.8f + 32;
            return tempFahrenheit;
        }

        static float ComfortIndex(float tempFahrenheit, float humidityPercent)
        {
            float comfortIndex = (tempFahrenheit + humidityPercent) / 4;
            return comfortIndex;
        }

        public static void Report(string location, float tempCelsius, float humidity)
        {
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(CelsiusToFahrenheit(tempCelsius), humidity));
            Console.ReadLine();
        }
    }
}
