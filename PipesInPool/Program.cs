int volumePool = int.Parse(Console.ReadLine()); // obem

int debit1 = int.Parse(Console.ReadLine()); // debit za 1 chas na truba 1
int debit2 = int.Parse(Console.ReadLine()); // debit za 1 chas na truba 2

double hoursGone = double.Parse(Console.ReadLine()); // chasove v otsustvie na rabotnika

double debit1Hour = debit1 * hoursGone; // debita za cqlto vreme v otsustvie na rabotnika(truba1)
double hourDebit2 = debit2 * hoursGone; // debita za cqloto vreme v otsustvie na rabotnika(Truba 2)

double totalDebit = debit1Hour + hourDebit2; //Obshtiqt broi debit

if (totalDebit <= volumePool)
{
    double procentZapulvane = (totalDebit / volumePool) * 100;
    double procentTruba1 = (debit1Hour / totalDebit) * 100;
    double procentTruba2 = (hourDebit2 / totalDebit) * 100;
    Console.WriteLine($"The pool is {procentZapulvane}% full. Pipe 1: {procentTruba1}%. Pipe 2: {procentTruba2:f2}%.");

}
else if (totalDebit > volumePool)
{
    double litriPoveche = (totalDebit - volumePool);
    Console.WriteLine($"For {hoursGone} hours the pool overflows with {litriPoveche:f2} liters.");
}


