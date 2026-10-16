int energy = 69;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = false;
if (energy >= 40 && energy <= 70)
{
    isStable = true;
}

energy = 39;
Console.WriteLine($"Reactor stable: {isStable}");