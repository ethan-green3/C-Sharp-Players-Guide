Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of?: ");

int choice;
choice = Convert.ToInt32(Console.ReadLine());
string response;

response = choice switch
{
    1 => "Rope cost 10 gold",
    2 => "Torches cost 16 gold",
    3 => "Climbing Equipment cost 24 gold",
    4 => "Clean Water cost 2 gold",
    5 => "Machete cost 20 gold",
    6 => "Canoe cost 200 gold",
    7 => "Food supplies cost 2 gold",
    _ => "Choice is not valid",
};

Console.WriteLine(response);
