string typeFuel = Console.ReadLine().ToLower();
int leeters = int.Parse(Console.ReadLine());

if (typeFuel == "gas" )
{
    if (leeters < 25)
    {
        Console.WriteLine($"Fill your tank with {typeFuel}!");
    }
    else if (leeters >= 25)
    {
        Console.WriteLine($"You have enough {typeFuel}.");
    }

}
else if (typeFuel == "diesel")
{
    if (leeters < 25)
    {
        Console.WriteLine($"Fill your tank with {typeFuel}!");
    }
    else if (leeters >= 25)
    {
        Console.WriteLine($"You have enough {typeFuel}.");
    }
}
else if (typeFuel =="gasoline")
{
    if (leeters < 25)
    {
        Console.WriteLine($"Fill your tank with {typeFuel}!");
    }
    else if (leeters >= 25)
    {
        Console.WriteLine($"You have enough {typeFuel}.");
    }
}
else 
{
    Console.WriteLine("Invalid fuel!");
}
