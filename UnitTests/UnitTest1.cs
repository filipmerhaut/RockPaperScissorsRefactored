namespace UnitTests;

using rockpaperscissors;

public class UnitTest1
{
    [Fact]
    public void TestRockVsScissors()
    {
        GameManager gm = new GameManager(new ForcedPlayer(GameManager.Choice.Rock), new ForcedPlayer(GameManager.Choice.Scissors));
        Assert.Equal(GameManager.RoundResult.Player1Winner, gm.PlayRound());
    }

    [Fact]
    public void TestRockVsPaper()
    {
        GameManager gm = new GameManager(new ForcedPlayer(GameManager.Choice.Rock), new ForcedPlayer(GameManager.Choice.Paper));
        Assert.Equal(GameManager.RoundResult.Player2Winner, gm.PlayRound());
    }

    [Fact]
    public void TestRockVsRock()
    {
        GameManager gm = new GameManager(new ForcedPlayer(GameManager.Choice.Rock), new ForcedPlayer(GameManager.Choice.Rock));
        Assert.Equal(GameManager.RoundResult.Draw, gm.PlayRound());
    }

    [Fact]
    public void TestScissorsVsScissors()
    {
        GameManager gm = new GameManager(new ForcedPlayer(GameManager.Choice.Scissors), new ForcedPlayer(GameManager.Choice.Scissors));
        Assert.Equal(GameManager.RoundResult.Draw, gm.PlayRound());
    }

    [Fact]
    public void TestScissorsVsPaper()
    {
        GameManager gm = new GameManager(new ForcedPlayer(GameManager.Choice.Scissors), new ForcedPlayer(GameManager.Choice.Paper));
        Assert.Equal(GameManager.RoundResult.Player1Winner, gm.PlayRound());
    }

    [Fact]
    public void TestScissorsVsRock()
    {
        GameManager gm = new GameManager(new ForcedPlayer(GameManager.Choice.Scissors), new ForcedPlayer(GameManager.Choice.Rock));
        Assert.Equal(GameManager.RoundResult.Player2Winner, gm.PlayRound());
    }
}