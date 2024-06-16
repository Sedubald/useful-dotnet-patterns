using Sed.UsefulDotNetPatterns.SingletonPattern;

var singletonInstance1 = MySingleton.Instance;
var singletonInstance2 = MySingleton.Instance;

Console.WriteLine($"singletonInstance1 value: {singletonInstance1.IsSingleton}.");
Console.WriteLine($"singletonInstance2 value: {singletonInstance2.IsSingleton}.");

singletonInstance1.IsSingleton = true;

Console.WriteLine($"singletonInstance1 value: {singletonInstance1.IsSingleton}.");
Console.WriteLine($"singletonInstance2 value: {singletonInstance2.IsSingleton}.");
