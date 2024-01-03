namespace Algorithms.Fibonacci;

public abstract class Fibonacci
{
    public int Counter { get; protected set; }

    public abstract int Generate(int n);
}