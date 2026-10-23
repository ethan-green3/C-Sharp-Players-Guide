int x;
int y;

Console.WriteLine("Enter the value for x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value for y");
y = Convert.ToInt32(Console.ReadLine());

if (x < 0 && y > 0)
{
    Console.WriteLine("The enemy is to the northwest!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("The enemy is to the north!");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is to the northeast!");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("The enemy is to the west!");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is to the east!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("The enemy is to the southwest!");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("The enemy is to the south!");
}
else
{
    Console.WriteLine("The enemy is to the southeast");
}
