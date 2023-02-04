namespace RockPaperScissors.Helpers;
using RockPaperScissors.Models;

//Pure functions
public static class Functions
{
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