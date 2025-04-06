public class PasswordGenerator
{
    private readonly IRandom _randomNumberGenerator;
    string AlphanumericWithSpecialChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=";
    string AlphanumericCharsOnly = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public PasswordGenerator(IRandom randomNumberGenerator)
    {
        _randomNumberGenerator = randomNumberGenerator;
    }

    public string GeneratePassword(
        int minLength, int maxLength, bool shallUseSpecialCharacters)
    {
        ArgumentValidator.Validate(minLength, maxLength);
        var passwordLength = GeneratePasswordLength(minLength, maxLength);

        var charactersToBeIncluded = shallUseSpecialCharacters ?
            AlphanumericWithSpecialChars :
            AlphanumericCharsOnly;

        return GenerateRandomString(passwordLength, charactersToBeIncluded);
    }
    private int GeneratePasswordLength(int minLength, int maxLength)
    {
        return _randomNumberGenerator.GenerateNumber(minLength, maxLength + 1);
    }

    private string GenerateRandomString(
        int length, 
        string charactersToBeIncluded)
    {
        var passwordCharacters = 
            Enumerable.Repeat(charactersToBeIncluded, length)
            .Select(characters => characters[GetRandomNumberByLength(characters)]).ToArray();
        return new string(passwordCharacters);
    }

    private int GetRandomNumberByLength(string characters)
    {
        return _randomNumberGenerator.GenerateNumber(characters.Length);
    }
}

