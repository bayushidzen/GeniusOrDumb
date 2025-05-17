using System;
using System.Collections.Generic;
namespace GeniyIdiotWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            WelcomeTextLabel.Text = @"Приветствуем вас в тесте ""Гений - Идиот""!";
            WelcomeQuestionLabel.Text = "Представьтесь, пожалуйста!";
            WelcomeNextButton.Text = "Начать тестирование";
            WelcomeAnswerTextBox.PlaceholderText = "Вася Пупкин";
        }

        private void WelcomeNextButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
