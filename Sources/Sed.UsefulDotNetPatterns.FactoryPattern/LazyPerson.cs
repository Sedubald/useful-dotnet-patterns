namespace Sed.UsefulDotNetPatterns.FactoryPattern;

internal class LazyPerson : IPerson
{
    public required string FirstName { get; set; }

    public string? LastName { get; set; }

    public int Age { get; set; } = -1;

    public void SayHello()
    {
        var lastNameText = string.IsNullOrEmpty(LastName) ? string.Empty : $" {LastName}";
        var ageText = Age.Equals(-1) ? string.Empty : $", I am {Age} years old";
        Console.WriteLine($"Hey, I am {FirstName}{lastNameText}{ageText} and I am lazy!");
    }
}