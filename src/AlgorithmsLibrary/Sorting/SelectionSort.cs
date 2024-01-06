namespace Algorithms.AlgorithmsLibrary.Sorting;

public class SelectionSort<T> : SortBase<T> where T : IComparable<T>
{
    public override T[] Sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                Counter++;
                if (array[j].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swap(array, i, minIndex);
            }
        }

        return array;
    }
}