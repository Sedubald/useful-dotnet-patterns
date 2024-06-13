namespace Sed.UsefulDotNetPatterns.FactoryPattern;

internal class SportyPersonFactory: IPersonFactory
{
    public Person Create(string firstName, string lastName)
    {
        return new Person
        {
            FirstName = firstName,
            LastName = lastName,
            State = "sporty"
        };
    }

    public Person Create(string firstName, string lastName, int age)
    {
        return new Person
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            State = "sporty"
        };
    }
}