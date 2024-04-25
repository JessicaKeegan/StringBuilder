namespace StringBuilder.Tests;

public class StringBuilderTests
{
    [Fact]
    public void Given_String_When_CallingAppend_Then_StringGetsAppendedToTheEndOfTheState()
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
    public void Given_Character_When_CallingAppend_Then_CharacterGetsAppendedToTheEndOfTheState()
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


    [Fact]
    public void Given_String_When_CallingAppendLine_Then_CharacterGetsAppendedToTheEndOfTheStateWithANewLine()
    {
        // Arrange
        var sb = new StringBuilder();

        // Act
        sb.Append("Test");
        sb.Append("String");
        sb.Append('!');
        sb.AppendLine("Some extra content");
        sb.AppendLine("And another new line");

        // Assert
        Assert.Equal("TestString!\r\nSome extra content\r\nAnd another new line", sb.ToString());
    }
}