namespace SingletonDesignPattern;

public class Camera
{
    //LazyLoading
    public int Position { get; set; }
    public string Name { get; set; }

    private static volatile Camera _instance;

    public static int Count = 0;

    private static Object _instanceLock = new Object();

    private Camera()
    {
        ++Count;
        Console.WriteLine(Count);
    }

    public static Camera GetCamera()
    {
        //Race Condi
        //Lock,Monitor,Mutex,Semaphore,SemaphoreSlime,ReaderWriteLock

        if (_instance is null)
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                    _instance = new Camera();
            }
        }


        return _instance;
    }
}
