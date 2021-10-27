Console.WriteLine("How many eggs have the sisters collected today?");
int eggsCollected = Convert.ToInt32(Console.ReadLine());

if (eggsCollected % 2 == 0)
{
    Console.WriteLine($"The sisters splits the eggs evenly and recives {eggsCollected / 4} eggs each");
}
else if (eggsCollected % 2 == 1)
{
    int sisterEggs = eggsCollected / 4;
    int bearEggs = eggsCollected % 4;
    Console.WriteLine($"The sisters each recive {sisterEggs} and the duckbear recive the remaining {bearEggs}");
}