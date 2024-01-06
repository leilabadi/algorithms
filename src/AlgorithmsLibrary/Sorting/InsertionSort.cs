namespace Algorithms.AlgorithmsLibrary.Sorting;

public class InsertionSort<T> : SortBase<T> where T : IComparable<T>
{
    public override T[] Sort(T[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Counter++;
                if (array[j].CompareTo(array[i]) >= 0)
                {
                    T temp = array[i];
                    ShiftRight(array, j, i);
                    array[j] = temp;
                    break;
                }
            }
        }

        return array;
    }
}