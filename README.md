
# 🔐 Password Generator

A simple and customizable command-line password generator written in C#.  
Easily generate secure passwords with different configurations, such as length, use of digits, symbols, and case sensitivity.

## 📦 Features

- ✅ Generate random passwords with desired length
- 🔢 Optionally include digits
- 🔠 Optionally include uppercase/lowercase letters
- 🔣 Optionally include symbols
- 🎲 Uses pluggable random number generator interface for flexibility and testability
- 🧪 Basic input validation for CLI arguments

## 🚀 Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download) or later

### Build

Clone the repository and build the project:

```bash
git clone https://github.com/Max-creates/PasswordGenerator.git
cd PasswordGenerator
dotnet build
```

### Run

Use the following command to generate a password:

```bash
dotnet run -- [length] [includeDigits] [includeLowercase] [includeUppercase] [includeSymbols]
```

**Example:**

```bash
dotnet run -- 16 true true true true
```

Generates a 16-character password with digits, lowercase, uppercase, and symbols.

## 🧱 Project Structure

```
PasswordGenerator/
├── ArgumentValidator.cs       # Handles input argument validation
├── IRandomNumberGenerator.cs  # Interface for custom RNG
├── PasswordGenerator.cs       # Core password generation logic
├── Program.cs                 # Entry point with CLI parsing
└── RandomNumberGenerators/    # Contains implementations of RNG
    └── SystemRandomNumberGenerator.cs
```

## 🛠 Extensibility

You can easily extend the project by implementing your own `IRandomNumberGenerator`, e.g., using cryptographic RNG.

```csharp
public class MySecureRandom : IRandomNumberGenerator
{
    public int Next(int max) { ... }
}
```

Then inject it into the `PasswordGenerator` constructor.
