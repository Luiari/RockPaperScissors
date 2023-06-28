namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            IGame rockPaperScissorsGame = game.CreateGame();
            rockPaperScissorsGame.Play();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}