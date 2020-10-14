using System;
using System.Security.Cryptography.X509Certificates;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*write a program in C# Sharp that converts 
             * fahrenheit into Celius and vice veras.
             * -the program enables the user to select
             * if the user wantsto convert into Celius
             * or into Farenheit.
             * -after the user has made their choice,
             * the  program asks for an input,
             * performs calculations and
             * displays the result - fahrenheit = (celsius * 9) / 5+ 32;
             * - celsius = (fahrebheit - 32) * 5 / 9;*/

            Console.WriteLine("enter C for Fahrenheit to Celsius or F for Celsius Fahrenheit");
            string UserInput = Console.ReadLine();
            if(UserInput == "C")
            {
                ToCelsius();
            } else
            {
                ToFahrenheit();
            }

        }
        public static void ToCelsius()
        {
            Console.WriteLine("enter the temperature in F: ");
            int tempF = Int32.Parse(Console.ReadLine());
            double result = (tempF - 32) * 5 / 9;
            Console.WriteLine($"result in Celsius: {result}");
        }
        public static void ToFahrenheit()
        {
            Console.WriteLine("enter the temperature in C: ");
            int tempC = Int32.Parse(Console.ReadLine());
            double result = (tempC * 9) / 5 + 32;
            Console.WriteLine($"result in Fahrenheit: {result}");
        }
    }
}
