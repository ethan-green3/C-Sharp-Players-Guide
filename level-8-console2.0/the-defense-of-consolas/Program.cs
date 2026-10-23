int row;
int col;

Console.Title = "The Defence of Consolas";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Target Row? ");
row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
col = Convert.ToInt32(Console.ReadLine());

string pos1 = $"({row}, {col - 1})";
string pos2 = $"({row - 1}, {col})";
string pos3 = $"({row}, {col + 1})";
string pos4 = $"({row + 1}, {col})";

Console.WriteLine("Deploy to:");
Console.WriteLine(pos1);
Console.WriteLine(pos2);
Console.WriteLine(pos3);
Console.WriteLine(pos4);
Console.Beep();
