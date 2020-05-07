// This pattern make sure that only one instance of the class will be created
public sealed class Singleton
{
    private static volatile Singleton instance;
    private static readonly object _syncLock = new object();

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            if (instance != null) return instance;
            lock (_syncLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }

            return instance;
        }
    }
}