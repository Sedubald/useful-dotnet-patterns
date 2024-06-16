using Sed.UsefulDotNetPatterns.BuilderPattern;

var employeeBuilder = new PersonBuilder()
    .WithFirstName("John")
    .WithLastName("Doe")
    .WithAge(33);

employeeBuilder.PrintPersonToConsole();

Console.WriteLine();

var employeeBuilder2 = new PersonBuilder()
    .WithFirstName("Jane")
    .WithLastName("Doe")
    .WithAge(22);

employeeBuilder2.PrintPersonToConsole();


var director = new Director();
director.ConstructAndPrintJohn(new PersonBuilder());
director.ConstructAndPrintJane(new PersonBuilder());