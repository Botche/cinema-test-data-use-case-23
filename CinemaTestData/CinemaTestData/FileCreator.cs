namespace CinemaTestData
{
    using CsvHelper;
    using System.Globalization;

    public static class FileCreator
    {
        public static void CreateFileWithData<T>(string fileName, List<T> data)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)
                .Parent
                .Parent
                .FullName;

            string fileNameWithFormat = string.Join(string.Empty, fileName, Constants.CSV_FORMAT);

            string filePath = Path.Combine(projectDirectory, Constants.DATA_FILES_DIRECTORY, fileNameWithFormat);

            using var writerTitles = new StreamWriter(filePath);
            using var csvTitles = new CsvWriter(writerTitles, CultureInfo.InvariantCulture);
            csvTitles.WriteRecords(data);
        }
    }
}
