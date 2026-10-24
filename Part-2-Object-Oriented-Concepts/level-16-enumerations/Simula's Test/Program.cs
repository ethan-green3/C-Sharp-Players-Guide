var chestState = LockState.Open;

while (true)
{
    Console.Write($"The chest is {chestState}. What do you want to do? ");
    string choice = Console.ReadLine() ?? "";
    HandleChestUpdate(choice);
}

void HandleChestUpdate(string choice)
{
    if (choice == "")
    {
        Console.WriteLine("Enter a valid choice");
        return;
    }
    switch (choice)
    {
        case "unlock":
            if (chestState != LockState.Locked)
            {
                Console.WriteLine("Cannot unlock a chest that isn't locked");
                break;
            }
            chestState = LockState.Closed;
            break;
        case "open":
            if (chestState != LockState.Closed)
            {
                Console.WriteLine("Cannot open a chest that isn't closed");
                break;
            }
            chestState = LockState.Open;
            break;
        case "close":
            if (chestState != LockState.Open)
            {
                Console.WriteLine("Cannot close a chest that isn't open");
                break;
            }
            chestState = LockState.Closed;
            break;
        case "lock":
            if (chestState != LockState.Closed)
            {
                Console.WriteLine("Cannot lock a chest that isn't closed");
                break;
            }
            chestState = LockState.Locked;
            break;
        default:
            Console.WriteLine("Unknown choice");
            break;
    }
}

enum LockState
{
    Open,
    Closed,
    Locked
}