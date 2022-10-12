internal class Program
{
    // datafields
    private static char[,] board =
    {
        {'1', '2', '3'},
        {'4', '5', '6'},
        {'7', '8', '9'},
    };

    // main method
    private static void Main(string[] args)
    {
        int player = 2; // player 1 starts -> do while loop changes player to 1 in first iteration!
        int input = 0;
        bool inputValid = true;

        // code runs as long as the program runs
        do
        {
            // switch player
            if (player == 2)
            {
                player = 1;
            }

            switch (player)
            {
                case 1: // player 1's turn
                    {
                        switch (input)
                        {
                            case 1: board[0, 0] = 'X'; break;
                            // TODO: Implement all fields
                            default:
                                break;
                        }
                    }
                    break;
                case 2: // player 2's turn
                    {
                        switch (input)
                        {
                            case 1: board[0, 0] = 'O'; break;
                            // TODO: Implement all fields
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }

        } while (true);
    }

    // methods

    /// <summary>
    /// Prints the board with the current values onto the console.
    /// </summary>
    private static void SetField()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0,0], board[0,1], board[0,2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1,0], board[1,1], board[1,2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2,0], board[2,1], board[2,2]);
        Console.WriteLine("     |     |     ");
    }
}
