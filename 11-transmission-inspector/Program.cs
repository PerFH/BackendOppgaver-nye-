string transmission = "###";
int interferenceCount = 0;

// TODO: Bruk foreach over transmission.
foreach (char letter in transmission)
    if (letter == '#')
    {
        interferenceCount ++;
    }

Console.WriteLine($"Interference markers: {interferenceCount}");
