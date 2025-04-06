
public class RandomNumberGenerator : IRandomNumberGenerator
{
    private readonly Random rand = new Random();
    public int GenerateNumber(int maxValue)
    {
        return rand.Next(maxValue);
    }

    public int GenerateNumber(int minValue, int maxValue)
    {
        return rand.Next(minValue, maxValue);
    }
}

