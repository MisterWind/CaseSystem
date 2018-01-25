namespace CaseSystem1
{
    partial class FrMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenReport = new System.Windows.Forms.Button();
            this.OpenQuestion = new System.Windows.Forms.Button();
            this.OpenForm = new System.Windows.Forms.Button();
            this.OpenEntity = new System.Windows.Forms.Button();
            this.ReportList = new System.Windows.Forms.ComboBox();
            this.AddReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.QuestionList = new System.Windows.Forms.ComboBox();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FormList = new System.Windows.Forms.ComboBox();
            this.AddForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EntityList = new System.Windows.Forms.ComboBox();
            this.AddEntity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.OpenRelation = new System.Windows.Forms.Button();
            this.RelationList = new System.Windows.Forms.ComboBox();
            this.AddRelation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeProject = new System.Windows.Forms.Button();
            this.RemoveProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenReport
            // 
            this.OpenReport.Location = new System.Drawing.Point(448, 772);
            this.OpenReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OpenReport.Name = "OpenReport";
            this.OpenReport.Size = new System.Drawing.Size(204, 57);
            this.OpenReport.TabIndex = 47;
            this.OpenReport.Text = "Открыть";
            this.OpenReport.UseVisualStyleBackColor = true;
            // 
            // OpenQuestion
            // 
            this.OpenQuestion.Location = new System.Drawing.Point(448, 605);
            this.OpenQuestion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OpenQuestion.Name = "OpenQuestion";
            this.OpenQuestion.Size = new System.Drawing.Size(204, 57);
            this.OpenQuestion.TabIndex = 46;
            this.OpenQuestion.Text = "Открыть";
            this.OpenQuestion.UseVisualStyleBackColor = true;
            this.OpenQuestion.Click += new System.EventHandler(this.OpenQuestion_Click);
            // 
            // OpenForm
            // 
            this.OpenForm.Location = new System.Drawing.Point(448, 462);
            this.OpenForm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OpenForm.Name = "OpenForm";
            this.OpenForm.Size = new System.Drawing.Size(204, 57);
            this.OpenForm.TabIndex = 45;
            this.OpenForm.Text = "Открыть";
            this.OpenForm.UseVisualStyleBackColor = true;
            this.OpenForm.Click += new System.EventHandler(this.OpenForm_Click);
            // 
            // OpenEntity
            // 
            this.OpenEntity.Location = new System.Drawing.Point(448, 153);
            this.OpenEntity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OpenEntity.Name = "OpenEntity";
            this.OpenEntity.Size = new System.Drawing.Size(204, 57);
            this.OpenEntity.TabIndex = 44;
            this.OpenEntity.Text = "Открыть";
            this.OpenEntity.UseVisualStyleBackColor = true;
            this.OpenEntity.Click += new System.EventHandler(this.OpenEntity_Click);
            // 
            // ReportList
            // 
            this.ReportList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportList.FormattingEnabled = true;
            this.ReportList.Location = new System.Drawing.Point(203, 719);
            this.ReportList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ReportList.Name = "ReportList";
            this.ReportList.Size = new System.Drawing.Size(449, 39);
            this.ReportList.TabIndex = 43;
            // 
            // AddReport
            // 
            this.AddReport.Location = new System.Drawing.Point(203, 772);
            this.AddReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddReport.Name = "AddReport";
            this.AddReport.Size = new System.Drawing.Size(216, 57);
            this.AddReport.TabIndex = 42;
            this.AddReport.Text = "Добавить";
            this.AddReport.UseVisualStyleBackColor = true;
            this.AddReport.Click += new System.EventHandler(this.AddReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 719);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Отчеты";
            // 
            // QuestionList
            // 
            this.QuestionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestionList.FormattingEnabled = true;
            this.QuestionList.Location = new System.Drawing.Point(203, 552);
            this.QuestionList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(449, 39);
            this.QuestionList.TabIndex = 40;
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(203, 605);
            this.AddQuestion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(216, 57);
            this.AddQuestion.TabIndex = 39;
            this.AddQuestion.Text = "Добавить";
            this.AddQuestion.UseVisualStyleBackColor = true;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 571);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Запросы";
            // 
            // FormList
            // 
            this.FormList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormList.FormattingEnabled = true;
            this.FormList.Location = new System.Drawing.Point(203, 409);
            this.FormList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FormList.Name = "FormList";
            this.FormList.Size = new System.Drawing.Size(449, 39);
            this.FormList.TabIndex = 37;
            // 
            // AddForm
            // 
            this.AddForm.Location = new System.Drawing.Point(203, 462);
            this.AddForm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(216, 57);
            this.AddForm.TabIndex = 36;
            this.AddForm.Text = "Добавить";
            this.AddForm.UseVisualStyleBackColor = true;
            this.AddForm.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Формы";
            // 
            // EntityList
            // 
            this.EntityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntityList.FormattingEnabled = true;
            this.EntityList.Location = new System.Drawing.Point(203, 100);
            this.EntityList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EntityList.Name = "EntityList";
            this.EntityList.Size = new System.Drawing.Size(449, 39);
            this.EntityList.TabIndex = 34;
            // 
            // AddEntity
            // 
            this.AddEntity.Location = new System.Drawing.Point(203, 153);
            this.AddEntity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(216, 57);
            this.AddEntity.TabIndex = 33;
            this.AddEntity.Text = "Добавить";
            this.AddEntity.UseVisualStyleBackColor = true;
            this.AddEntity.Click += new System.EventHandler(this.AddEntity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Сущности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "Проект";
            // 
            // ProjectName
            // 
            this.ProjectName.Enabled = false;
            this.ProjectName.Location = new System.Drawing.Point(203, 35);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(449, 38);
            this.ProjectName.TabIndex = 49;
            // 
            // OpenRelation
            // 
            this.OpenRelation.Location = new System.Drawing.Point(448, 310);
            this.OpenRelation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OpenRelation.Name = "OpenRelation";
            this.OpenRelation.Size = new System.Drawing.Size(204, 57);
            this.OpenRelation.TabIndex = 53;
            this.OpenRelation.Text = "Открыть";
            this.OpenRelation.UseVisualStyleBackColor = true;
            // 
            // RelationList
            // 
            this.RelationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelationList.FormattingEnabled = true;
            this.RelationList.Location = new System.Drawing.Point(203, 257);
            this.RelationList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RelationList.Name = "RelationList";
            this.RelationList.Size = new System.Drawing.Size(449, 39);
            this.RelationList.TabIndex = 52;
            // 
            // AddRelation
            // 
            this.AddRelation.Location = new System.Drawing.Point(203, 310);
            this.AddRelation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddRelation.Name = "AddRelation";
            this.AddRelation.Size = new System.Drawing.Size(216, 57);
            this.AddRelation.TabIndex = 51;
            this.AddRelation.Text = "Добавить";
            this.AddRelation.UseVisualStyleBackColor = true;
            this.AddRelation.Click += new System.EventHandler(this.AddRelation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 50;
            this.label6.Text = "Связи";
            // 
            // ChangeProject
            // 
            this.ChangeProject.Location = new System.Drawing.Point(350, 864);
            this.ChangeProject.Name = "ChangeProject";
            this.ChangeProject.Size = new System.Drawing.Size(301, 70);
            this.ChangeProject.TabIndex = 54;
            this.ChangeProject.Text = "Сменить проект";
            this.ChangeProject.UseVisualStyleBackColor = true;
            this.ChangeProject.Click += new System.EventHandler(this.ChangeProject_Click);
            // 
            // RemoveProject
            // 
            this.RemoveProject.Location = new System.Drawing.Point(41, 864);
            this.RemoveProject.Name = "RemoveProject";
            this.RemoveProject.Size = new System.Drawing.Size(279, 70);
            this.RemoveProject.TabIndex = 55;
            this.RemoveProject.Text = "Удалить проект";
            this.RemoveProject.UseVisualStyleBackColor = true;
            this.RemoveProject.Click += new System.EventHandler(this.RemoveProject_Click);
            // 
            // FrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 979);
            this.Controls.Add(this.RemoveProject);
            this.Controls.Add(this.ChangeProject);
            this.Controls.Add(this.OpenRelation);
            this.Controls.Add(this.RelationList);
            this.Controls.Add(this.AddRelation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OpenReport);
            this.Controls.Add(this.OpenQuestion);
            this.Controls.Add(this.OpenForm);
            this.Controls.Add(this.OpenEntity);
            this.Controls.Add(this.ReportList);
            this.Controls.Add(this.AddReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormList);
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntityList);
            this.Controls.Add(this.AddEntity);
            this.Controls.Add(this.label1);
            this.Name = "FrMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenReport;
        private System.Windows.Forms.Button OpenQuestion;
        private System.Windows.Forms.Button OpenForm;
        private System.Windows.Forms.Button OpenEntity;
        private System.Windows.Forms.ComboBox ReportList;
        private System.Windows.Forms.Button AddReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox QuestionList;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FormList;
        private System.Windows.Forms.Button AddForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EntityList;
        private System.Windows.Forms.Button AddEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Button OpenRelation;
        private System.Windows.Forms.ComboBox RelationList;
        private System.Windows.Forms.Button AddRelation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChangeProject;
        private System.Windows.Forms.Button RemoveProject;
    }
}

