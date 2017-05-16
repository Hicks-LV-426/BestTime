namespace BestTime.Library
{
    using System.IO;

    public class Reader
    {
        public string GetText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
