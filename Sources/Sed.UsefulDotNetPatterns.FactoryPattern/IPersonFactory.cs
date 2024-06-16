namespace Sed.UsefulDotNetPatterns.FactoryPattern;

internal interface IPersonFactory
{
    IPerson Create(PersonType type, string firstName, string lastName);

    IPerson Create(PersonType type, string firstName, string lastName, int age);
}