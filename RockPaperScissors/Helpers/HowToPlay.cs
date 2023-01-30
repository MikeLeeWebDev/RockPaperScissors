using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Helpers
{
    public class HowToPlay
    {
        public static void HowToPlayPrompt()
        {
            Console.WriteLine("How to play: \n");

            Console.WriteLine("Choose Play in the main menu to choose a game.\n");

            Console.WriteLine("Game 1: Rock Paper Scissors!\n");

            Console.WriteLine("-- Choose between Quick Rounds, First to Ten or Are You Lucky? --\n");

            Console.WriteLine("-- Quick Rounds: Ends after 1 round, choose play again to continue. Score is saved after each round... --");
            Console.WriteLine("-- First to Ten: Play until either you or computer get 10 points... --");
            Console.WriteLine("-- Are You Lucky?: Play until either you or computer get 10 points. Draw counts as -1 for you... --\n");

            Console.WriteLine("Press any key to return to main menu...");

            Variables.key = Console.ReadKey();
            Console.Clear();
            Menu.MainMenu();
        }
    }
}
