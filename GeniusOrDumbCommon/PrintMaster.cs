namespace GeniusOrDumbCommon
{
    public class PrintMaster()
    {
        public static void PrintResults()
        {
            var userResults = UsersResultStorage.Load();
            string tableLabel = "Обследования";
            string fioLabel = "ФИО";
            string countCorrectAnswerLabel = "Количество правильных ответов";
            string resultLabel = "Диагноз";
            if (File.Exists(UsersResultStorage.diagnosesFilepath))
            {
                int maximumWidth = GetMaximumWidth(userResults, countCorrectAnswerLabel);
                Console.WriteLine();
                PrintTable(tableLabel, maximumWidth);
                PrintTable('-', maximumWidth);
                PrintTable(fioLabel, countCorrectAnswerLabel, resultLabel, maximumWidth);
                PrintTable('-', maximumWidth);
                foreach (var line in userResults)
                {
                    PrintTable(line.Name, line.CountCorrectAnswer.ToString(), line.Diagnose, maximumWidth);
                }
            }
        }

        private static void PrintTable(string oneColomn, int maximumWidth)
        {
            Console.WriteLine($"| {new string(' ', maximumWidth / 2)} | {oneColomn.PadRight(maximumWidth)} | {new string(' ', maximumWidth / 2)} |");
        }

        private static void PrintTable(string firstColomn, string secondColomn, string thirdColomn, int maximumWidth)
        {
            Console.WriteLine($"| {firstColomn.PadRight(maximumWidth / 2)} | {secondColomn.PadRight(maximumWidth)} | {thirdColomn.PadRight(maximumWidth / 2)} |");
        }

        private static void PrintTable(char firstColomn, int maximumWidth)
        {
            Console.WriteLine($"| {new string(firstColomn, maximumWidth / 2)} | {new string(firstColomn, maximumWidth)} | {new string(firstColomn, maximumWidth / 2)} |");
        }

        private static int GetMaximumWidth(List<User> userResults, string countCorrectAnswerLabel)
        {
            int length = -10000;
            foreach (var line in userResults)
            {
                var name = line.Name;
                var countCorrectAnswer = countCorrectAnswerLabel;
                var diagnose = line.Diagnose;
                if (length < name.Length + countCorrectAnswer.ToString().Length + diagnose.Length) length = name.Length + countCorrectAnswer.ToString().Length + diagnose.Length;
            }
            return length;
        }
    }
}

