int[] array = new int[5];

Console.Write("Enter the first number: ");
int choice = Convert.ToInt32(Console.ReadLine());
array[0] = choice;

Console.Write("Enter the second number: ");
choice = Convert.ToInt32(Console.ReadLine());
array[1] = choice;

Console.Write("Enter the third number: ");
choice = Convert.ToInt32(Console.ReadLine());
array[2] = choice;

Console.Write("Enter the fourth number: ");
choice = Convert.ToInt32(Console.ReadLine());
array[3] = choice;

Console.Write("Enter the fifth number: ");
choice = Convert.ToInt32(Console.ReadLine());
array[4] = choice;

int[] secondArray = new int[5];

for (int i = 0; i < array.Length; i++)
{
    secondArray[i] = array[i];
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"First array val: {array[i]} - Second array val: {secondArray[i]}");
}
