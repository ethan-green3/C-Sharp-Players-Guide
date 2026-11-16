Robot robot = new();
string[] commands = new string[3];
Console.WriteLine("Enter 3 commands for the robot (on, off, north, south, east, west)");
Console.Write("Enter the first command: ");
commands[0] = Console.ReadLine() ?? "Input cannot be null";

Console.Write("Enter the seconds command: ");
commands[1] = Console.ReadLine()  ?? "Input cannot be null";

Console.Write("Enter the third command: ");
commands[2] = Console.ReadLine()  ?? "Input cannot be null";

for (int i = 0; i < commands.Length; i++)
{
    robot.Commands[i] = commands[i] switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
        _ => throw new NotImplementedException()
    };
}
robot.Run();
public abstract class RobotCommand()
{
   public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y += 1;
        }
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y -= 1;
        }
    }
}

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X += 1;
        }
    }
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X -= 1;
        }
    }
}

public class Robot 
{ 
    public int X { get; set; } 
    public int Y { get; set; } 
    public bool IsPowered { get; set; } 
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3]; 
    public void Run() 
    { 
        foreach (RobotCommand? command in Commands) 
        { 
            command?.Run(this); 
            Console.WriteLine($"[{X} {Y} {IsPowered}]"); 
        } 
    }    
} 