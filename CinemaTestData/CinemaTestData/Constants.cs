namespace CinemaTestData
{
    public static class Constants
    {
        public const string TITLES_FILE_NAME = "titles";
        public const string CREDITS_FILE_NAME = "credits";
        public const string DATA_FILES_DIRECTORY = "DataFiles";

        public const string CSV_FORMAT = ".csv";

        public const char GENRES_SPLIT_CHARACTED = ';';

        public const int MINIMUM_RUNTIME = 30;
        public const int MAXIMUM_RUNTIME = 240;
        public const int TITLES_COUNT = 1000;

        public static List<string> AGE_CERTIFICATIONS = new List<string>
        {
            "G", "PG", "PG-13", "R", "NC-17", "U", "U/A", "A", "S", "AL",
            "6", "9", "12", "12A", "15", "18", "18R", "R18", "R21", "M",
            "MA15+", "R16", "R18+", "X18", "T", "E", "E10+", "EC", "C", "CA",
            "GP", "M/PG", "TV-Y", "TV-Y7", "TV-G", "TV-PG", "TV-14", "TV-MA"
        };

        public static List<string> ROLES = new List<string>
        {
            "Director", "Producer", "Screenwriter", "Actor", "Actress",
            "Cinematographer", "Film Editor", "Production Designer",
            "Costume Designer", "Music Composer"
        };

        public static List<string> GENRES = new List<string>
        {
            "Action", "Adventure", "Animation", "Biography", "Comedy",
            "Crime", "Documentary", "Drama", "Family", "Fantasy",
            "Film-Noir", "History", "Horror", "Musical", "Mystery",
            "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western"
        };
    }
}
