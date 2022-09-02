namespace MyApp;

public class LeapCalculator
{
    public LeapCalculator()
    {

    }

    public bool IsLeapYear(int year)
    {
        if(year < 1582) throw new LeapYearTooEarlyException();
        if(year % 100 == 0) return year % 400 == 0;
        return year % 4 == 0;
    }
}