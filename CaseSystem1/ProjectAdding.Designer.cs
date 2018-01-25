namespace CaseSystem1
{
    partial class ProjectAdding
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectDscr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(182, 34);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(495, 38);
            this.ProjectName.TabIndex = 1;
            this.ProjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectName_KeyPress);
            // 
            // ProjectDscr
            // 
            this.ProjectDscr.Location = new System.Drawing.Point(182, 87);
            this.ProjectDscr.Multiline = true;
            this.ProjectDscr.Name = "ProjectDscr";
            this.ProjectDscr.Size = new System.Drawing.Size(495, 233);
            this.ProjectDscr.TabIndex = 3;
            this.ProjectDscr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectDscr_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(182, 340);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(238, 56);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveProject
            // 
            this.SaveProject.Location = new System.Drawing.Point(445, 340);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(232, 56);
            this.SaveProject.TabIndex = 5;
            this.SaveProject.Text = "Сохранить";
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // ProjectAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.SaveProject);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProjectDscr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label1);
            this.Name = "ProjectAdding";
            this.Text = "Добавление проекта";
            this.Load += new System.EventHandler(this.ProjectAdding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectDscr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveProject;
    }
}