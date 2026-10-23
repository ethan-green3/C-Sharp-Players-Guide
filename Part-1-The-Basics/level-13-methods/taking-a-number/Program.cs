

static int AskForNumber(string text)
{
    Console.WriteLine(text);
    int response = Convert.ToInt32(Console.ReadLine());
    return response;
}

static int AskForNumberInRange(string text, int min, int max)
{
    int choice = AskForNumber(text);
    if (choice < min || choice > max)
    {
        choice = AskForNumber("You need to enter a number between the min and max");
    }
    return choice;
}

Console.WriteLine(AskForNumberInRange("Enter a number between 1 and 100", 1, 100));
