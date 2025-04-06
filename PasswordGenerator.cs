public class PasswordGenerator
{
    private readonly IRandomNumberGenerator _randomNumberGenerator;
    const string AlphaDigitAndSpecialCharactersIncluded = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=";
    const string AlphaDigitCharactersOnly = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public PasswordGenerator(IRandomNumberGenerator randomNumberGenerator)
    {
        _randomNumberGenerator = randomNumberGenerator;
    }

    public string GeneratePassword(
        int left, int right, bool useSpecialCharacters)
    {
        ArgumentValidator.IsLeftArgumentValid(left);
        ArgumentValidator.IsRightArgumentValid(right, left);
        var passwordLength = _randomNumberGenerator.GenerateNumber(left, right + 1);

        //generate random string
        var charsToUseForPasswordGeneration = useSpecialCharacters ?
            AlphaDigitAndSpecialCharactersIncluded :
            AlphaDigitCharactersOnly;

        return new string(Enumerable
            .Repeat(charsToUseForPasswordGeneration, (int)passwordLength)
            .Select(charsToUseForPasswordGeneration => charsToUseForPasswordGeneration[
                GenerateRandomNumberBasedOnCharsLength(charsToUseForPasswordGeneration)])
            .ToArray());
    }

    private int GenerateRandomNumberBasedOnCharsLength(string chars)
    {
        return _randomNumberGenerator.GenerateNumber(chars.Length);
    }
}

