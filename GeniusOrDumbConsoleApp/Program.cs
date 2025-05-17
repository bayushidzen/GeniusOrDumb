using GeniusOrDumbCommon;

namespace GeniusOrDumbConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            bool firstRun = true;
            Console.WriteLine(@"Приветствуем вас в тесте ""Гений - Идиот""!");
            Console.Write("Представьтесь, пожалуйста: ");
            var user = new User(Console.ReadLine());
            Console.WriteLine($"Здравствуйте, {user.Name}!");            
            ShowMenu(firstRun, user);
        }

        static void ShowMenu(bool firstRun, User user)
        {
            if (firstRun)
            {
                Console.WriteLine("Вы готовы пройти обследование?");
                Console.Write("1 - Да, 2 - Нет, 3 - Посмотреть результаты, 4 - Добавить новый вопрос, \n5 - Удалить существующий вопрос: ");
                int userChoice = GetUserMenuChoice();
                if (userChoice == 1) firstRun = false;
                StartUserChoiceMenuPoint(user, userChoice);
            }
            else
            {
                Console.WriteLine($"Хотите пройти обследование повторно?");
                Console.Write("1 - Да, 2 - Нет, 3 - Посмотреть результаты, 4 - Добавить новый вопрос, \n5 - Удалить существующий вопрос: ");
                int userChoice = GetUserMenuChoice();
                user.Diagnose = "Не установлен";
                user.CountCorrectAnswer = 0;
                StartUserChoiceMenuPoint(user, userChoice);
            }
            ShowMenu(firstRun, user);
        }

        private static void StartUserChoiceMenuPoint(User user, int userChoice)
        {
            while (true)
            {
                switch (userChoice)
                {
                    case 1: StartNewTest(user); return;
                    case 2: Console.WriteLine("Будем рады видеть вас в следующий раз"); Environment.Exit(0); return;
                    case 3: PrintMaster.PrintResults(); return;
                    case 4: AddNewQuestion(); return;
                    case 5: RemoveQuestion(); return;
                    case -1: return;
                    default: Console.Write("Укажите, пожалуйста, цифру выбранного варианта ответа\n(1 - Да, 2 - Нет, 3 - Посмотреть результаты, 4 - Добавить новый вопрос, \n5 - Удалить существующий вопрос): "); return;
                }
            }
        }

        static void RemoveQuestion()
        {
            var questions = QuestionsStorage.Load();
            var questionNumber = 1;
            foreach (var question in questions)
            {
                Console.WriteLine($"№{questionNumber} {question.Text}");
                questionNumber++;
            }
            Console.WriteLine("Какой вопрос вы хотите удалить? Укажите номер вопроса: ");
            var removeQuestionNumber = GetUserAnswer();
            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine($"Введите число от 1 до {questions.Count}");
                removeQuestionNumber = GetUserAnswer();
            }
            questions.RemoveAt(removeQuestionNumber - 1);
            questionNumber = 1;
            foreach (var question in questions)
            {
                Console.WriteLine($"№{questionNumber} {question.Text}");
                questionNumber++;
            }
            QuestionsStorage.Save(questions);
        }

        private static int GetUserMenuChoice()
        {
            while (true)
            {
                try
                {
                    var menuNum = Convert.ToInt32(Console.ReadLine());
                    if (menuNum > 0 && menuNum <= 5) return menuNum;
                    else Console.WriteLine("Пожалуйста, укажите корректный пункт меню"); 
                    return -1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите, пожалуйста, число! ");
                }
                catch (OverflowException)
                {
                    Console.Write("Внимание! Вы указали несуществующий пункт меню\n" +
                        "Пожалуйста, укажите корректный пункт меню\n" +
                        "(1 - Да, 2 - Нет, 3 - Посмотреть результаты, 4 - Добавить новый вопрос, \n5 - Удалить существующий вопрос): ");
                }
            }
        }

        static int GetUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите, пожалуйста, число! ");
                }
                catch (OverflowException)
                {
                    Console.Write("Внимание! Вы ввели слишком большое число, все ответы не больше 1000\nВведите ваш ответ: ");
                }
            }
        }

        static void StartNewTest(User user)
        {
            var test = new Test(user);
            while (!test.End())
            {
                var currentQuestion = test.GetNextQuestion();

                Console.WriteLine(test.GetQuestionNumberText());

                Console.WriteLine(currentQuestion.Text);
                int userAnswer = GetUserAnswer();
                test.AcceptAnswer(userAnswer);
            }
            var message = test.GetUserDiagnose();
            Console.WriteLine(message);
        }

        private static void AddNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса");
            var newQuestionText = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var newQuestionAnswer = GetUserAnswer();

            var newQuestion = new Question(newQuestionText, newQuestionAnswer);
            QuestionsStorage.AppendNewQuestion(newQuestion);
        }
    }
}

