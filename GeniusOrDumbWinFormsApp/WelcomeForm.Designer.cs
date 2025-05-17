namespace GeniyIdiotWinFormsApp
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeTextLabel = new Label();
            WelcomeQuestionLabel = new Label();
            WelcomeAnswerTextBox = new TextBox();
            WelcomeNextButton = new Button();
            SuspendLayout();
            // 
            // WelcomeTextLabel
            // 
            WelcomeTextLabel.AutoSize = true;
            WelcomeTextLabel.Location = new Point(45, 34);
            WelcomeTextLabel.Name = "WelcomeTextLabel";
            WelcomeTextLabel.Padding = new Padding(20, 0, 20, 0);
            WelcomeTextLabel.Size = new Size(174, 20);
            WelcomeTextLabel.TabIndex = 0;
            WelcomeTextLabel.Text = "WelcomeTextLabel";
            WelcomeTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeQuestionLabel
            // 
            WelcomeQuestionLabel.AutoSize = true;
            WelcomeQuestionLabel.Location = new Point(87, 72);
            WelcomeQuestionLabel.Name = "WelcomeQuestionLabel";
            WelcomeQuestionLabel.Padding = new Padding(20, 0, 20, 0);
            WelcomeQuestionLabel.Size = new Size(90, 20);
            WelcomeQuestionLabel.TabIndex = 1;
            WelcomeQuestionLabel.Text = "label2";
            WelcomeQuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeAnswerTextBox
            // 
            WelcomeAnswerTextBox.Location = new Point(127, 138);
            WelcomeAnswerTextBox.Name = "WelcomeAnswerTextBox";
            WelcomeAnswerTextBox.PlaceholderText = "Вася Пупкин";
            WelcomeAnswerTextBox.Size = new Size(165, 27);
            WelcomeAnswerTextBox.TabIndex = 2;
            // 
            // WelcomeNextButton
            // 
            WelcomeNextButton.Location = new Point(127, 207);
            WelcomeNextButton.Name = "WelcomeNextButton";
            WelcomeNextButton.Size = new Size(165, 29);
            WelcomeNextButton.TabIndex = 3;
            WelcomeNextButton.Text = "button1";
            WelcomeNextButton.UseVisualStyleBackColor = true;
            WelcomeNextButton.Click += WelcomeNextButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 333);
            Controls.Add(WelcomeNextButton);
            Controls.Add(WelcomeAnswerTextBox);
            Controls.Add(WelcomeQuestionLabel);
            Controls.Add(WelcomeTextLabel);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeTextLabel;
        private Label WelcomeQuestionLabel;
        public TextBox WelcomeAnswerTextBox;
        private Button WelcomeNextButton;
    }
}