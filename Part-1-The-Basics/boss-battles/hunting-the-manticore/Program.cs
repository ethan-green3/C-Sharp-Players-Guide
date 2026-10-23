int mantiCoreHealth = 10;
int cityHealth = 15;

int mantiCorePostion = GetInputFromPlayer("Player 1, how far away from the city do you want to station the Manticore?");
int round = 1;

Console.WriteLine("----------------------------------------------------------");
do
{
    PrintMenu();
} while (mantiCoreHealth > 0);
Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");


void PrintMenu()
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {mantiCoreHealth}/10");
    int cannonDamage = GetCannonDamageForRound(round);
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} this round");
    int cannonRange = GetInputFromPlayer("Enter desired cannon range");
    string cannonResult = GetCannonResultText(cannonRange);
    Console.WriteLine(cannonResult);
    DealDamageToManitcore(cannonDamage, cannonRange);
    cityHealth--;
    round++;
    Console.WriteLine("----------------------------------------------------------");
}

int GetCannonDamageForRound(int round)
{
    if (round % 5 == 0 && round % 3 == 0)
    {
        return 10;
    }
    else if (round % 3 == 0)
    {
        return 3;
    }
    else if (round % 5 == 0)
    {
        return 5;
    }
    else 
    {
        return 1;
    }
}

int GetInputFromPlayer(string text)
{
    Console.Write($"{text}: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

void DealDamageToManitcore(int cannonDamage, int cannonRange) 
{
    if (cannonRange == mantiCorePostion)
    {
        mantiCoreHealth -= cannonDamage;
    }
}

string GetCannonResultText(int cannonRange)
{
    if (cannonRange < mantiCorePostion)
    {
        return "That round FELL SHORT of the target.";
    }
    else if (cannonRange > mantiCorePostion)
    {
        return "That round OVERSHOT the target";
    }
    else
    {
        return "That round was a DIRECT HIT!";
    }
}
