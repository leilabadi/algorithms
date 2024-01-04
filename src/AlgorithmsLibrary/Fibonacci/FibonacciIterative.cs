namespace Algorithms.AlgorithmsLibrary.Fibonacci;

public class FibonacciIterative : Fibonacci
{
    public override int Generate(int n)
    {
        if (n <= 1) return n;

        int a = 1;
        int b = 1;
        int sum;

        for (Counter = 0; Counter < n - 2; Counter++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return b;
    }
}