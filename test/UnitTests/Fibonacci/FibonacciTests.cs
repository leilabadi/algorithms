using Algorithms.AlgorithmsLibrary.Fibonacci;

namespace Algorithms.UnitTests.Fibonacci;

public class FibonacciTests
{
    [Theory]
    [InlineData(FibonacciAlgorithm.Iterative)]
    [InlineData(FibonacciAlgorithm.Recursive)]
    [InlineData(FibonacciAlgorithm.CachedRecursive)]
    public void Generate_WhenPassingANumber_ShouldReturnTheFibonacciNumber(FibonacciAlgorithm algorithm)
    {
        // Arrange
        int number = 10;
        int expected = 55;

        AlgorithmsLibrary.Fibonacci.Fibonacci sut = GetFibonacciAlgorithm(algorithm);

        // Act
        int result = sut.Generate(number);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(FibonacciAlgorithm.Iterative)]
    [InlineData(FibonacciAlgorithm.Recursive)]
    [InlineData(FibonacciAlgorithm.CachedRecursive)]
    public void Generate_WhenPassing0To10_ShouldReturnTheCorrectFibonacciSequence(FibonacciAlgorithm algorithm)
    {
        // Arrange
        int[] expected = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];

        AlgorithmsLibrary.Fibonacci.Fibonacci sut = GetFibonacciAlgorithm(algorithm);

        // Act
        int[] result = new int[10];
        for (int i = 0; i < 10; i++)
        {
            result[i] = sut.Generate(i);
        }

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    private AlgorithmsLibrary.Fibonacci.Fibonacci GetFibonacciAlgorithm(FibonacciAlgorithm algorithm)
    {
        return algorithm switch
        {
            FibonacciAlgorithm.Iterative => new FibonacciIterative(),
            FibonacciAlgorithm.Recursive => new FibonacciRecursive(),
            FibonacciAlgorithm.CachedRecursive => new FibonacciCachedRecursive(),
            _ => throw new NotImplementedException(),
        };
    }
}