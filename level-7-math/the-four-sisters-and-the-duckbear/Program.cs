int chocoloateEggCount;
Console.WriteLine("How many chocolate eggs were gathered today?");
chocoloateEggCount = Convert.ToInt32(Console.ReadLine());

double eggsToSisters = chocoloateEggCount / 4;
int eggsToDuckbear = chocoloateEggCount % 4;
Console.WriteLine($"The sisters get {eggsToSisters} eggs and the duckbear gets {eggsToDuckbear}");
