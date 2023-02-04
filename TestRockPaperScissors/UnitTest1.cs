namespace TestRockPaperScissors;
using RockPaperScissors.Helpers;
using RockPaperScissors.Models;

public class UnitTest1
{
    [Theory]
    [InlineData("ROCK", "SCISSORS", Outcome.Win)]
    [InlineData("PAPER", "ROCK", Outcome.Win)]
    [InlineData("SCISSORS", "PAPER", Outcome.Win)]
    [InlineData("ROCK", "PAPER", Outcome.Lose)]
    [InlineData("PAPER", "SCISSORS", Outcome.Lose)]
    [InlineData("SCISSORS", "ROCK", Outcome.Lose)]
    [InlineData("ROCK", "ROCK", Outcome.Draw)]
    [InlineData("PAPER", "PAPER", Outcome.Draw)]
    [InlineData("SCISSORS", "SCISSORS", Outcome.Draw)]
    public void GetOutcomeTest(string player, string computer, Outcome expected)
    {
        // Spelaren k�r rock och datorn k�r paper. Vi borde f�rlora!
        var result = Functions.GetOutcome(player, computer);

        Assert.Equal(expected, result);
    }
}