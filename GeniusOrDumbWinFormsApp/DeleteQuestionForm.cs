using GeniusOrDumbCommon;
namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        List<Question> questions;
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            deleteQuestionLabel.Text = "Какие вопросы вы хотите удалить?";
            deleteQuestionButton.Text = "Удалить!";
            questions = QuestionsStorage.Load();
            deleteQuestionDataGridView.Columns.Add("Список НеВопросов","Список вопросов");
            foreach (Question question in questions)
            {
                deleteQuestionDataGridView.Rows.Add(question.Text);
            }
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            var checkedQuestions = deleteQuestionDataGridView.Rows;
            if (deleteQuestionDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = deleteQuestionDataGridView.SelectedRows[0];
                int rowIndex = deleteQuestionDataGridView.SelectedRows[0].Index;
                MessageBox.Show($"{rowIndex}");
                questions.RemoveAt(rowIndex);
                deleteQuestionDataGridView.Rows.Remove(row);
            }
            QuestionsStorage.Save(questions);
            Close();
        }
    }
}
