// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the triangle base length");
double triangleBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the triangle height length");
double triangleHeight = Convert.ToDouble(Console.ReadLine());

double triangleArea = (triangleBase * triangleHeight) / 2;
Console.WriteLine($"The triangle area is: {triangleArea}");
