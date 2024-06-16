namespace Sed.UsefulDotNetPatterns.FactoryPattern;

using System.ComponentModel;

internal class PersonFactory : IPersonFactory
{
    public IPerson Create(PersonType type, string firstName, string lastName)
    {
        IPerson person = type switch
        {
            PersonType.Lazy => new LazyPerson { FirstName = firstName, LastName = lastName },
            PersonType.Sporty => new SportyPerson { FirstName = firstName, LastName = lastName },
            _ => throw new InvalidEnumArgumentException(nameof(type), (int)type, type.GetType())
        };

        return person;
    }

    public IPerson Create(PersonType type, string firstName, string lastName, int age)
    {
        IPerson person = type switch
        {
            PersonType.Lazy => new LazyPerson { FirstName = firstName, LastName = lastName, Age = age },
            PersonType.Sporty => new SportyPerson { FirstName = firstName, LastName = lastName, Age = age },
            _ => throw new InvalidEnumArgumentException(nameof(type), (int)type, type.GetType())
        };

        return person;
    }
}