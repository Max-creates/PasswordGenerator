PasswordGenerator passwordGenerator = new PasswordGenerator(
    new RandomNumberGenerator());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(passwordGenerator.GeneratePassword(5, 10, true));
}
Console.ReadKey();