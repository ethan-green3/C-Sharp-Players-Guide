Console.WriteLine("What kind of thing are we talking about?");
// Getting the thing we are talking about
string a = Console.ReadLine();
/*
 Multi-line comment b is another user input, c and d are hard coded string literals
*/
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
string c = "Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
