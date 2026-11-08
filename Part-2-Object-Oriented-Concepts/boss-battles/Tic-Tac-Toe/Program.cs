TicTacToe game = new();
char currentPlayer = 'X';

Console.WriteLine("Choose squares using the number pad:");
Console.WriteLine(" 1 | 2 | 3 ");
Console.WriteLine("---+---+---");
Console.WriteLine(" 4 | 5 | 6 ");
Console.WriteLine("---+---+---");
Console.WriteLine(" 7 | 8 | 9 ");
Console.WriteLine();

game.PrintBoard();

while (true)
{
    Console.WriteLine();
    Console.WriteLine($"It is {currentPlayer}'s turn.");
    Console.Write("What square do you want to play in? ");

    string? input = Console.ReadLine();

    if (input is null)
    {
        break;
    }

    if (!int.TryParse(input, out int choice) || choice < 1 || choice > 9)
    {
        Console.WriteLine("Enter a number from 1 through 9.");
        continue;
    }

    int square = choice - 1;

    if (!game.InsertGameLetter(square, currentPlayer))
    {
        continue;
    }

    Console.WriteLine();
    game.PrintBoard();

    if (game.DetectWin(currentPlayer))
    {
        Console.WriteLine();
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }

    if (game.IsBoardFull())
    {
        Console.WriteLine();
        Console.WriteLine("The game is a draw!");
        break;
    }

    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
}

public class TicTacToe
{
    private readonly char[] board = new char[9];

    private static readonly int[][] winningLines =
    [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8],
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8],
        [0, 4, 8],
        [2, 4, 6]
    ];

    public bool InsertGameLetter(int square, char playerChoice)
    {
        if (square < 0 || square >= board.Length)
        {
            Console.WriteLine("Invalid square.");
            return false;
        }

        if (playerChoice != 'X' && playerChoice != 'O')
        {
            Console.WriteLine("The game letter must be X or O.");
            return false;
        }

        if (board[square] != '\0')
        {
            Console.WriteLine("That square is already occupied. Try again.");
            return false;
        }

        board[square] = playerChoice;
        return true;
    }

    public void PrintBoard()
    {
        for (int i = 0; i < board.Length; i++)
        {
            char letter = board[i] == '\0' ? ' ' : board[i];
            Console.Write($" {letter} ");

            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine();

                if (i < board.Length - 1)
                {
                    Console.WriteLine("---+---+---");
                }
            }
            else
            {
                Console.Write("|");
            }
        }
    }

    public bool DetectWin(char player)
    {
        if (player != 'X' && player != 'O')
        {
            return false;
        }

        foreach (int[] line in winningLines)
        {
            if (board[line[0]] == player &&
                board[line[1]] == player &&
                board[line[2]] == player)
            {
                return true;
            }
        }

        return false;
    }

    public bool IsBoardFull()
    {
        foreach (char square in board)
        {
            if (square == '\0')
            {
                return false;
            }
        }

        return true;
    }
}