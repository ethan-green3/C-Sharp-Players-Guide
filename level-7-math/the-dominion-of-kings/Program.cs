int provinceCount;
int duchiesCount;
int estateCount;

Console.WriteLine("How many provinces do you have?");
provinceCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies do you have?");
duchiesCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many estates do you have?");
estateCount = Convert.ToInt32(Console.ReadLine());

int totalScore = (provinceCount * 6) + (duchiesCount * 3) + estateCount;

Console.WriteLine($"Your total score is {totalScore}");
