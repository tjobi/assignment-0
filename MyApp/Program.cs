using MyApp;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

for (string s = Console.ReadLine(); s != null; s = Console.ReadLine())
{
    var year = int.Parse(s);
    var result = new LeapCalculator().IsLeapYear(year);


    Console.WriteLine(result ? "yay":"nay");
}