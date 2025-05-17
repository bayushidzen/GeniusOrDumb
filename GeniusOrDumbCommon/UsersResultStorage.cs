using Newtonsoft.Json;

namespace GeniusOrDumbCommon
{
    public static class UsersResultStorage
    {
        public const string diagnosesFilepath = "diagnoses.json";
        public static void Append(User user)
        {
            var userResults = Load();
            userResults.Add(user);
            Save(userResults);
        }

        private static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults);
            FileMaster.Append(diagnosesFilepath, jsonData);
        }

        public static List<User> Load()
        {            
            if (!File.Exists(diagnosesFilepath))
            {
                return new List<User>();
            }
            var fileData = FileMaster.Get(diagnosesFilepath);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }
    }
}

