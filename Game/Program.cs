namespace rockpaperscissors;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Rock Paper Scissors Refactored");
        IPlayer player1 = new rockpaperscissors.HumanPlayer();
        IPlayer player2 = new rockpaperscissors.ComputerPlayer();

        GameManager gameManager = new GameManager(new HumanPlayer(), new ComputerPlayer()); 
        gameManager.PlayGame();
    }    
}
