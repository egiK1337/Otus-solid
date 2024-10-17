using Otus_solid.GameInterfaces;

// Реализация генератора случайных чисел
public class RandomNumberGenerator : INumberGenerator
{
    private Random _random = new Random();

    public int Generate(int range)
    {
        return _random.Next(1, range + 1);
    }
}
