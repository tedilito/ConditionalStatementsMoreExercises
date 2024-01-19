int km = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

if (km < 20)
{
    if (timeOfDay == "day")
    {
        double TaxiDay = 0.70 + (km * 0.79);
        Console.WriteLine($"{TaxiDay:f2}");
    }
    else if (timeOfDay == "night")
    {
        double taxyNight = 0.70 + (km * 0.90);
        Console.WriteLine($"{taxyNight:f2}");
    }
}
else if (km >= 100)
{
    double train = km * 0.06;
    Console.WriteLine($"{train:f2}");
}
else if (km >= 20)
{
    double bus = km * 0.09;
    Console.WriteLine($"{bus:f2}");
}