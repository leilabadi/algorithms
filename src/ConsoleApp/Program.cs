// See https://aka.ms/new-console-template for more information

/*using Algorithms.AlgorithmsLibrary.Fibonacci;

Fibonacci fib;

Console.WriteLine($"n   Fibonacci Counter");
Console.WriteLine();

fib = new FibonacciIterative();
Console.WriteLine();
Console.WriteLine("Iterative");
Console.WriteLine("---------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}\t{fib.Generate(i)}\t{fib.Counter}");
}

fib = new FibonacciRecursive();
Console.WriteLine();
Console.WriteLine("Recursive");
Console.WriteLine("---------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}\t{fib.Generate(i)}\t{fib.Counter}");
}

fib = new FibonacciCachedRecursive();
Console.WriteLine();
Console.WriteLine("Cached Recursive");
Console.WriteLine("---------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}\t{fib.Generate(i)}\t{fib.Counter}");
}*/

/*using Algorithms.AlgorithmsLibrary.StringReverse;

Console.WriteLine(StringReverter.RevertRecursive("Hello World!"));
Console.WriteLine(StringReverter.RevertIterative("Hello World!"));*/

using Algorithms.AlgorithmsLibrary.Sorting;
using Algorithms.ConsoleApp;

int[] array = [99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0];
Console.WriteLine(ArrayPrinter.Print(array));

BubbleSort<int> bubbleSort = new();
var sortedArray = bubbleSort.Sort(array);
Console.WriteLine(ArrayPrinter.Print(sortedArray));

Console.WriteLine($"Compare count: {bubbleSort.Counter}");