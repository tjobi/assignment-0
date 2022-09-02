namespace MyApp;

public class LeapYearTooEarlyException : Exception
{
    public LeapYearTooEarlyException(string? message = null)
    : base(message ?? "Invalid year - leap years only apply to years following 1582")
    {
    }
}