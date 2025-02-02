namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>()
            {
                "Fallout: New Vegas",
                "Call of Duty",
                "Diablo",
                "Assassin's Creed",
                "Phasmaphobia",
                "Doom",
                "Mario"
            };
            
            var orderedGameNames = gameNames.OrderBy(gameName => gameName.Length).ToList(); 
            orderedGameNames.ForEach(game => Console.WriteLine(game));
        }
    }
}
