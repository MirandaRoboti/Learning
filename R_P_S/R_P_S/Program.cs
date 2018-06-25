using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S
{
    class Program
    {
       public static void Main(string[] args)
        {
            bool shouldContinue = false;

            do
            {
                Console.WriteLine("Do you choose rock,paper or scissors");
                GameLogic gameLogic = new GameLogic();
                string userChoise = Console.ReadLine();
                gameLogic.Game(userChoise);

                if (Console.ReadLine() == "y")
                {
                    shouldContinue = true;
                }
            }
            while (shouldContinue);

        }
    }
}
