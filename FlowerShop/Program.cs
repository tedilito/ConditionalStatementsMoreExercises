int countMagnolii = int.Parse(Console.ReadLine());
int countZumbul = int.Parse(Console.ReadLine());    
int countRozi = int.Parse(Console.ReadLine());
int countCactus = int.Parse(Console.ReadLine());
double priceGift = double.Parse(Console.ReadLine());

double priceMagnoliii = countMagnolii * 3.25;
double priceZumbuli = countZumbul * 4.00;
double priceRozi = countRozi * 3.50;
double priceCactus = countCactus * 8.00;

double totalPrice = priceMagnoliii + priceZumbuli + priceRozi + priceCactus;
double tax = totalPrice * 0.05;

double totalSum = totalPrice - tax;

if (totalSum >= priceGift)
{
    double moneyLeft =Math.Floor(totalSum - priceGift);
    Console.WriteLine($"She is left with {moneyLeft} leva.");
}
else if (priceGift > totalSum)
{
    double neededMoney = Math.Ceiling(priceGift - totalSum);
    Console.WriteLine($"She will have to borrow {neededMoney} leva.");
}