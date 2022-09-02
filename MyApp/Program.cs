using MyApp;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var calculator = new LeapCalculator();

for (string? s = Console.ReadLine(); s != null; s = Console.ReadLine())
{
    try
    {
        var year = int.Parse(s);
        var result = calculator.IsLeapYear(year);

        Console.WriteLine(result ? "yay" : "nay");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Error: input a number.");
    }
    catch (LeapYearTooEarlyException e)
    {
        Console.WriteLine(e.Message);
    }
}