namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userAnswerNextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            результатыToolStripMenuItem = new ToolStripMenuItem();
            рестартToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            AddQuestionToolStripMenuItem = new ToolStripMenuItem();
            DeleteQuestionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userAnswerNextButton
            // 
            userAnswerNextButton.Location = new Point(35, 215);
            userAnswerNextButton.Name = "userAnswerNextButton";
            userAnswerNextButton.Size = new Size(125, 69);
            userAnswerNextButton.TabIndex = 0;
            userAnswerNextButton.Text = "Далее";
            userAnswerNextButton.UseVisualStyleBackColor = true;
            userAnswerNextButton.Click += NextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(35, 57);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(120, 20);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Номер вопроса";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoEllipsis = true;
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(35, 90);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(108, 20);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(35, 166);
            userAnswerTextBox.MaxLength = 5;
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.PlaceholderText = "1234";
            userAnswerTextBox.Size = new Size(125, 27);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, AddQuestionToolStripMenuItem, DeleteQuestionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(389, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { результатыToolStripMenuItem, рестартToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // результатыToolStripMenuItem
            // 
            результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            результатыToolStripMenuItem.Size = new Size(169, 26);
            результатыToolStripMenuItem.Text = "Результаты";
            результатыToolStripMenuItem.Click += ResultsToolStripMenuItem_Click;
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(169, 26);
            рестартToolStripMenuItem.Text = "Рестарт";
            рестартToolStripMenuItem.Click += RestartToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(169, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // AddQuestionToolStripMenuItem
            // 
            AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem";
            AddQuestionToolStripMenuItem.Size = new Size(145, 24);
            AddQuestionToolStripMenuItem.Text = "Добавить вопрос";
            AddQuestionToolStripMenuItem.Click += AddQuestionToolStripMenuItem_Click;
            // 
            // DeleteQuestionToolStripMenuItem
            // 
            DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem";
            DeleteQuestionToolStripMenuItem.Size = new Size(134, 24);
            DeleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            DeleteQuestionToolStripMenuItem.Click += DeleteQuestionToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 314);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(userAnswerNextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Гений Идиот";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button userAnswerNextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddQuestionToolStripMenuItem;
        private ToolStripMenuItem DeleteQuestionToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem результатыToolStripMenuItem;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}
