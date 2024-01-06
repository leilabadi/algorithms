namespace Algorithms.AlgorithmsLibrary.Sorting;

public abstract class SortBase<T>
{
    public int Counter { get; protected set; }

    protected void Swap(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}