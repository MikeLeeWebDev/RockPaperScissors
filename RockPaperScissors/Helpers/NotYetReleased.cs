using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Helpers
{
    public class NotYetReleased
    {
        public static void NotYetReleasedPrompt()
        {
            Console.WriteLine("Coming soon... \n");
            Console.WriteLine("Press any key to go back to main menu");
            Variables.key = Console.ReadKey();
            Console.Clear();
            Menu.MainMenu();
        }
    }
}
