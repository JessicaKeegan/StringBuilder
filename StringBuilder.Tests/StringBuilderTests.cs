namespace StringBuilder.Tests;

public class UnitTest1
{
    [Fact]
    public void GivenString_WhenCallingAppend_ThenStringGetsAppendedToTheEndOfTheState()
    {
        // Arrange
        var sb = new StringBuilder();

        // Act
        sb.Append("Test");
        sb.Append("String");

        // Assert
        Assert.Equal("TestString", sb.ToString());
    }

    [Fact]
    public void GivenCharacter_WhenCallingAppend_ThenCharacterGetsAppendedToTheEndOfTheState()
    {
        // Arrange
        var sb = new StringBuilder();

        // Act
        sb.Append("Test");
        sb.Append("String");
        sb.Append('!');

        // Assert
        Assert.Equal("TestString!", sb.ToString());
    }
}