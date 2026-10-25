(Food food, MainIngredient mainIngredient, Seasoning seasoning) soup;
Console.WriteLine("--------");
PrintFoodOptions();
Console.Write("What is your food choice?" );
soup.food = Enum.Parse<Food>(Console.ReadLine());

PrintMainIngredientOptions();
Console.Write("What is your main ingredient choice?" );
soup.mainIngredient = Enum.Parse<MainIngredient>(Console.ReadLine());

PrintSeasoningOptions();
Console.Write("What is your seasoning option? ");
soup.seasoning = Enum.Parse<Seasoning>(Console.ReadLine());

Console.WriteLine($"{soup.food} {soup.mainIngredient} {soup.seasoning}");

void PrintFoodOptions()
{
    Console.WriteLine("Food Options");
    foreach (Food food in Enum.GetValues<Food>())
    {
        Console.WriteLine(food);
    }
    Console.WriteLine("--------");
}

void PrintMainIngredientOptions()
{
    Console.WriteLine("Main Ingredient Options");
    foreach (MainIngredient mainIngredient in Enum.GetValues<MainIngredient>())
    {
        Console.WriteLine(mainIngredient);
    }
    Console.WriteLine("--------");
}

void PrintSeasoningOptions()
{
    Console.WriteLine("Seasoning options:");
    foreach (Seasoning seasoning in Enum.GetValues<Seasoning>())
    {
        Console.WriteLine(seasoning);
    }
    Console.WriteLine("--------");
}

enum Food
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}