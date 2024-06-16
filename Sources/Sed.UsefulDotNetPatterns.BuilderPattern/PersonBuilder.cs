namespace Sed.UsefulDotNetPatterns.BuilderPattern;

internal class PersonBuilder
{
    private readonly Person _person;

    public PersonBuilder()
    {
        _person = new Person();
    }

    public PersonBuilder WithFirstName(string firstName)
    {
        this._person.FirstName = firstName;
        return this;
    }

    public PersonBuilder WithLastName(string lastName)
    {
        this._person.LastName = lastName;
        return this;
    }

    public PersonBuilder WithAge(int age)
    {
        this._person.Age = age;
        return this;
    }

    public void PrintPersonToConsole()
    {
        Console.WriteLine($"First name: {this._person.FirstName}");
        Console.WriteLine($"Last name: {this._person.LastName}");
        Console.WriteLine($"Age: {this._person.Age}");
    }
}