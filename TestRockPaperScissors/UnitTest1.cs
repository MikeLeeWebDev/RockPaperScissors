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
        // Spelaren kör rock och datorn kör paper. Vi borde förlora!
        var result = Functions.GetOutcome(player, computer);

        Assert.Equal(expected, result);
    }
}