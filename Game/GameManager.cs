namespace rockpaperscissors;

public class GameManager
{

    private IPlayer _player1;
    private IPlayer _player2;
    public GameManager(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public void PlayGame()
    {
        while (true)
        {
            PlayRound();
            Console.WriteLine("Play again? (Y/N): ");
            string? input = Console.ReadKey().KeyChar.ToString();
            if (input != "Y" && input != "y")
            {
                break;
            }
            Console.Clear();
        }
    }

    public RoundResult PlayRound()
    {
        Choice playerChoice = _player1.GetChoice();
        Choice computerChoice =_player2.GetChoice();
        RoundResult result = GetRoundResult(playerChoice, computerChoice);
        Console.WriteLine($"Player chose {playerChoice}");
        Console.WriteLine($"Computer chose {computerChoice}");
        if (result == RoundResult.Player1Winner)
        {
            Console.WriteLine("You win!");
            return RoundResult.Player1Winner;
        }
        else if (result == RoundResult.Player2Winner)
        {
            Console.WriteLine("Computer wins!");
            return RoundResult.Player2Winner;
        }
        else
        {
            Console.WriteLine("It's a draw!");
            return RoundResult.Draw;
        }        
    }


    private RoundResult GetRoundResult(Choice player1Choice, Choice player2Choice)
    {
        if (player1Choice == player2Choice)
        {
            return RoundResult.Draw;
        }
        else if (player1Choice == Choice.Rock && player2Choice == Choice.Scissors ||
                 player1Choice == Choice.Paper && player2Choice == Choice.Rock ||
                 player1Choice == Choice.Scissors && player2Choice == Choice.Paper)
        {
            return RoundResult.Player1Winner;
        }
        else
        {
            return RoundResult.Player2Winner;
        }
    }

    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public enum RoundResult
    {
        Player1Winner,
        Player2Winner,
        Draw
    }
}