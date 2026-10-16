using System.Diagnostics.CodeAnalysis;

string signal = "BLUE";
Console.WriteLine(signal);
// TODO: Lag switch med kombinerte case-labels.
switch (signal)
{
    case "RED": 
    case "CRIMSON":
    case "SCARLET":
    Console.WriteLine("Evacuate deck");
    break;
    case "AMBER":
    case "YELLOW":
    Console.WriteLine("Prepare crew");
    break;
    case "GREEN":
    Console.WriteLine("No emergency");
    break;
    default: Console.WriteLine("Unknown signal");
    break;
}
