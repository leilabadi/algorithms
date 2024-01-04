using System.Text;

namespace Algorithms.AlgorithmsLibrary.StringReverse;

public static class StringReverter
{
    public static string RevertRecursive(string value)
    {
        return RevertInternal(value, value.Length / 2);
    }

    private static string RevertInternal(string value, int splintIndex)
    {
        string partOne = value.Substring(0, splintIndex);
        string partTwo = value.Substring(splintIndex);
        if (partOne.Length > 1)
        {
            partOne = RevertInternal(partOne, partOne.Length / 2);
        }
        if (partTwo.Length > 1)
        {
            partTwo = RevertInternal(partTwo, partTwo.Length / 2);
        }
        return partTwo + partOne;
    }

    public static string RevertIterative(string value)
    {
        StringBuilder sb = new();
        for (int i = value.Length - 1; i >= 0; i--)
        {
            sb.Append(value[i]);
        }
        return sb.ToString();
    }

    public static string RevertUsingStack(string value)
    {
        Stack<char> stack = new();
        foreach (var c in value)
        {
            stack.Push(c);
        }

        StringBuilder sb = new();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }
}