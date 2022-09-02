namespace MyApp.Tests;

public class LeapCalculatorTests
{
    [Fact]
    public void IsLeapYear_given_every_fourth()
    {
        //Arrange
        var calculator = new LeapCalculator();
        const int YEAR = 2012;

        //Act
        var result = calculator.IsLeapYear(YEAR);

        //Assert
        result.Should().Be(true);
    }

    [Fact]
    public void IsLeapYear_given_divisble_by_100()
    {
        var calculator = new LeapCalculator();
        const int YEAR = 1900;

        var result = calculator.IsLeapYear(YEAR);

        result.Should().Be(false);
    }

    [Fact]
    public void IsLeapYear_given_centennial_year()
    {
        var calculator = new LeapCalculator();
        const int YEAR = 1600;

        var result = calculator.IsLeapYear(YEAR);

        result.Should().Be(true);
    }
}