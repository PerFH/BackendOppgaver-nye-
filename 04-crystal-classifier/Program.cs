int energy = 130;
string classification = "";
if (energy < 20)
{
    classification = "Dormant";
}
else if (energy < 50)
{
    classification = "Stable";
}
else if (energy < 80)
{
    classification = "Unstable";
}
else
{
    classification = "Critical";
}

Console.WriteLine($"Classification: {classification}");

//Test minst `0`, `19`, `20`, `49`, `50`, `79`, `80`, `130`.

