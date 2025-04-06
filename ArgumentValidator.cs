
public class ArgumentValidator
{
    public static void IsLeftArgumentValid(int left)
    {
        if(left < 1)
        {
            throw new ArgumentOutOfRangeException(
                $"leftRange must be greater than 0");
        }
    }

    public static void IsRightArgumentValid(int right, int left)
    {
        if (right < left)
        {
            throw new ArgumentOutOfRangeException(
                $"leftRange must be smaller than rightRange");
        }
    }
}

