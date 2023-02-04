using RockPaperScissors.Models;

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
                    Variables.player = Menu.RockPaperScissorsMenu();
                    Variables.computer = Functions.GetMoveFromNumber(Variables.random.Next(1, 4));

                    // Get the outcome for the round
                    Outcome result = Functions.GetOutcome(Variables.player, Variables.computer);

                    Console.WriteLine($"Computer chose {Variables.computer}");

                    switch (result)
                    {
                        case Outcome.Win:
                            Console.WriteLine("YOU WON!");
                            Variables.playerScore++;
                            break;
                        case Outcome.Draw:
                            Console.WriteLine("DRAW!");
                            if (Variables.rockPaperScissorsModeOption == 3)
                            {
                                Variables.playerScore--;
                            }
                            break;
                        case Outcome.Lose:
                            Console.WriteLine("YOU LOSE!");
                            Variables.computerScore++;
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
    }
}
