Sword sword = new();
Bow bow = new();
Axe axe = new();

ColoredItem<Sword> ColoredSword = new(sword, ConsoleColor.Blue);
ColoredItem<Bow> ColoredBow = new(bow, ConsoleColor.Red);
ColoredItem<Axe> ColoredAxe = new(axe, ConsoleColor.Green);

ColoredSword.Display();
ColoredBow.Display();
ColoredAxe.Display();

public class Sword { }
public class Bow { }

public class Axe { }

public class ColoredItem<T>(T Item, ConsoleColor Color)
{
    public T Item {get;} = Item;
    public ConsoleColor Color {get;} = Color;

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item?.ToString() ?? "Item is not instantiated");
    }
}