namespace Algorithms.AlgorithmsLibrary.Sorting;

public abstract class SortBase<T>
{
    public int Counter { get; protected set; }

    public abstract T[] Sort(T[] array);

    protected void Swap(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    protected void ShiftRight(T[] array, int startIndex, int endIndex)
    {
        for (int i = endIndex; i > startIndex; i--)
        {
            array[i] = array[i - 1];
        }
    }
}