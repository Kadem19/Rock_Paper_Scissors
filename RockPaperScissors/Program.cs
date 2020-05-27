using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper Scissors!");
            string playerChoice = "";
                Random r = new Random();
                int compChoice = r.Next(4);
                Console.WriteLine("\nSo which is it rock, paper, or scissors?");
                playerChoice = Console.ReadLine(); ;
                if (compChoice == 1)
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock and you chose rock!");
                        Console.WriteLine("Please try again!");
                    }

                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock and you chose paper!");
                        Console.WriteLine("Congratulations, you win!");
                        
                    }

                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock and you chose scissors.");
                        Console.WriteLine("Rock beats scissors Loser!! TRY AGAIN");
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }

                else if (compChoice == 2)
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper and you chose rock");
                        Console.WriteLine("Paper beats rock Loser!! TRY AGAIN");
                    }

                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper as well.");
                        Console.WriteLine("Hmm, it ends in a tie.  Try you luck again!");
                    }

                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Scissors easily cut through paper! CONGRATS YOU WIN!!");
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }

                else if (compChoice == 3)
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors!");
                        Console.WriteLine("Rock smashes scissors! Congrats you win!");
                    }

                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors!");
                        Console.WriteLine("scissors cuts through paper LOSER! TRY AGAIN");
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }
        }
    }
}
