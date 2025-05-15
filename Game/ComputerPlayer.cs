namespace rockpaperscissors;

public class ComputerPlayer : IPlayer
{
    public GameManager.Choice GetChoice()
    {
        Random random = new Random();
        int choice = random.Next(0, 3);
        return (GameManager.Choice)choice;
    }
}
