namespace MovieApp.Models
{
    public class Trailer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DurationInMinutes { get; set; }

        public Movie Movie { get; set; }
    }
}