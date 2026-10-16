int cargoWeight = 801;
int maxWeight = 800;
int containerCount = 0;
int expectedContainers = 5;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = false;
if (cargoWeight > maxWeight)
{
    isOverweight = true;
}
bool isExactlyAtLimit = false;
if (cargoWeight == maxWeight)
{
    isExactlyAtLimit = true;
} 
bool hasContainers = false;
if (containerCount > 0)
{
    hasContainers = true;
}
bool countDiffersFromExpected = false;
if (containerCount != expectedContainers)
{
    countDiffersFromExpected = true;
}

Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
