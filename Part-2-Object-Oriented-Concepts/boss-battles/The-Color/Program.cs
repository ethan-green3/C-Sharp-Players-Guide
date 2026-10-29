Color color1 = new(125,120,200);
Color color2 = Color.MakeGreen();

Console.WriteLine($"Color 1 R: {color1.Red} G: {color1.Green} B: {color1.Blue}");
Console.WriteLine($"Color 2 R: {color2.Red} G: {color2.Green} B: {color2.Blue}");
public class Color
{
    public int Red {get; set;}
    public int Blue {get; set;}
    public int Green {get; set;}

    public Color(int red, int blue, int green)
    {
        Red = red;
        Blue = blue;
        Green = green;
    }

    public static Color MakeWhite() => new(255,255,255);
    public static Color MakeBlack() => new(0,0,0);
    public static Color MakeRed() => new(255,0,0);
    public static Color MakeOrange() => new(255,165,0);
    public static Color MakeYellow() => new(255,255,0);
    public static Color MakeGreen() => new(0,0,255);
    public static Color MakeBlue() => new(0,255,0);
    public static Color MakePurple() => new(128,0,128);

}