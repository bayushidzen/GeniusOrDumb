using Newtonsoft.Json;

namespace GeniusOrDumbCommon
{
    public static class QuestionsStorage
    {
        public const string questionsRoot = "Questions";
        public const string questionsFilepath = "questions.json";
        public static List<Question> GetBaseQuestions()
        {
            var questions = new List<Question>
            {
                new("Сколько будет два плюс два умноженное на два", 6),
                new("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
                new("На двух руках 10 пальцев. Сколько пальцев на 5 руках", 25),
                new("Укол делают каждые полчаса, сколько нужно минут для трех уколов", 60),
                new("Пять свечей горело, две потухло. Сколько свечей осталось?", 2)
            };
            return questions;
        }

        public static void AppendNewQuestion(Question newQuestion)
        {
            var questions = Load();
            questions.Add(newQuestion);
            Save(questions);
        }

        public static List<Question> Load()
        {
            if (!File.Exists(questionsFilepath))
            {
                Save(GetBaseQuestions());
            }
            var fileData = FileMaster.Get(questionsFilepath);
            var questions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            return questions;
        }

        public static void Save(List<Question> newQuestions)
        {
            var jsonData = JsonConvert.SerializeObject(newQuestions);
            FileMaster.Append(questionsFilepath, jsonData);
        }
    }
}

