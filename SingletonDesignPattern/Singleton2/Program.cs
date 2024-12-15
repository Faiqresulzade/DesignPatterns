using Singleton2;

Parallel.For(1, 10, (item) =>
{
    Player.GetPlayer();
});