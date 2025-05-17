namespace GeniusOrDumbCommon
{
    public class Test
    {
        User user;
        List<Question> questions;
        Question currentquestion;
        int questionsNumber = 0;
        int startQuestionsCount;

        public Test(User user)
        {
            this.user = user;
            questions = QuestionsStorage.Load();
            startQuestionsCount = questions.Count;
        }

        public Question GetNextQuestion()
        {
            Random random = new();
            int randomQuestionIndex = random.Next(questions.Count);
            currentquestion = questions[randomQuestionIndex];
            questionsNumber++;
            return currentquestion;
        }

        public string GetQuestionNumberText()
        { 
            return $"Вопрос № {questionsNumber}"; 
        }

        public void AcceptAnswer(int userAnswer)
        {

            int rightAnswer = currentquestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.IncreaseCorrectAnswer();
            }
            questions.Remove(currentquestion);
        }

        public bool End()
        {
            return questions.Count == 0;
        }

        public string GetUserDiagnose()
        {
            user.Diagnose = Diagnoses.GetDiagnose(startQuestionsCount, user);
            UsersResultStorage.Append(user);
            var message = $"Игра окончена, Вы - {user.Diagnose}";
            return message;
        }
    }
}
