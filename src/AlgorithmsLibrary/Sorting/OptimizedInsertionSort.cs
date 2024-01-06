namespace Algorithms.AlgorithmsLibrary.Sorting;

public class OptimizedInsertionSort<T> : SortBase<T> where T : IComparable<T>
{
    public override T[] Sort(T[] array)
    {
        return SortInternalV1(array);
    }

    public T[] SortInternalV1(T[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            T target = array[i];
            int j = i - 1;

            int innerCounter = 0;
            while (j >= 0 && array[j].CompareTo(target) > 0)
            {
                innerCounter++;
                array[j + 1] = array[j];
                j--;
            }
            Counter += innerCounter != 0 ? innerCounter : 1;

            if (j + 1 != i)
            {
                array[j + 1] = target;
            }
        }

        return array;
    }

    private T[] SortInternalV2(T[] array)
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