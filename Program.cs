// See https://aka.ms/new-console-template for more information



Console.WriteLine("Welcome to Money Maker!");

Console.WriteLine("Enter an amount to convert to coins:");
string amount  = Console.ReadLine();

double convertedAmount = Convert.ToDouble(amount);
Console.WriteLine($"Type your amount again, {convertedAmount} cents is equal to:");
string example  = Console.ReadLine();

int goldValue = 10;
int silverValue = 5;
int bronzeValue = 1;

double goldCoins = Math.Floor(convertedAmount/goldValue);
double goldLeftOver = goldCoins % goldValue;
Console.WriteLine($"{goldLeftOver} Gold coin");

double silverCoins = Math.Floor(goldLeftOver/silverValue);
double silverLeftOver = silverCoins % silverValue;
Console.WriteLine($"{silverLeftOver} Silver coin");

double bronzeCoins = Math.Floor(silverLeftOver/bronzeValue);
double bronzeLeftOver = bronzeCoins % bronzeValue;
Console.WriteLine($"{bronzeLeftOver} Silver coin");