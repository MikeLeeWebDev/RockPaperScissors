namespace RockPaperScissors.Helpers;
using RockPaperScissors.Models;

//Pure functions
public static class Functions
{
    // Gives the return from choice 1-3, then used in Games.cs     
    public static string GetMoveFromNumber(int number)
    {
        return number switch
        {
            1 => "ROCK",
            2 => "PAPER",
            3 => "SCISSORS",
            _ => ""
        };
    }



    /// <summary>
    /// Logics for outcome player vs computer
    /// </summary>
    /// <param name="playerMove">String with players move "ROCK" "PAPER" OR "SCISSORS" </param>
    /// <param name="computerMove">String with computers move </param>
    /// <returns> Outcome Enum</returns>
    public static Outcome GetOutcome(string playerMove, string computerMove)
    {
        // Draw!
        if (playerMove == computerMove)
        {
            return Outcome.Draw;
        }
        // Win!
        if (playerMove == "ROCK" && computerMove == "SCISSORS"
            || playerMove == "PAPER" && computerMove == "ROCK"
            || playerMove == "SCISSORS" && computerMove == "PAPER"
            )
        {
            return Outcome.Win;
        }
        // Lose!
        return Outcome.Lose;
    }
}