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

    [Fact]
    public void Given_ContainedSubstring_When_CallingFirstIndexOf_Then_ReturnsTheIndexOfTheContainedSubstring()
    {
        // Arrange
        var sb = new StringBuilder();

        // Act
        sb.Append("Test");
        sb.Append("String");

        // Assert
        Assert.Equal(4, sb.FirstIndexOf("Str"));
    }

    [Fact]
    public void Given_UncontainedSubstring_When_CallingFirstIndexOf_Then_ReturnsMinus1()
    {
        // Arrange
        var sb = new StringBuilder();

        // Act
        sb.Append("Test");
        sb.Append("String");

        // Assert
        Assert.Equal(-1, sb.FirstIndexOf("Abv"));
    }

    [Fact]
    public void When_CallingReverse_Then_NewStringBuilderGetsReturnedWithReversedState()
    {
        // Arrange
        var sb = new StringBuilder();

        // Act
        sb.Append("Test");
        var reversed = sb.Reverse();

        // Assert
        Assert.Equal("tseT", reversed.ToString());
    }
}