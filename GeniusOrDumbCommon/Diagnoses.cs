namespace GeniusOrDumbCommon
{
    public static class Diagnoses
    {
        public static string GetDiagnose(int questionsCount, User user)
        {
            string[] diagnoses =
            [
                "Идиот",
                "Кретин",
                "Дурак",
                "Нормальный",
                "Талант",
                "Гений",
            ];
            var diagnoseIndex = GetDiagnoseIndex(questionsCount, user);
            return diagnoses[diagnoseIndex];
        }

        static int GetDiagnoseIndex(int questionsCount, User user)
        {
            double correctAnswersPercentage = user.CountCorrectAnswer * 100 / questionsCount;
            switch (correctAnswersPercentage)
            {
                case <= 15:
                    return 0;
                case <= 30:
                    return 1;
                case <= 45:
                    return 2;
                case <= 60:
                    return 3;
                case <= 80:
                    return 4;
                default:
                    return 5;
            }
        }
    }
}

