using RockPaperScissors.Models;

namespace RockPaperScissors.Helpers
{
    public class Menu
    {
        public static void MainMenu()
        {
            while (Variables.mainMenuSelecting)
            {

                Console.Write("Use Arrow Keys to Choose\n");
                Console.WriteLine($"{(Variables.mainMenuOption == 1 ? Variables.colorGreen : "")} Play{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.mainMenuOption == 2 ? Variables.colorGreen : "")} How to Play{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.mainMenuOption == 3 ? Variables.colorGreen : "")} Exit{Variables.colorDefault}");

                Variables.key = Console.ReadKey();

                switch (Variables.key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Variables.mainMenuOption = (Variables.mainMenuOption == 3 ? 1 : Variables.mainMenuOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Variables.mainMenuOption = (Variables.mainMenuOption == 1 ? 3 : Variables.mainMenuOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (Variables.mainMenuOption == 1)
                        {
                            Variables.playAgain = true;
                            Variables.quickRounds = true;
                            ChooseGameMenu();
                        }
                        else if (Variables.mainMenuOption == 2)
                        {
                            HowToPlay.HowToPlayPrompt();
                        }
                        else
                        {
                            Variables.mainMenuSelecting = false;
                        }
                        Variables.mainMenuSelecting = false;
                        break;
                }
            }
        }

        public static void ChooseGameMenu()
        {
            while (Variables.gameMenuSelecting)
            {

                Console.Write("Use Arrow Keys to Choose\n");
                Console.WriteLine($"{(Variables.gameMenuOption == 1 ? Variables.colorGreen : "")} Rock Paper Scissors{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.gameMenuOption == 2 ? Variables.colorGreen : "")} Not Yet Released...{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.gameMenuOption == 3 ? Variables.colorGreen : "")} Main Menu{Variables.colorDefault}");

                Variables.key = Console.ReadKey();

                switch (Variables.key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Variables.gameMenuOption = (Variables.gameMenuOption == 3 ? 1 : Variables.gameMenuOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Variables.gameMenuOption = (Variables.gameMenuOption == 1 ? 3 : Variables.gameMenuOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (Variables.gameMenuOption == 1)
                        {
                            //Variables.gameMenuSelecting = false;
                            Console.Clear();
                            RockPaperScissorsModeMenu();
                        }
                        else if (Variables.gameMenuOption == 2)
                        {
                            NotYetReleased.NotYetReleasedPrompt();
                        }
                        else
                        {
                            //Variables.gameMenuSelecting = false;
                            Console.Clear();
                            MainMenu();

                        }
                        Variables.gameMenuSelecting = false;
                        break;
                }
            }
        }

        public static void RockPaperScissorsModeMenu()
        {
            while (Variables.rockPaperScissorsModeSelecting)
            {

                Console.Write("Use Arrow Keys to Choose\n");
                Console.WriteLine($"{(Variables.rockPaperScissorsModeOption == 1 ? Variables.colorGreen : "")} Quick Rounds{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.rockPaperScissorsModeOption == 2 ? Variables.colorGreen : "")} First to Ten{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.rockPaperScissorsModeOption == 3 ? Variables.colorGreen : "")} Are You Lucky?{Variables.colorDefault}");

                Variables.key = Console.ReadKey();

                switch (Variables.key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Variables.rockPaperScissorsModeOption = (Variables.rockPaperScissorsModeOption == 3 ? 1 : Variables.rockPaperScissorsModeOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Variables.rockPaperScissorsModeOption = (Variables.rockPaperScissorsModeOption == 1 ? 3 : Variables.rockPaperScissorsModeOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Games.RockPaperScissorsGame();
                        Variables.rockPaperScissorsModeSelecting = false;
                        break;
                }
            }
        }

        public static string RockPaperScissorsMenu()
        {
            while (true)
            {
                // Might not cursorPosition
                //Console.SetCursorPosition(left, top);

                Console.Write("Use Arrow Keys to Choose ROCK, PAPER, OR SCISSORS\n");
                Console.WriteLine($"{(Variables.rockPaperScissorsOption == 1 ? Variables.colorGreen : "")} ROCK{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.rockPaperScissorsOption == 2 ? Variables.colorGreen : "")} PAPER{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.rockPaperScissorsOption == 3 ? Variables.colorGreen : "")} SCISSORS{Variables.colorDefault}");

                Variables.key = Console.ReadKey();
                Console.Clear();

                switch (Variables.key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Variables.rockPaperScissorsOption = (Variables.rockPaperScissorsOption == 3 ? 1 : Variables.rockPaperScissorsOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        Variables.rockPaperScissorsOption = (Variables.rockPaperScissorsOption == 1 ? 3 : Variables.rockPaperScissorsOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        //switch expressions
                        return Functions.GetMoveFromNumber(Variables.rockPaperScissorsOption);
                }
            }
        }

        public static void GameOverMenu()
        {
            Variables.gameOverSelecting = true;

            while (Variables.gameOverSelecting)
            {
                //Console.SetCursorPosition(left, top);
                Console.WriteLine("Would you like to play again? (Y/N)");
                Console.WriteLine($"{(Variables.gameOverOption == 1 ? Variables.colorGreen : "")} YES{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.gameOverOption == 2 ? Variables.colorRed : "")} NO{Variables.colorDefault}");
                Console.WriteLine($"{(Variables.gameOverOption == 3 ? Variables.colorGreen : "")} Main Menu{Variables.colorDefault}");

                Variables.key = Console.ReadKey();

                switch (Variables.key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Variables.gameOverOption = (Variables.gameOverOption == 3 ? 1 : Variables.gameOverOption + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Variables.gameOverOption = (Variables.gameOverOption == 1 ? 3 : Variables.gameOverOption - 1);
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (Variables.gameOverOption == 1)
                        {
                            Variables.playAgain = true;
                            Variables.rockPaperScissorsSelecting = true;
                            if (Variables.rockPaperScissorsModeOption != 1)
                            {
                                Variables.playerScore = 0;
                                Variables.computerScore = 0;
                            }
                            Variables.quickRounds = true;
                            Console.Clear();
                        }
                        else if (Variables.gameOverOption == 2)
                        {
                            Variables.playAgain = false;
                            //END SCORE
                            Console.WriteLine($"GAME OVER!\n{Variables.yourName} score: {Variables.playerScore}\ncomputer score: {Variables.computerScore}");
                            Variables.playerScore = 0;
                            Variables.computerScore = 0;
                        }
                        else
                        {
                            Variables.playAgain = false;
                            Variables.playerScore = 0;
                            Variables.computerScore = 0;
                            Console.Clear();
                            MainMenu();

                        }
                        Variables.gameOverSelecting = false;

                        break;
                }
            }
        }



    }
}
