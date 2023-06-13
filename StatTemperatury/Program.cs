// See https://aka.ms/new-console-template for more information
using StatTemperatury;

Console.WriteLine("Statystyki temperatury");

var temperatura = new TemperaturyInFile("10" ,"15");

while (true)
{
    Console.WriteLine("Podaj temperature, aby zakonczyc q");
    var input = Console.ReadLine();
    if(input == "q")
   
    {
        break;
    }
    try
    {
        temperatura.AddTemp(input);

    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception registred: {e.Message}");
    }
}
var Statistics = temperatura.GetStatistics();
Console.WriteLine($"Suma  { Statistics.Sum}");
Console.WriteLine($"Min  {Statistics.Min}");
Console.WriteLine($"Maximum  {Statistics.Max}");
Console.WriteLine($"Average  {Statistics.average}");


