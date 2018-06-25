using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S
{
    class Program
    {
        static void Main(string[] args)
        {
          
            {
                Console.WriteLine("Choose between rock, paper or scissors...");
                string userChoice = Console.ReadLine();

                Random r = new Random();
                int computerChoise = r.Next(4);

                if (computerChoise == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Its a tie");
                    }

                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Its a tie");
                    }

                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Its a tie");
                    }

                    else Console.WriteLine("Yoy must choose between rock, paper or scissors...");

                }

                else if (computerChoise == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose,paper beat rock");

                    }

                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose,scissors beat paper");

                    }


                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose,rock beats scissors");

                    }

                    else Console.WriteLine("Yoy must choose between rock, paper or scissors...");

                }

                else if (computerChoise == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win,rock beats scissors");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win,paper beats rock");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win,scissors beat paper");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }

                Console.ReadLine();
            }
        }
    }
}
