using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Helpers
{
    public class Games
    {
        public static void RockPaperScissorsGame()
        {
            while (Variables.playAgain)
            {
                while (Variables.rockPaperScissorsModeOption == 1 ? Variables.quickRounds : Variables.playerScore < 3 && Variables.computerScore < 3)
                {
                    Menu.RockPaperScissorsMenu();

                    switch (Variables.random.Next(1, 4))
                    {
                        case 1:
                            Variables.computer = "ROCK";
                            Console.WriteLine($"Computer choose {Variables.computer}");
                            if (Variables.player == "ROCK")
                            {
                                Console.WriteLine("DRAW!");
                                AreYouLuckyScoreMinus();
                            }
                            else if (Variables.player == "PAPER")
                            {
                                Console.WriteLine("YOU WON!");
                                Variables.playerScore++;
                            }
                            else
                            {
                                Console.WriteLine("YOU LOSE!");
                                Variables.computerScore++;
                            }
                            break;
                        case 2:
                            Variables.computer = "PAPER";
                            Console.WriteLine($"Computer choose {Variables.computer}");
                            if (Variables.player == "ROCK")
                            {
                                Console.WriteLine("YOU LOSE!");
                                Variables.computerScore++;
                            }
                            else if (Variables.player == "PAPER")
                            {
                                Console.WriteLine("DRAW!");
                                AreYouLuckyScoreMinus();
                            }
                            else
                            {
                                Console.WriteLine("YOU WON!");
                                Variables.playerScore++;
                            }
                            break;
                        case 3:
                            Variables.computer = "SCISSORS";
                            Console.WriteLine($"Computer choose {Variables.computer}");
                            if (Variables.player == "ROCK")
                            {
                                Console.WriteLine("YOU WON!");
                                Variables.playerScore++;
                            }
                            else if (Variables.player == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!");
                                AreYouLuckyScoreMinus();
                            }
                            else
                            {
                                Console.WriteLine("YOU LOSE!");
                                Variables.computerScore++;
                            }

                            break;
                    }

                    Console.WriteLine($"\n{Variables.yourName} score: {Variables.playerScore}\ncomputer score: {Variables.computerScore}");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Variables.rockPaperScissorsSelecting = true;
                    Variables.quickRounds = false;


                }
                Menu.GameOverMenu();
            }
        }

        public static void AreYouLuckyScoreMinus()
        {
            if (Variables.rockPaperScissorsModeOption == 3)
            {
                Variables.playerScore--;
            }
        }
    }
}
