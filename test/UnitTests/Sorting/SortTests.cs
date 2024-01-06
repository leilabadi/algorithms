using Algorithms.AlgorithmsLibrary.Sorting;
using Algorithms.UnitTests.Common;

namespace Algorithms.UnitTests.Sorting;

public class SortTests : TestBase
{
    [Theory]
    [InlineData(SortAlgorithms.BubbleSort)]
    [InlineData(SortAlgorithms.SelectionSort)]
    [InlineData(SortAlgorithms.InsertionSort)]
    [InlineData(SortAlgorithms.OptimizedInsertionSort)]
    public void Sort_WhenPassingARandomArray_ShouldReturnAnAcsendingOrderedArray(SortAlgorithms algorithm)
    {
        // Arrange
        var array = GetRandomArray(10, 0, 100);

        var sut = GetSortAlgorithm(algorithm);

        // Act
        var sortedArray = sut.Sort(array);

        // Assert
        sortedArray.Should().BeInAscendingOrder();
    }

    [Theory]
    [InlineData(SortAlgorithms.BubbleSort)]
    [InlineData(SortAlgorithms.SelectionSort)]
    [InlineData(SortAlgorithms.InsertionSort)]
    [InlineData(SortAlgorithms.OptimizedInsertionSort)]
    public void Sort_WhenPassingARandomAcsendingOrderedArray_ShouldReturnAnAcsendingOrderedArray(SortAlgorithms algorithm)
    {
        // Arrange
        var array = GetRandomArray(10, 0, 100).Order().ToArray();

        var sut = GetSortAlgorithm(algorithm);

        // Act
        var sortedArray = sut.Sort(array);

        // Assert
        sortedArray.Should().BeInAscendingOrder();
    }

    [Theory]
    [InlineData(SortAlgorithms.BubbleSort)]
    [InlineData(SortAlgorithms.SelectionSort)]
    [InlineData(SortAlgorithms.InsertionSort)]
    [InlineData(SortAlgorithms.OptimizedInsertionSort)]
    public void Sort_WhenPassingARandomDescendingOrderedArray_ShouldReturnAnAcsendingOrderedArray(SortAlgorithms algorithm)
    {
        // Arrange
        var array = GetRandomArray(10, 0, 100).OrderDescending().ToArray();

        var sut = GetSortAlgorithm(algorithm);

        // Act
        var sortedArray = sut.Sort(array);

        // Assert
        sortedArray.Should().BeInAscendingOrder();
    }

    [Theory]
    [InlineData(SortAlgorithms.BubbleSort)]
    [InlineData(SortAlgorithms.SelectionSort)]
    [InlineData(SortAlgorithms.InsertionSort)]
    [InlineData(SortAlgorithms.OptimizedInsertionSort)]
    public void Sort_WhenPassingAnArrayScenario1_ShouldReturnAnAcsendingOrderedArray(SortAlgorithms algorithm)
    {
        // Arrange
        int[] array = [99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0];

        var sut = GetSortAlgorithm(algorithm);

        // Act
        var sortedArray = sut.Sort(array);

        // Assert
        sortedArray.Should().BeInAscendingOrder();
    }

    private SortBase<int> GetSortAlgorithm(SortAlgorithms algorithm)
    {
        return algorithm switch
        {
            SortAlgorithms.BubbleSort => new BubbleSort<int>(),
            SortAlgorithms.SelectionSort => new SelectionSort<int>(),
            SortAlgorithms.InsertionSort => new InsertionSort<int>(),
            SortAlgorithms.OptimizedInsertionSort => new OptimizedInsertionSort<int>(),
            _ => throw new ArgumentOutOfRangeException(nameof(algorithm), algorithm, null)
        };
    }
}