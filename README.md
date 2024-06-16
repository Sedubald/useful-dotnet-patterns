# useful-dotnet-patterns
This solution contains some useful .NET patterns. Patterns are a set of best practices to solve common problems, they are reusable and support the developers to create flexible, scalable and maintainable software solutions.

## Builder pattern



## Factory pattern

The *factory pattern* helps to hide the object instanciation to the client. An object is not created by calling the constructor, but is requested by the factory. So the *factory pattern* is a *creational pattern*. The returned classes of factories are often called *products*. This provides the advantage that a new concrete implementation can be added by extending 

## Singleton pattern

The *singleton pattern* ensures that there exists only one instance of an object. The class holds a static property of itself, which is often called **Instance**. It is important to set the classes constructor *private* to avoid an object instantiation in other code places. It is also helpful to declare the class as sealed to prevent inheritance.

--- 
.NET supports the singleton pattern with the built-in dependency injection as well.

You can find the supported service lifetimes in Microsofts documentation here (status as of 16th June 2024):
https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes

You can find a *how to* use the dependeny injection in Microsofts documentation here (status as of 16th June 2024):
https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage