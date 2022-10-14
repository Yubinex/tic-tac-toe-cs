internal class Program
{
    // datafields
    private static char[,] board =
    {
        {'1', '2', '3'},
        {'4', '5', '6'},
        {'7', '8', '9'},
    };

    private static int turns = 0;

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
                EnterXorO(player, input);
            }
            else if (player == 1) 
            { 
                player = 2;
                EnterXorO(player, input);
            }

            SetField();

            // check winning condition
            #region
            // TODO: implement winning conditions
            char[] playerChars = { 'X', 'O' };
            foreach (char playerChar in playerChars)
            {
                if (((board[0, 0] == playerChar) && (board[0, 1] == playerChar) && (board[0, 2] == playerChar))     // first row -
                    || ((board[1, 0] == playerChar) && (board[1, 1] == playerChar) && (board[1, 2] == playerChar))  // second row -
                    || ((board[2, 0] == playerChar) && (board[2, 1] == playerChar) && (board[2, 2] == playerChar))  // third row -
                    || ((board[0, 0] == playerChar) && (board[1, 0] == playerChar) && (board[2, 0] == playerChar))  // first col -
                    || ((board[0, 1] == playerChar) && (board[1, 1] == playerChar) && (board[2, 1] == playerChar))  // second col -
                    || ((board[0, 2] == playerChar) && (board[1, 2] == playerChar) && (board[2, 2] == playerChar))  // third col -
                    || ((board[0, 0] == playerChar) && (board[1, 1] == playerChar) && (board[2, 2] == playerChar))  // first diagonal
                    || ((board[0, 2] == playerChar) && (board[1, 1] == playerChar) && (board[2, 0] == playerChar))) // second diagonal
                {
                    if (playerChar.Equals('X')) { Console.WriteLine("\nPlayer 2 won!"); }
                    else if (playerChar.Equals('O')) { Console.WriteLine("\nPlayer 1 won!"); }

                    Console.WriteLine("\n## Press any key to restart. ##");
                    Console.ReadKey();
                    ResetField();
                }
                else if (turns == 10) 
                { 
                    Console.WriteLine("\nWe have a draw!");
                    Console.WriteLine("\n## Press any key to restart. ##");
                    Console.ReadKey();
                    ResetField();
                }
            }
            #endregion

            #region
            // test if field is already taken
            do
            {
                Console.WriteLine($"\nTURN {turns}");
                Console.WriteLine($"\nPlayer {player}'s turn. Choose a field:");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine($"Input {input} is not valid.");
                }

                if ((input == 1) && (board[0, 0] == '1')) { inputValid = true; }
                else if ((input == 2) && (board[0, 1] == '2')) { inputValid = true; }
                else if ((input == 3) && (board[0, 2] == '3')) { inputValid = true; }
                else if ((input == 4) && (board[1, 0] == '4')) { inputValid = true; }
                else if ((input == 5) && (board[1, 1] == '5')) { inputValid = true; }
                else if ((input == 6) && (board[1, 2] == '6')) { inputValid = true; }
                else if ((input == 7) && (board[2, 0] == '7')) { inputValid = true; }
                else if ((input == 8) && (board[2, 1] == '8')) { inputValid = true; }
                else if ((input == 9) && (board[2, 2] == '9')) { inputValid = true; }
                else 
                {
                    Console.WriteLine($"{input} is not a valid field! Choose again.");
                    inputValid = false; 
                }

            } while (!inputValid);
            #endregion

        } while (true);
    }

    // methods

    /// <summary>
    /// Prints the board with the current values onto the console.
    /// </summary>
    private static void SetField()
    {
        Console.Clear();
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0,0], board[0,1], board[0,2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1,0], board[1,1], board[1,2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2,0], board[2,1], board[2,2]);
        Console.WriteLine("     |     |     ");
        turns++;
    }

    private static void ResetField()
    {
        char[,] boardInitial =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'},
        };

        board = boardInitial;
        SetField();
        turns = 1;
    }

    private static void EnterXorO(int player, int input)
    {
        char playerChar = ' ';
        switch (player)
        {
            case 1: playerChar = 'X'; break;
            case 2: playerChar = 'O'; break;
            default:
                break;
        }

        switch (input)
        {
            case 1: board[0, 0] = playerChar; break;
            case 2: board[0, 1] = playerChar; break;
            case 3: board[0, 2] = playerChar; break;
            case 4: board[1, 0] = playerChar; break;
            case 5: board[1, 1] = playerChar; break;
            case 6: board[1, 2] = playerChar; break;
            case 7: board[2, 0] = playerChar; break;
            case 8: board[2, 1] = playerChar; break;
            case 9: board[2, 2] = playerChar; break;
            default:
                Console.WriteLine($"{input} not a valid input");
                break;
        }
    }
}
