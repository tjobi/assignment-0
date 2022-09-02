namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Main_when_yay()
    {
        // Arrange
        /*var data = String.Join("\n", new[]
        {
            "1920", "2000", "1900", "2012"
        });*/
        const string YEAR = "1920";
        using var reader = new StringReader(YEAR);
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(MyApp));
        program.EntryPoint?.Invoke(null,new[]{Array.Empty<string>()});

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }


    [Fact]
    public void Main_when_nay()
    {
        // Arrange
        const string YEAR = "1900";
        using var reader = new StringReader(YEAR);
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(MyApp));
        program.EntryPoint?.Invoke(null,new[]{Array.Empty<string>()});

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Main_with_input_not_convertible_to_int()
    {
        //Arrange
        const string INPUT = "blabla";
        using var reader = new StringReader(INPUT);
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(MyApp));
        program.EntryPoint?.Invoke(null,new[]{Array.Empty<string>()});

        //Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        output.Should().Be("Error: input a number.");
    }
}