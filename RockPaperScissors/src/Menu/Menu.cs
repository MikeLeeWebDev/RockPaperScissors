using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.src.Menu
{
    public class Menu
    {
        int option = 1;
        bool isSelected = false;
        string colorGreen = "\u001b[32m";
        string colorRed = "\u001b[31m";
        int gameOverOption = 1;
        bool gameOverSelected = false;
        ConsoleKeyInfo key;
        ConsoleKeyInfo modeKey;
        ConsoleKeyInfo endScoreKey;

        public void MainMenu()
        {

            while (!isSelected)
            {
                //Console.SetCursorPosition(left, top);
                Console.Write("Welcome to The Game\n");
                Console.WriteLine($"{(option == 1 ? colorGreen : "")} ROCK/PAPER/SCISSORS-GAME\u001b[0m");
                Console.WriteLine($"{(option == 2 ? colorGreen : "")} GAME\u001b[0m");
                Console.WriteLine($"{(option == 3 ? colorGreen : "")} HOW TO PLAY\u001b[0m");
                Console.WriteLine($"{(option == 4 ? colorGreen : "")} EXIT\u001b[0m");

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        option = option == 4 ? 1 : option + 1;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        option = option == 1 ? 4 : option - 1;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();

                        isSelected = true;
                        break;
                }
            }


        }
        public void RockPaperScissorsMenu()
        {

            while (!isSelected)
            {
                //Console.SetCursorPosition(left, top);
                Console.Write("Choose Game Mode\n");
                Console.WriteLine($"{(option == 1 ? colorGreen : "")} Base Game\u001b[0m");
                Console.WriteLine($"{(option == 2 ? colorGreen : "")} Hard Mode\u001b[0m");
                Console.WriteLine($"{(option == 3 ? colorGreen : "")} Ten Times\u001b[0m");
                Console.WriteLine($"{(option == 4 ? colorGreen : "")} Back To Main Menu\u001b[0m");

                key = Console.ReadKey();

                switch (modeKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        option = option == 4 ? 1 : option + 1;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        option = option == 1 ? 4 : option - 1;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();

                        isSelected = true;
                        break;

                }
            }
        }
    
        public void EndScoreMenu()
        {

            while (!gameOverSelected)
            {
                //Console.SetCursorPosition(left, top);
                // >>>> MOVE TO OTHER SPACE <<<<
                Console.WriteLine("Would you like to play again? (Y/N)");
                Console.WriteLine($"{(gameOverOption == 1 ? colorGreen : "")} YES\u001b[0m");
                Console.WriteLine($"{(gameOverOption == 2 ? colorRed : "")} NO\u001b[0m");



                endScoreKey = Console.ReadKey();

                switch (endScoreKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        gameOverOption = (gameOverOption == 2 ? 1 : gameOverOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        gameOverOption = (gameOverOption == 1 ? 2 : gameOverOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (gameOverOption == 1)
                        {
                            // Where to playAgain
                            playAgain = true;
                            isSelected = false;
                        }
                        else
                        {
                            playAgain = false;
                        }
                        gameOverSelected = true;

                        break;
                }

                //END SCORE move to Players!
                Console.WriteLine($"GAME OVER!\n{yourName} score: {playerScore}\ncomputer score: {computerScore}");

            }

        }
    
    }
}
