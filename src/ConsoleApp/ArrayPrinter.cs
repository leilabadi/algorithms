using System.Text;

namespace Algorithms.ConsoleApp;

public class ArrayPrinter
{
    public static string Print<T>(T[] array)
    {
        StringBuilder sb = new();
        sb.Append("[");
        for (int i = 0; i < array.Length; i++)
        {
            sb.Append(array[i]).Append(", ");
        }

        if (sb.Length > 2)
        {
            sb.Remove(sb.Length - 2, 2);
        }

        sb.Append("]");

        return sb.ToString();
    }
}