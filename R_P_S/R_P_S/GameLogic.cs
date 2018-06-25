using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S
{
   public class GameLogic
    {
        
        public void Game(string userChoise)
        {
            Random r = new Random();
            int computerChoise = r.Next(4);

            if (computerChoise == 1)
            {
                if (userChoise == Options.paper.ToString())
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Its a tie");
                }

                else if (userChoise == Options.rock.ToString())
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Its a tie");
                }

                else if (userChoise == Options.scissors.ToString())
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Its a tie");
                }

                else Console.WriteLine("Yoy must choose between rock, paper or scissors...");
            }
            else if (computerChoise == 2)
            {
                if (userChoise == Options.rock.ToString())
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose,paper beat rock");

                }

                else if (userChoise == Options.paper.ToString())
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,scissors beat paper");

                }

                else if (userChoise == Options.scissors.ToString())
                {

                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose,rock beats scissors");

                }

                else Console.WriteLine("Yoy must choose between rock, paper or scissors...");
            }

            else if (computerChoise == 3)
            {
                if (userChoise == Options.rock.ToString())
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,rock beats scissors");
                }

                else if (userChoise == Options.paper.ToString())
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,paper beats rock");
                }

                else if (userChoise == Options.scissors.ToString())
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors beat paper");
                }

                else Console.WriteLine("Yoy must choose between rock, paper or scissors...");
            }

            Console.ReadLine();
            Console.WriteLine("Do you want to continue playing? y for Yes, n for No");
        }

    }
}
