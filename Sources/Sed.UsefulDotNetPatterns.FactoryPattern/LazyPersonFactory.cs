namespace Sed.UsefulDotNetPatterns.FactoryPattern;

internal class LazyPersonFactory : IPersonFactory
{
    public Person Create(string firstName, string lastName)
    {
        return new Person
        {
            FirstName = firstName,
            LastName = lastName,
            State = "lazy"
        };
    }

    public Person Create(string firstName, string lastName, int age)
    {
        return new Person
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            State = "lazy"
        };
    }
}