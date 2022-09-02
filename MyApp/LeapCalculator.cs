namespace MyApp;

public class LeapCalculator
{
    public LeapCalculator()
    {

    }

    public bool IsLeapYear(int year)
    {
        return year % 4 == 0;
    }
}