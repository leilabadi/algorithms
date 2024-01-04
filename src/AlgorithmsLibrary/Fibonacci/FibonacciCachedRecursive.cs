namespace Algorithms.AlgorithmsLibrary.Fibonacci;

public class FibonacciCachedRecursive : Fibonacci
{
    private readonly Dictionary<int, int> _cache = new();

    public FibonacciCachedRecursive()
    {
        _cache.Add(0, 0);
        _cache.Add(1, 1);
    }

    public override int Generate(int n)
    {
        if (_cache.ContainsKey(n))
        {
            return _cache[n];
        }

        Counter++;

        switch (n)
        {
            case <= 1:
                return n;
            default:
                var a = Generate(n - 2);
                _cache[n - 2] = a;
                var b = Generate(n - 1);
                _cache[n - 1] = b;
                return a + b;
        };
    }
}