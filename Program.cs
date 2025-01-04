class Program
{
    static void Main()
    {
        using (Game game = new Game(800, 600, "Stack Storm"))
        {
            game.Run();
        }
    }
}

