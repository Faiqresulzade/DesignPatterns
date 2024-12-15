namespace Singleton2;

public class Player
{

    //private inner class
    //Class Loader
    public static int Count = 0;

    private Player()
    {
        ++Count;
        Console.WriteLine(Count);
    }

    public static Player GetPlayer()
    {
        return SingletonManager.instance;
    }

    private class SingletonManager
    {
        internal static Player instance = new Player();
    }

}
