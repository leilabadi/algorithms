namespace Algorithms.AlgorithmsLibrary.Sorting;

public class SelectionSort<T> : SortBase<T> where T : IComparable<T>
{
    public T[] Sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            T min = array[i];
            for (int j = i; j < array.Length; j++)
            {
                Counter++;
                if (array[j].CompareTo(min) < 0)
                {
                    minIndex = j;
                    min = array[j];
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