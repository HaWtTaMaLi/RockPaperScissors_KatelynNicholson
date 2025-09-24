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
        static int[] attempts = new int [3];

        static void Main()
        {
            //make text green
            Console.WriteLine("Hit Enter to Play");
            Console.ReadKey();
            Console.Clear();

            computerGen();

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
            Console.WriteLine("Computer Chose: " + option);

        }


        static void isHigher()
        {
           
        }

        static void isLower()
        {
            // is rock lower then paper?
        }
    }
}
