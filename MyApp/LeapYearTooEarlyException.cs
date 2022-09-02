namespace MyApp;

public class LeapYearTooEarlyException : Exception
{
    private string message;
    public LeapYearTooEarlyException(string? message = null)
    {
        this.message = message ?? "Invalid year - leap years only apply to years following 1582";
    }
}