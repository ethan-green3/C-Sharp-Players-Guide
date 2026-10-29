Console.WriteLine("Press 1 for a list of predefined arrows or 2 to make your own");
int choice = Convert.ToInt32(Console.ReadLine());
while (choice < 1 || choice > 2)
{
    Console.WriteLine("Invalid choice, enter 1 or 2");
    choice = Convert.ToInt32(Console.ReadLine());
}
Arrow newArrow;
switch (choice)
{
    case 1:
        Console.Write("Press 1 for Elite Arrow\nPress 2 for Beginner Arrow\nPress 3 for Marksman Arrow: ");
        int arrowChoice = Convert.ToInt32(Console.ReadLine());
        while (arrowChoice < 1 || arrowChoice > 3)
        {
            Console.WriteLine("Invalid choice, choose 1, 2, or 3");
            arrowChoice = Convert.ToInt32(Console.ReadLine());
        }
        switch (arrowChoice)
        {
            case 1:
                newArrow = Arrow.CreateEliteArrow();
                Console.WriteLine($"Your arrow cost {newArrow.GetCost()}");
                break;
            case 2:
                newArrow = Arrow.CreateBeginnerArrow();
                Console.WriteLine($"Your arrow cost {newArrow.GetCost()}");
                break;
            case 3:
                newArrow = Arrow.CreateMarksmanArrow();
                Console.WriteLine($"Your arrow cost {newArrow.GetCost()}");
                break;
        }
        break;
    case 2:
        Console.WriteLine("Enter an arrowead type - Steel, Wood or Plastic");
        string? arrowHeadTypeChoice = Console.ReadLine();
        ArrowheadType newArrowHeadType;
        bool successfulParse = Enum.TryParse<ArrowheadType>(arrowHeadTypeChoice, true, out newArrowHeadType);

        while (!successfulParse)
        {
            Console.Write("Invalid choice for arrowheadtype - enter a valid choice: ");
            arrowHeadTypeChoice = Console.ReadLine();
            successfulParse = Enum.TryParse<ArrowheadType>(arrowHeadTypeChoice, true, out newArrowHeadType);
        }

        Console.Write("Enter a fletching type (Plastic, TurkeyFeathers, GooseFeathers): ");
        string? fletchingChoice = Console.ReadLine();
        FletchingType newFletchingType;
        successfulParse = Enum.TryParse<FletchingType>(fletchingChoice, true, out newFletchingType);

        while (!successfulParse)
        {
            Console.Write("Invalid choice for fletching type - enter a valid choice: ");
            fletchingChoice = Console.ReadLine();
            successfulParse = Enum.TryParse<FletchingType>(fletchingChoice, true, out newFletchingType);
        }

        Console.Write("Enter a length beween 65 and 100 for the arrow length: ");
        int arrowLength = Convert.ToInt32(Console.ReadLine());
        while (arrowLength < 65 || arrowLength > 100)
        {
            Console.Write("Invalid length for arrow - enter a valid choice: ");
            arrowLength = Convert.ToInt32(Console.ReadLine());
        }
        newArrow = new Arrow(newArrowHeadType, newFletchingType, arrowLength);
        Console.WriteLine($"Your arrow cost {newArrow.GetCost()}");
        break;
}

class Arrow
{
    public ArrowheadType ArrowHead { get; set; }
    public FletchingType FletchingType { get; set; }
    public int Length { get; set; }

    public Arrow(ArrowheadType arrowhead, FletchingType fletchingType, int length)
    {
        this.ArrowHead = arrowhead;
        this.FletchingType = fletchingType;
        if (length < 60 || length > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Arrow length must be between 60 and 100 cm");
        }
        this.Length = length;
    }

    public float GetCost()
    {
        float cost = this.FletchingType switch
        {
            FletchingType.GooseFeathers => 3.0f,
            FletchingType.Plastic => 10.0f,
            FletchingType.TurkeyFeathers => 5.0f,
            _ => 0.0f
        };
        cost += this.ArrowHead switch
        {
            ArrowheadType.Steel => 10.0f,
            ArrowheadType.Wood => 3.0f,
            ArrowheadType.Obsidian => 5.0f,
            _ => 0.0f
        };
        cost += this.Length * 0.05f;
        return cost;
    }

    public static Arrow CreateEliteArrow() => new(ArrowheadType.Steel, FletchingType.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
    public static Arrow CreateMarksmanArrow() => new(ArrowheadType.Steel, FletchingType.GooseFeathers, 65);
}

enum FletchingType
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}
enum ArrowheadType
{
    Steel,
    Wood,
    Obsidian
}
