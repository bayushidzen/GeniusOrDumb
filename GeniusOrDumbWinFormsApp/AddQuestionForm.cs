using GeniusOrDumbCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
            newQuestionAnswerTextBox.TextChanged += newQuestionAnswerTextBox_TextChanged;
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            newQuestionTextLabel.Text = "Введите ваш вопрос";
            newQuestionAnswerLabel.Text = "Введите ответ вопрос";
            newQuestionButton.Text = "Отправить";
        }

        private void newQuestionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void newQuestionAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidator.IsValidInput(newQuestionAnswerTextBox.Text))
            {
                newQuestionAnswerTextBox.BackColor = Color.LightPink;
                newQuestionButton.Enabled = false;
                MessageBox.Show("Введите число от 1 до 100000", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                newQuestionAnswerTextBox.BackColor = Color.LightGreen;
                newQuestionButton.Enabled = true;
            }
        }
    }
}
