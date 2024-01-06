namespace Algorithms.AlgorithmsLibrary.Sorting;

public class BubbleSort<T> : SortBase<T> where T : IComparable<T>
{
    public override T[] Sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool isSorted = true;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                Counter++;
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    isSorted = false;
                    Swap(array, j, j + 1);
                }
            }

            if (isSorted)
            {
                break;
            }
        }
        return array;
    }
}