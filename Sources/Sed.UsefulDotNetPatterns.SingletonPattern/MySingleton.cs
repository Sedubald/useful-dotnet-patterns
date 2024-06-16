namespace Sed.UsefulDotNetPatterns.SingletonPattern;

public sealed class MySingleton
{
    private static MySingleton? _instance;
    private static readonly object LockObject = new();

    public bool IsSingleton { get; set; } = false;

    private MySingleton() { }

    public static MySingleton Instance
    {
        get
        {
            lock (LockObject)
            {
                _instance ??= new MySingleton();
            }

            return _instance;
        }
    }
}