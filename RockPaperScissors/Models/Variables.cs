using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class Variables
    {
        // Colors
        public static string colorGreen = "\u001b[32m";
        public static string colorRed = "\u001b[31m";
        public static string colorDefault = "\u001b[0m";

        // RockPaperScissor Game
        public static string yourName = default!;
        public static string player = default!;
        public static string computer = default!;
        public static int playerScore = 0;
        public static int computerScore = 0;
        public static bool playAgain = true;

        // -- RockPaperScissor Game Mode
        public static bool firstToTen = playerScore < 10 && computerScore < 10;
        public static bool quickRounds = true;

        // Menu Variables
        public static int rockPaperScissorsOption = 1;
        public static int gameOverOption = 1;
        public static int mainMenuOption = 1;
        public static int gameMenuOption = 1;
        public static int rockPaperScissorsModeOption = 1;
        public static bool rockPaperScissorsSelecting = true;
        public static bool mainMenuSelecting = true;
        public static bool gameMenuSelecting = true;
        public static bool rockPaperScissorsModeSelecting = true;
        public static bool gameOverSelecting = true;
        public static ConsoleKeyInfo key;


        public static Random random = new Random();
    }
}
