namespace Sed.UsefulDotNetPatterns.BuilderPattern;

internal class Director
{
    public void ConstructAndPrintJane(PersonBuilder builder)
    {
        builder
            .WithFirstName("Jane")
            .WithLastName("Doe")
            .WithAge(22);

        builder.PrintPersonToConsole();
    }

    public void ConstructAndPrintJohn(PersonBuilder builder)
    {
        builder
            .WithFirstName("John")
            .WithLastName("Doe")
            .WithAge(33);

        builder.PrintPersonToConsole();
    }
}