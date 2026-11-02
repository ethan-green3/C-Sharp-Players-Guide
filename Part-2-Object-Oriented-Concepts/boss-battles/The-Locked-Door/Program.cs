Console.Write("Enter a starting passcode that is an integer: ");
int startingPasscode = Convert.ToInt32(Console.ReadLine());

Door door = new(startingPasscode);
int choice;

do
{
    Console.WriteLine($"\nDoor is {door.DoorState} right now");
    PrintMenu();
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            door.OpenDoor();
            break;
        case 2:
            door.CloseDoor();
            break;
        case 3:
            door.LockDoor();
            break;
        case 4:
            Console.Write("Enter the passcode: ");
            int passcode = Convert.ToInt32(Console.ReadLine());
            door.UnlockDoor(passcode);
            break;
        case 5:
            Console.Write("Enter the current passcode: ");
            int currentPasscode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the new passcode: ");
            int newPasscode = Convert.ToInt32(Console.ReadLine());

            door.UpdatePassword(currentPasscode, newPasscode);
            break;
        case 6:
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
} while (choice != 6);

static void PrintMenu()
{
    Console.WriteLine("What would you like to do with the door?");
    Console.WriteLine("1. Open");
    Console.WriteLine("2. Close");
    Console.WriteLine("3. Lock");
    Console.WriteLine("4. Unlock");
    Console.WriteLine("5. Change passcode");
    Console.WriteLine("6. Quit");
    Console.WriteLine("----------------------");
}

public class Door(int passcode)
{
    private int Passcode { get; set; } = passcode;

    public DoorState DoorState { get; private set; } = DoorState.Open;

    public void UpdatePassword(int currentPasscode, int newPasscode)
    {
        if (currentPasscode == Passcode)
        {
            Passcode = newPasscode;
            Console.WriteLine("Passcode updated");
        }
        else
        {
            Console.WriteLine("Current passcode does not match, new passcode not set");
        }
    }

    public void CloseDoor()
    {
        if (DoorState == DoorState.Open)
        {
            DoorState = DoorState.Closed;
        }
        else
        {
            Console.WriteLine("Cannot close the door unless it is open");
        }
    }

    public void OpenDoor()
    {
        if (DoorState == DoorState.Closed)
        {
            DoorState = DoorState.Open;
        }
        else
        {
            Console.WriteLine("Cannot open the door unless it is closed and unlocked");
        }
    }

    public void LockDoor()
    {
        if (DoorState == DoorState.Closed)
        {
            DoorState = DoorState.Locked;
        }
        else
        {
            Console.WriteLine("Cannot lock the door unless it is closed");
        }
    }

    public void UnlockDoor(int passcode)
    {
        if (DoorState != DoorState.Locked)
        {
            Console.WriteLine("The door is not locked");
        }
        else if (passcode != Passcode)
        {
            Console.WriteLine("Incorrect passcode, cannot unlock the door");
        }
        else
        {
            DoorState = DoorState.Closed;
        }
    }
}

public enum DoorState
{
    Open,
    Closed,
    Locked
}