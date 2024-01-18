int countWeekEnd = int.Parse(Console.ReadLine());

int minutesWeekEnd = countWeekEnd * 127;
int workingDays = (365 - countWeekEnd) * 63;
int totalPlayTime = minutesWeekEnd + workingDays;

int norma = 30000;

if (norma >= totalPlayTime)
{
    int diffNorma = norma - totalPlayTime;
    int hours = diffNorma / 60;
    int minutes = diffNorma % 60;

    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
}
else
{
    int diffNorma = totalPlayTime - norma;
    int hours = diffNorma / 60;
    int minute = diffNorma % 60;

    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minute} minutes more for play");
}