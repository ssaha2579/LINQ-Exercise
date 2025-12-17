namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> VideoGamesNames = new List<string>()
                { "Guilty Gear 20th Anniversary Pack", "Monark", "Cris Tales", "Xenoblade Chronicles 3" };

            var VideoGames = VideoGamesNames.OrderBy(videoGame => videoGame.Length).ToList();

            foreach (var videoGame in VideoGames)
            {
                Console.WriteLine(videoGame);
            }

        }
    }
}
