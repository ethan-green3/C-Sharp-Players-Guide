
Sword sword1 = new(Material.Iron, Gemstone.None, 15.0f, 4.0f);
Sword sword2 = sword1 with {Material = Material.Binarium, Gemstone = Gemstone.Emerald, Length = 10.0f, Width = 2.0f};
Sword sword3 = sword1 with {Material = Material.Steel, Gemstone = Gemstone.Diamond, Length = 24.0f, Width = 2.0f};

Console.WriteLine(sword1);
Console.WriteLine(sword2);
Console.WriteLine(sword3);

public record Sword(Material Material, Gemstone Gemstone, float Length, float Width) { }

public enum Material
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}

public enum Gemstone
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    None
}