namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
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
            newQuestionTextLabel = new Label();
            newQuestionAnswerLabel = new Label();
            newQuestionTextTextBox = new TextBox();
            newQuestionAnswerTextBox = new TextBox();
            newQuestionButton = new Button();
            SuspendLayout();
            // 
            // newQuestionTextLabel
            // 
            newQuestionTextLabel.AutoSize = true;
            newQuestionTextLabel.Location = new Point(9, 13);
            newQuestionTextLabel.Name = "newQuestionTextLabel";
            newQuestionTextLabel.Size = new Size(50, 20);
            newQuestionTextLabel.TabIndex = 0;
            newQuestionTextLabel.Text = "label1";
            // 
            // newQuestionAnswerLabel
            // 
            newQuestionAnswerLabel.AutoSize = true;
            newQuestionAnswerLabel.Location = new Point(9, 107);
            newQuestionAnswerLabel.Name = "newQuestionAnswerLabel";
            newQuestionAnswerLabel.Size = new Size(50, 20);
            newQuestionAnswerLabel.TabIndex = 1;
            newQuestionAnswerLabel.Text = "label2";
            // 
            // newQuestionTextTextBox
            // 
            newQuestionTextTextBox.Location = new Point(12, 55);
            newQuestionTextTextBox.Name = "newQuestionTextTextBox";
            newQuestionTextTextBox.Size = new Size(125, 27);
            newQuestionTextTextBox.TabIndex = 2;
            // 
            // newQuestionAnswerTextBox
            // 
            newQuestionAnswerTextBox.Location = new Point(11, 155);
            newQuestionAnswerTextBox.Name = "newQuestionAnswerTextBox";
            newQuestionAnswerTextBox.Size = new Size(125, 27);
            newQuestionAnswerTextBox.TabIndex = 3;
            // 
            // newQuestionButton
            // 
            newQuestionButton.Location = new Point(9, 206);
            newQuestionButton.Name = "newQuestionButton";
            newQuestionButton.Size = new Size(127, 62);
            newQuestionButton.TabIndex = 4;
            newQuestionButton.Text = "button1";
            newQuestionButton.UseVisualStyleBackColor = true;
            newQuestionButton.Click += newQuestionButton_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(152, 282);
            Controls.Add(newQuestionButton);
            Controls.Add(newQuestionAnswerTextBox);
            Controls.Add(newQuestionTextTextBox);
            Controls.Add(newQuestionAnswerLabel);
            Controls.Add(newQuestionTextLabel);
            Name = "AddQuestionForm";
            Text = "AddQuestionForm";
            Load += AddQuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newQuestionTextLabel;
        private Label newQuestionAnswerLabel;
        public TextBox newQuestionTextTextBox;
        public TextBox newQuestionAnswerTextBox;
        private Button newQuestionButton;
    }
}