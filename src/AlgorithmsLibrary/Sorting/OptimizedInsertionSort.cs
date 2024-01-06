namespace Algorithms.AlgorithmsLibrary.Sorting;

public class OptimizedInsertionSort<T> : SortBase<T> where T : IComparable<T>
{
    public override T[] Sort(T[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            bool needsShift = false;
            int j;
            for (j = i - 1; j >= 0; j--)
            {
                Counter++;
                if (array[j].CompareTo(array[i]) <= 0)
                {
                    break;
                }
                else
                {
                    needsShift = true;
                }
            }

            if (needsShift)
            {
                j++;
                T temp = array[i];
                ShiftRight(array, j, i);
                array[j] = temp;
            }
        }

        return array;
    }
}