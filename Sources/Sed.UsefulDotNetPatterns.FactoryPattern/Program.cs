using Sed.UsefulDotNetPatterns.FactoryPattern;

IPersonFactory sportyPersonFactory = new PersonFactory();
var sportyPerson = sportyPersonFactory.Create(PersonType.Sporty, "Jane", "Doe");

sportyPerson.SayHello();


IPersonFactory lazyPersonFactory = new PersonFactory();
var lazyPerson = lazyPersonFactory.Create(PersonType.Lazy,"John", "Doe", 33);

lazyPerson.SayHello();