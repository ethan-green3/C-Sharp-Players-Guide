Console.Write("Enter your packs max number of items: ");
int maxNumOfItems = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your packs max weght: ");
float maxWeight = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));

Console.Write("Enter your packs max volume: ");
float maxVolume = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));

Pack pack = new(maxNumOfItems, maxWeight, maxVolume);

while (true)
{
    PrintItemMenu();
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice < 1 || choice > 6)
    {
        Console.WriteLine("Invalid choice");
        continue;
    }
    InventoryItem item = MakeItem(choice) ?? throw new InvalidOperationException("Input cannot be null.");
    bool didAdd = pack.Add(item);
    if (!didAdd)
    {
        Console.WriteLine($"Could not add {item} to the pack");
    }
    PrintPackStatus(pack);
}

static void PrintPackStatus(Pack pack)
{
    Console.WriteLine("--- Pack Status ---");
    Console.WriteLine($"Items: {pack.TotalItemCount}/{pack.MaxNumOfItems}");
    Console.WriteLine($"Weight: {pack.TotalWeight}/{pack.MaxWeight}");
    Console.WriteLine($"Volume: {pack.TotalVolume}/{pack.MaxVolume}");
}

static InventoryItem MakeItem(int choice)
{
    Console.WriteLine("Would you like to me a default item or create one?");
    Console.WriteLine("1: Default");
    Console.WriteLine("2: Custom Made");
    Console.Write("Make your choice: ");
    int defaultOrCustom = Convert.ToInt32(Console.ReadLine());

    while (defaultOrCustom < 1 || defaultOrCustom > 2)
    {
        Console.Write("Enter a valid number: ");
        defaultOrCustom = Convert.ToInt32(Console.ReadLine());
    }

    InventoryItem item;
    switch (defaultOrCustom)
    {
        case 1:
            item = MakeDefaultInvetoryItem(choice);
            break;
        case 2:
            Console.Write("Enter the items weight: ");
            float itemWeight = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));

            Console.Write("Enter the items volume: ");
            float itemVolume = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));
            item = MakeCustomInventoryItem(choice, itemWeight, itemVolume);
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(defaultOrCustom));
    }
    return item;
}

static InventoryItem MakeDefaultInvetoryItem(int itemNumber)
{
    InventoryItem item = itemNumber switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
        _ => throw new NotImplementedException(),
    };
    return item;
}

static InventoryItem MakeCustomInventoryItem(int itemNumber, float weight, float volume)
{
    InventoryItem item = itemNumber switch
    {
        1 => new Arrow(weight, volume),
        2 => new Bow(weight, volume),
        3 => new Rope(weight, volume),
        4 => new Water(weight, volume),
        5 => new Food(weight, volume),
        6 => new Sword(weight, volume),
        _ => throw new NotImplementedException(),
    };
    return item;    
}

static void PrintItemMenu()
{
    Console.WriteLine("Choose an item to create and add to your pack.");
    Console.WriteLine("1: Arrow");
    Console.WriteLine("2: Bow");
    Console.WriteLine("3: Rope");
    Console.WriteLine("4: Water");
    Console.WriteLine("5: Food");
    Console.WriteLine("6: Sword");
    Console.Write("Make your choice: ");
}

public class InventoryItem(float weight, float volume)
{
    public float Weight {get;} = weight;
    public float Volume {get;} = volume;
}

public sealed class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f) { }
    public Arrow(float weight, float volume) : base(weight, volume) { }
}

public sealed class Bow : InventoryItem
{
    public Bow() : base(1f, 4f) { }
    public Bow(float weight, float volume) : base(weight, volume) { }
}

public sealed class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f) { }
    public Rope(float weight, float volume) : base(weight, volume) { }
}

public sealed class Water : InventoryItem
{
    public Water() : base(2f, 3f) { }
    public Water(float weight, float volume) : base(weight, volume) { }
}

public sealed class Food : InventoryItem
{
    public Food() : base(1f, 0.5f) { }
    public Food(float weight, float volume) : base(weight, volume) { }
}

public sealed class Sword : InventoryItem
{
    public Sword() : base(5f, 3f) { }
    public Sword(float weight, float volume) : base(weight, volume) { }
}

public sealed class Pack(int maxNumOfItems, float maxWeight, float maxVolume)
{
    private InventoryItem[] items = new InventoryItem[maxNumOfItems];
    public int MaxNumOfItems {get;} = maxNumOfItems;
    public float MaxWeight {get;} = maxWeight;
    public float MaxVolume {get;} = maxVolume;
    public float TotalWeight {get; private set;}
    public float TotalVolume {get; private set;}
    public int TotalItemCount {get; private set;}
    public bool Add(InventoryItem item)
    {
        if (item.Weight + TotalWeight > MaxWeight)
        {
            Console.WriteLine("Cannot add item, exceeds max weight");
            return false;
        }
        if (item.Volume + TotalVolume > MaxVolume)
        {
            Console.WriteLine("Cannot add item, exceed max volume");
            return false;
        }
        if (TotalItemCount >= MaxNumOfItems)
        {
            Console.WriteLine("Cannot add item, exceed total max items allowed");
            return false;
        }
        items[TotalItemCount] = item;
        TotalWeight += item.Weight;
        TotalVolume += item.Volume;
        TotalItemCount++;
        return true;
    }
}