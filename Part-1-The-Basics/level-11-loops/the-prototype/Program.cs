int user1Number;
int user2Number;
Console.Write("User 1, enter a number between 0 and 100: ");
user1Number = Convert.ToInt32(Console.ReadLine());
Console.Write("User 2, guess the number: ");
user2Number = Convert.ToInt32(Console.ReadLine());

while (user1Number != user2Number)
{
    if (user1Number < user2Number)
    {
        Console.WriteLine($"{user2Number} is too high");
    }
    else if (user1Number > user2Number)
    {
        Console.WriteLine($"{user2Number} is too low");
    }
    Console.Write("What is your next guess? ");
    user2Number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("You guessed the number!");
