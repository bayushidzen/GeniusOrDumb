namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            ResultsLabel = new Label();
            ResultsListView = new ListView();
            SuspendLayout();
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(379, 25);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(50, 20);
            ResultsLabel.TabIndex = 0;
            ResultsLabel.Text = "label1";
            // 
            // ResultsListView
            // 
            ResultsListView.Location = new Point(22, 82);
            ResultsListView.Name = "ResultsListView";
            ResultsListView.Size = new Size(796, 220);
            ResultsListView.TabIndex = 1;
            ResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 352);
            Controls.Add(ResultsListView);
            Controls.Add(ResultsLabel);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResultsLabel;
        private ListView ResultsListView;
    }
}