using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors_KatelynNicholson
{
    internal class Program
    {
        // Rock = 0, Paper = 1, Scissors =2
        static string[] optionNames = { "Rock ", "Paper", "Scissors" };

        static void Main()
        {
            //make text green
            Console.WriteLine("Hit Enter to Play");
            Console.ReadKey();
            Console.Clear();

            computerGen();
            Console.ReadKey();
            playerInput();


        }

        static void computerGen()
        {
            Random rnd = new Random();
            int computerChoice = rnd.Next(0, optionNames.Length);

            Console.WriteLine("Computer is picking...");
            Console.ReadKey();
            Console.WriteLine("Thinking...");
            Console.ReadKey();
            Console.WriteLine("....");
            Console.ReadKey();

            string option = optionNames[computerChoice];
            Console.WriteLine("Computer Chose");

        }

        static void playerInput()
        {
            Console.WriteLine("Choose your option:");
            Console.WriteLine("1 = Rock, 2 = Paper, 3 = Scissors");

            int choice = Convert.ToInt32(Console.ReadLine());
            int playerChoice = choice - 1;

            string option = optionNames[playerChoice];
            Console.WriteLine("You Chose: " + option);

        }

        static void compareAnswers(int playerChoice, int computerChoice)
        {
            int attempts = 0;
             while(attempts < 3)
            {
                playerChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Player chose: " + optionNames[playerChoice]);
                Console.WriteLine("Computer chose: " + optionNames[computerChoice]);

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == 0 && computerChoice == 2) ||
                 (playerChoice == 1 && computerChoice == 0) ||
                 (playerChoice == 2 && computerChoice == 1))
                {
                    Console.WriteLine("Player Wins!");
                    break;
                }
            }
        }
    }
}
