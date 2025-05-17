using GeniusOrDumbCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            ResultsLabel.Text = "Таблица результатов";
            var results = UsersResultStorage.Load();
            ResultsListView.Columns.Add("ФИО", 150);
            ResultsListView.Columns.Add("Кол-во правильных ответов", 150);
            ResultsListView.Columns.Add("Диагноз", 150);
            ResultsListView.LabelEdit = false;
            ResultsListView.GridLines = true;
            ResultsListView.View = View.Details;
            ResultsListView.CheckBoxes = false;
            ResultsListView.MultiSelect = false;
            foreach (var result in results)
            {
                AddRow(result.Name, result.CountCorrectAnswer, result.Diagnose);
                //ResultsListView.Items.Add(result.Name, result.CountCorrectAnswer.ToString(), result.Diagnose);
            }
        }
        private void AddRow(string name, int countCorrectAnswer, string diagnose)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(countCorrectAnswer.ToString());
            item.SubItems.Add(diagnose);
            ResultsListView.Items.Add(item);
        }
    }
}
