namespace Algorithms.UnitTests.Common;

public class TestBase
{
    protected int[] GetRandomArray(int length, int min, int max)
    {
        var faker = new Faker();
        return Enumerable.Range(1, length).Select(_ => faker.Random.Int(min, max)).ToArray();
    }
}