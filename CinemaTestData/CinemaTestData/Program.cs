namespace CinemaTestData
{
    using Bogus;
    using CinemaTestData.Models;

    using static Constants;

    public partial class Program
    {
        public static void Main()
        {
            var titleFaker = new Faker<Title>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.TitleName, f => f.Lorem.Sentence())
                .RuleFor(o => o.Description, f => f.Lorem.Paragraph())
                .RuleFor(o => o.ReleaseYear, f => f.Date.Between(new DateTime(1900, 1, 1), DateTime.Now).Year)
                .RuleFor(o => o.AgeCertification, f => f.PickRandom(AGE_CERTIFICATIONS))
                .RuleFor(o => o.Runtime, f => f.Random.Int(MINIMUM_RUNTIME, MAXIMUM_RUNTIME)).RuleFor(o => o.Genres, f =>
                {
                    var selectedGenres = f.Random.ListItems(GENRES, f.Random.Int(1, 3));
                    return string.Join(GENRES_SPLIT_CHARACTED, selectedGenres);
                })
                .RuleFor(o => o.ProductionCountry, f => f.Address.CountryCode())
                .RuleFor(o => o.Seasons, f => f.Random.Bool(0.8f) ? null : (int?)f.Random.Int(1, 10));

            var creditFaker = new Faker<Credit>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.TitleId, f => f.Random.Int(0, TITLES_COUNT - 1))  // Assuming up to 1000 titles.
                .RuleFor(o => o.RealName, f => f.Name.FullName())
                .RuleFor(o => o.CharacterName, f => f.Name.FirstName())
                .RuleFor(o => o.Role, f => f.PickRandom(ROLES));

            var titles = titleFaker.Generate(TITLES_COUNT);
            var credits = creditFaker.Generate(TITLES_COUNT * 5);  // Assuming 5 credits per title on average.

            FileCreator.CreateFileWithData(TITLES_FILE_NAME, titles);
            FileCreator.CreateFileWithData(CREDITS_FILE_NAME, credits);
        }
    }
}
