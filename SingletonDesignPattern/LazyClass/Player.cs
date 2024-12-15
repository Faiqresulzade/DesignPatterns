namespace LazyClass;

internal class Player
{
    private Lazy<Player> _instance = new Lazy<Player>(() => new Player());

    public Player GetPlayer() => _instance.Value;
}

