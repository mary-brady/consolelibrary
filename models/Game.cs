namespace consolelibrary.Models
{
    public class Game
    {
        public string Title { get; private set; }
        public string Studio { get; private set; }
        public string Rating { get; private set; }
        public bool Available { get; set; }

        public Game(string title, string studio, string rating, bool available = true)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
            Available = available;
        }
    }
}