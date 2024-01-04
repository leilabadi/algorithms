namespace Algorithms.AlgorithmsLibrary.Fibonacci;

public class FibonacciRecursive : Fibonacci
{
    public override int Generate(int n)
    {
        Counter++;

        switch (n)
        {
            case <= 1:
                return n;
            default:
                return Generate(n - 2) + Generate(n - 1);
        };
    }
}