namespace Algorithms.AlgorithmsLibrary.Sorting;

public class MergeSort<T> : SortBase<T> where T : IComparable<T>
{
    public override T[] Sort(T[] array)
    {
        return SortInternal(array, 0, array.Length - 1);
    }

    private T[] SortInternal(T[] array, int startIndex, int endIndex)
    {
        if (startIndex == endIndex)
        {
            return [array[startIndex]];
        }

        int middle = (startIndex + endIndex) / 2;

        T[] leftArray = SortInternal(array, startIndex, middle);
        T[] rightArray = SortInternal(array, middle + 1, endIndex);

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = 0;
        T[] mergedArray = new T[endIndex - startIndex + 1];
        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            Counter++;
            if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) < 0)
            {
                mergedArray[mergedIndex] = leftArray[leftIndex++];
            }
            else
            {
                mergedArray[mergedIndex] = rightArray[rightIndex++];
            }
            mergedIndex++;
        }

        for (int k = leftIndex; k < leftArray.Length; k++)
        {
            mergedArray[mergedIndex++] = leftArray[k];
        }

        for (int k = rightIndex; k < rightArray.Length; k++)
        {
            mergedArray[mergedIndex++] = rightArray[k];
        }

        return mergedArray;
    }
}