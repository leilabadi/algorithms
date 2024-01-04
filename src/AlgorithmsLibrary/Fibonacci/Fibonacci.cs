namespace Algorithms.AlgorithmsLibrary.Fibonacci;

public abstract class Fibonacci
{
    public int Counter { get; protected set; }

    public abstract int Generate(int n);
}