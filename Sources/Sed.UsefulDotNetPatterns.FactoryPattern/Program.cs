using Sed.UsefulDotNetPatterns.FactoryPattern;

IPersonFactory sportyPersonFactory = new SportyPersonFactory();
var sportyPerson = sportyPersonFactory.Create("Jane", "Doe");

sportyPerson.SayHello();


IPersonFactory lazyPersonFactory = new LazyPersonFactory();
var lazyPerson = lazyPersonFactory.Create("John", "Doe", 33);

lazyPerson.SayHello();