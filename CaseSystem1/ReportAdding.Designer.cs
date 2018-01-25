namespace CaseSystem1
{
    partial class ReportAdding
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
            this.QuestionList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FormatList = new System.Windows.Forms.ComboBox();
            this.ReportGeneration = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionList
            // 
            this.QuestionList.FormattingEnabled = true;
            this.QuestionList.Location = new System.Drawing.Point(266, 49);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(763, 39);
            this.QuestionList.TabIndex = 0;
            this.QuestionList.SelectedIndexChanged += new System.EventHandler(this.QuestionList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название отчета";
            // 
            // ReportName
            // 
            this.ReportName.Location = new System.Drawing.Point(266, 113);
            this.ReportName.Name = "ReportName";
            this.ReportName.Size = new System.Drawing.Size(763, 38);
            this.ReportName.TabIndex = 3;
            this.ReportName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Формат";
            // 
            // FormatList
            // 
            this.FormatList.FormattingEnabled = true;
            this.FormatList.Items.AddRange(new object[] {
            "MS Word",
            "MS Excel"});
            this.FormatList.Location = new System.Drawing.Point(266, 171);
            this.FormatList.Name = "FormatList";
            this.FormatList.Size = new System.Drawing.Size(763, 39);
            this.FormatList.TabIndex = 5;
            // 
            // ReportGeneration
            // 
            this.ReportGeneration.Location = new System.Drawing.Point(710, 241);
            this.ReportGeneration.Name = "ReportGeneration";
            this.ReportGeneration.Size = new System.Drawing.Size(318, 80);
            this.ReportGeneration.TabIndex = 6;
            this.ReportGeneration.Text = "Сгенерировать отчет";
            this.ReportGeneration.UseVisualStyleBackColor = true;
            this.ReportGeneration.Click += new System.EventHandler(this.ReportGeneration_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(391, 241);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(295, 80);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReportAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 395);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ReportGeneration);
            this.Controls.Add(this.FormatList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReportName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionList);
            this.Name = "ReportAdding";
            this.Text = "Создание отчета";
            this.Load += new System.EventHandler(this.ReportAdding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox QuestionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReportName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FormatList;
        private System.Windows.Forms.Button ReportGeneration;
        private System.Windows.Forms.Button CancelButton;
    }
}