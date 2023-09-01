namespace CinemaTestData.Models
{
    public class Title
    {
        private List<string> genres;

        public Title()
        {
            genres = new List<string>();
        }

        public int Id { get; set; }
        public string TitleName { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public string AgeCertification { get; set; }
        public int Runtime { get; set; }
        public string Genres
        {
            get => string.Join(Constants.GENRES_SPLIT_CHARACTED, genres);
            set => genres = value.Split(Constants.GENRES_SPLIT_CHARACTED).ToList();
        }
        public string ProductionCountry { get; set; }
        public int? Seasons { get; set; }
    }
}
