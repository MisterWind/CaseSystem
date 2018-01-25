namespace CaseSystem1
{
    partial class QuestionViewing
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
            this.dGVQuestResult = new System.Windows.Forms.DataGridView();
            this.DescrbQuestionTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameQuestionCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQuestResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVQuestResult
            // 
            this.dGVQuestResult.AllowUserToAddRows = false;
            this.dGVQuestResult.AllowUserToDeleteRows = false;
            this.dGVQuestResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQuestResult.Location = new System.Drawing.Point(50, 253);
            this.dGVQuestResult.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dGVQuestResult.MultiSelect = false;
            this.dGVQuestResult.Name = "dGVQuestResult";
            this.dGVQuestResult.ReadOnly = true;
            this.dGVQuestResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVQuestResult.Size = new System.Drawing.Size(1495, 570);
            this.dGVQuestResult.TabIndex = 29;
            // 
            // DescrbQuestionTB
            // 
            this.DescrbQuestionTB.Enabled = false;
            this.DescrbQuestionTB.Location = new System.Drawing.Point(349, 160);
            this.DescrbQuestionTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DescrbQuestionTB.Name = "DescrbQuestionTB";
            this.DescrbQuestionTB.Size = new System.Drawing.Size(1196, 38);
            this.DescrbQuestionTB.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Описание запроса";
            // 
            // NameQuestionCB
            // 
            this.NameQuestionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NameQuestionCB.Enabled = false;
            this.NameQuestionCB.FormattingEnabled = true;
            this.NameQuestionCB.Location = new System.Drawing.Point(349, 88);
            this.NameQuestionCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameQuestionCB.Name = "NameQuestionCB";
            this.NameQuestionCB.Size = new System.Drawing.Size(1196, 45);
            this.NameQuestionCB.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Название запроса";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1261, 854);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(284, 67);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveQuestion
            // 
            this.RemoveQuestion.Location = new System.Drawing.Point(955, 855);
            this.RemoveQuestion.Name = "RemoveQuestion";
            this.RemoveQuestion.Size = new System.Drawing.Size(284, 66);
            this.RemoveQuestion.TabIndex = 31;
            this.RemoveQuestion.Text = "Удалить";
            this.RemoveQuestion.UseVisualStyleBackColor = true;
            this.RemoveQuestion.Click += new System.EventHandler(this.RemoveQuestion_Click);
            // 
            // QuestionViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 978);
            this.Controls.Add(this.RemoveQuestion);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dGVQuestResult);
            this.Controls.Add(this.DescrbQuestionTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameQuestionCB);
            this.Controls.Add(this.label1);
            this.Name = "QuestionViewing";
            this.Text = "Просмотр запроса";
            this.Load += new System.EventHandler(this.QuestionViewing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVQuestResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVQuestResult;
        public System.Windows.Forms.TextBox DescrbQuestionTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox NameQuestionCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RemoveQuestion;
    }
}