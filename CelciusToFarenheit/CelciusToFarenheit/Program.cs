using System;

namespace CelciusToFarenheit
{
    public class Program
    {
        static void Main(string[] args)

        {
            float inputFarenheit;
            float makeCelcius;

            Console.WriteLine("Enter a Fahrenheit temperature:  ");
            inputFarenheit = float.Parse(Console.ReadLine());
            makeCelcius = ((inputFarenheit - 32) / 9) * 5;

            Console.WriteLine("Celcius= :" + makeCelcius);

        }
    }
}
