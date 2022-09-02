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
}