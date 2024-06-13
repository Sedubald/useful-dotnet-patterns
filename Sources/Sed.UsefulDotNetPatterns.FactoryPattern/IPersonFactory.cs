namespace Sed.UsefulDotNetPatterns.FactoryPattern;

internal interface IPersonFactory
{
    Person Create(string firstName, string lastName);

    Person Create(string firstName, string lastName, int age);
}