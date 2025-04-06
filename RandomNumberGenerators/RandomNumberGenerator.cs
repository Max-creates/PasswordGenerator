
public class RandomNumberGenerator : IRandom
{
    private readonly Random _random = new Random();
    public int GenerateNumber(int maxValue)
    {
        return _random.Next(maxValue);
    }

    public int GenerateNumber(int minValue, int maxValue)
    {
        return _random.Next(minValue, maxValue);
    }
}

