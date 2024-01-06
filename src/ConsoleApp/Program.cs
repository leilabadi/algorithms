// See https://aka.ms/new-console-template for more information

using Algorithms.AlgorithmsLibrary.Fibonacci;
using Algorithms.AlgorithmsLibrary.Sorting;
using Algorithms.ConsoleApp;

SortTest();

static void SortTest()
{
    int[] array;

    array = [99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0];
    SortAndPrint(array, new BubbleSort<int>());
    SortAndPrint(array, new SelectionSort<int>());
    SortAndPrint(array, new InsertionSort<int>());
    SortAndPrint(array, new OptimizedInsertionSort<int>());

    array = [0, 1, 2, 4, 5, 6, 44, 63, 87, 99, 283];
    SortAndPrint(array, new BubbleSort<int>());
    SortAndPrint(array, new SelectionSort<int>());
    SortAndPrint(array, new InsertionSort<int>());
    SortAndPrint(array, new OptimizedInsertionSort<int>());
}

static void SortAndPrint(int[] array, SortBase<int> sort)
{
    array = array.ToArray();
    string algorithmName = sort.GetType().Name;
    algorithmName = algorithmName[..^2];

    int[] sortedArray = sort.Sort(array);

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Sort: {algorithmName} - Compare Count: {sort.Counter}");
    //Console.WriteLine(ArrayPrinter.Print(array));
    Console.WriteLine(ArrayPrinter.Print(sortedArray));
}

static void FibonacciTest()
{
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
    }
}