using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farenheit2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double inputFar; // declare vars one
            double makeCel; // declare var two

            Console.WriteLine("enter Farenheit: ");  //ask user to input
            inputFar = double.Parse(Console.ReadLine()); // assign input
            makeCel = ((inputFar - 32) / 9) * 5; // use input to make calculation

            Console.WriteLine("In Celcius this is " + makeCel); // write result
            Console.ReadKey(); // return result

        }
    }
}
