namespace GeniusOrDumbCommon
{
    public class User
    {
        public string Name;
        public int CountCorrectAnswer;
        public string Diagnose;

        public User(string name)
        {
            Name = name;
            Diagnose = "Не установлен";
        }

        public void IncreaseCorrectAnswer()
        {
            CountCorrectAnswer++;
        }
    }
}

