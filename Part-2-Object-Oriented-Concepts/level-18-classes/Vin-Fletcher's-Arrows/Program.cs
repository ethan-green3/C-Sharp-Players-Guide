Arrow arrow = new(ArrowheadType.Steel, FletchingType.TurkeyFeathers, 80);
float arrowCost = arrow.GetCost();
Console.WriteLine($"This arrow cost {arrowCost}");

class Arrow
{
    public ArrowheadType arrowHead;
    public FletchingType fletchingType;
    public int length;

    public Arrow(ArrowheadType arrowhead, FletchingType fletchingType, int length)
    {
        this.arrowHead = arrowhead;
        this.fletchingType = fletchingType;
        if (length < 60 || length > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Arrow length must be between 60 and 100 cm");
        }
        this.length = length;
    }

    public float GetCost()
    {
        float cost = this.fletchingType switch
        {
            FletchingType.GooseFeathers => 3.0f,
            FletchingType.Plastic => 10.0f,
            FletchingType.TurkeyFeathers => 5.0f,
            _ => 0.0f
        };
        cost += this.arrowHead switch
        {
            ArrowheadType.Steel => 10.0f,
            ArrowheadType.Wood => 3.0f,
            ArrowheadType.Obsidian => 5.0f,
            _ => 0.0f
        };
        cost += this.length * 0.05f;
        return cost;
    }
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