using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes
{
    public class Program
    {
        static void Main(string[] args)
        {
            double inputSeconds;
            

            Console.WriteLine("Input a numer of seconds:");
            inputSeconds = double.Parse(Console.ReadLine());
            TimeSpan time = TimeSpan.FromSeconds(inputSeconds);
            string result = time.ToString(@"hh\:mm\:ss");

            Console.WriteLine("This is the result" + result);
            Console.ReadKey();


        }
    }
}
