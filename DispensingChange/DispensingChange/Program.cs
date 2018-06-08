using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensingChange
{
    public class Program
    {
        static void Main(string[] args)
        {           
           
            int inputAmount;
            int costOfItem;
            int changeBack;
            double maximumAmount = 100;
            List<int> coins = new List<int>();
            List<int> amounts = new List<int>(){50,20,10,5,2,1};



            Console.WriteLine("Please insert amount:");
            inputAmount = int.Parse(Console.ReadLine());

            if (inputAmount > maximumAmount)
            {
                Console.WriteLine(value: "This amount is too big. Max allowed is 100 cent");
                Console.ReadKey();
            }
            else
            {

                Console.WriteLine("Enter item cost:");
                costOfItem = int.Parse(Console.ReadLine());
                changeBack = inputAmount - costOfItem;
                Change(coins, amounts, changeBack);

            }

        }
        static void Change(List<int> coins, List<int> amounts, int goal)
        {

            if (goal == 0)
            {
                Display(coins, amounts);
                return;
            }

            if (goal < 0)
            {
                return;
            }
            foreach (int value in amounts)
            {
                
                if (value <= goal)
                {
                    List<int> copy = new List<int>(coins);
                    copy.Add(value);
                    Change(copy, amounts, goal - value);
                }
            }
        }

        private static void Display(List<int> coins, List<int> amounts)
        {
            foreach (int coin in coins)
            {
              
                Console.WriteLine(coin);
            }
            Console.ReadKey();
        }

    }
}
