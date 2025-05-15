namespace rockpaperscissors
{
    public class HumanPlayer : IPlayer
    {
        public GameManager.Choice GetChoice()
        {
            Console.WriteLine("Enter your choice (R)ock, (P)aper, (S)cissors: ");
            while (true)
            {
                string? input = Console.ReadKey().KeyChar.ToString();
                if (input == "R" || input == "r")
                {
                    return GameManager.Choice.Rock;
                }
                else if (input == "P" || input == "p")
                {
                    return GameManager.Choice.Paper;
                }
                else if (input == "S" || input == "s")
                {
                    return GameManager.Choice.Scissors;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("");
                }
            }
        }
    }   
}
