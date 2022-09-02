namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Main_when_no_args()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(MyApp));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }
}