namespace rockpaperscissors;

public class ForcedPlayer : IPlayer
{
    private GameManager.Choice _choice;
    public ForcedPlayer(GameManager.Choice choice)
    {
        _choice = choice;
    }
    public GameManager.Choice GetChoice()
    {
        return _choice;
    }
}
