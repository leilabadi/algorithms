using Algorithms.AlgorithmsLibrary.StringReverse;

namespace Algorithms.UnitTests.StringReverse;

public class StringReverterTests
{
    [Fact]
    public void RevertRecursive_WhenPassingAString_ShouldReturnTheRevertedString()
    {
        // Arrange
        string input = "Hello World!";
        string expected = "!dlroW olleH";

        // Act
        string actual = StringReverter.RevertRecursive(input);

        // Assert
        actual.Should().Be(expected);
    }
}