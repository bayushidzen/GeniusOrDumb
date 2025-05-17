namespace GeniusOrDumbCommon
{
    public class FileMaster
    {
        public static void Append(string filepath, string jsonData)
        {
            File.WriteAllText(filepath, jsonData);
        }

        public static string Get(string filepath)
        {
            return File.ReadAllText(filepath);
        }
    }
}

