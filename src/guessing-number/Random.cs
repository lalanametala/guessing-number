using System.Security.Cryptography;

namespace guessing_number;

public interface IRandomGenerator
{
    int GetInt(int min, int max);
}

public class DefaultRandom : IRandomGenerator
{
    public int GetInt(int min, int max)
    {
        return RandomNumberGenerator.GetInt32(min, max);   
    }
}