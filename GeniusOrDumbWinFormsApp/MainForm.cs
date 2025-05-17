using GeniusOrDumbCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        User user = new("Unknown");
        Test test;
        public MainForm()
        {
            InitializeComponent();
            userAnswerTextBox.TextChanged += UserAnswerTextBox_TextChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            user = new(welcomeForm.WelcomeAnswerTextBox.Text);
            test = new Test(user);
            userAnswerNextButton.Enabled = false;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            userAnswerNextButton.Enabled = false;
            userAnswerTextBox.BackColor = Color.White;
            var currentquestion = test.GetNextQuestion();
            questionTextLabel.Text = currentquestion.Text;
            questionNumberLabel.Text = test.GetQuestionNumberText();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int userAnswer = int.Parse(userAnswerTextBox.Text);
            test.AcceptAnswer(userAnswer);
            if (test.End())
            {
                var message = test.GetUserDiagnose();
                MessageBox.Show(message);
                Close();
            }
            else
            {
                ShowNextQuestion();
            }
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog();
            var newQuestionAnswer = 0;

            var newQuestionText = addQuestionForm.newQuestionTextTextBox.Text;
            if (addQuestionForm.newQuestionAnswerTextBox.Text != string.Empty)
            {
                newQuestionAnswer = Convert.ToInt32(addQuestionForm.newQuestionAnswerTextBox.Text);
            }
            if (newQuestionText == "" || newQuestionAnswer == 0) addQuestionForm.Close();

            var newQuestion = new Question(newQuestionText, newQuestionAnswer);
            QuestionsStorage.AppendNewQuestion(newQuestion);
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.ShowDialog();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        public void UserAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidator.IsValidInput(userAnswerTextBox.Text))
            {
                userAnswerTextBox.BackColor = Color.LightPink;
                userAnswerNextButton.Enabled = false;
                MessageBox.Show("Введите число от 1 до 10000", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                userAnswerTextBox.BackColor = Color.LightGreen;
                userAnswerNextButton.Enabled = true;
            }
        }
    }    
}
