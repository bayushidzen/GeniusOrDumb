namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionForm
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
            components = new System.ComponentModel.Container();
            deleteQuestionLabel = new Label();
            deleteQuestionButton = new Button();
            deleteQuestionDataGridView = new DataGridView();
            questionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)deleteQuestionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // deleteQuestionLabel
            // 
            deleteQuestionLabel.AutoSize = true;
            deleteQuestionLabel.Location = new Point(353, 24);
            deleteQuestionLabel.Name = "deleteQuestionLabel";
            deleteQuestionLabel.Size = new Size(50, 20);
            deleteQuestionLabel.TabIndex = 0;
            deleteQuestionLabel.Text = "label1";
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Location = new Point(395, 309);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(150, 72);
            deleteQuestionButton.TabIndex = 3;
            deleteQuestionButton.Text = "button1";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // deleteQuestionDataGridView
            // 
            deleteQuestionDataGridView.AllowUserToAddRows = false;
            deleteQuestionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            deleteQuestionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            deleteQuestionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deleteQuestionDataGridView.Location = new Point(52, 68);
            deleteQuestionDataGridView.Name = "deleteQuestionDataGridView";
            deleteQuestionDataGridView.ReadOnly = true;
            deleteQuestionDataGridView.RowHeadersWidth = 51;
            deleteQuestionDataGridView.Size = new Size(758, 188);
            deleteQuestionDataGridView.TabIndex = 4;
            // 
            // questionBindingSource
            // 
            questionBindingSource.DataSource = typeof(GeniusOrDumbCommon.Question);
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 429);
            Controls.Add(deleteQuestionDataGridView);
            Controls.Add(deleteQuestionButton);
            Controls.Add(deleteQuestionLabel);
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            Load += DeleteQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)deleteQuestionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deleteQuestionLabel;
        private Button deleteQuestionButton;
        private DataGridView deleteQuestionDataGridView;
        private BindingSource questionBindingSource;
    }
}