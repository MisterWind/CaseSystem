namespace CaseSystem1
{
    partial class FrProjects
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
            this.ProjectsList = new System.Windows.Forms.ComboBox();
            this.CreateProject = new System.Windows.Forms.Button();
            this.OpenProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проекты";
            // 
            // ProjectsList
            // 
            this.ProjectsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectsList.FormattingEnabled = true;
            this.ProjectsList.Location = new System.Drawing.Point(163, 34);
            this.ProjectsList.Name = "ProjectsList";
            this.ProjectsList.Size = new System.Drawing.Size(526, 39);
            this.ProjectsList.TabIndex = 1;
            // 
            // CreateProject
            // 
            this.CreateProject.Location = new System.Drawing.Point(19, 97);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(329, 70);
            this.CreateProject.TabIndex = 2;
            this.CreateProject.Text = "Создать";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // OpenProject
            // 
            this.OpenProject.Location = new System.Drawing.Point(354, 97);
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.Size = new System.Drawing.Size(335, 70);
            this.OpenProject.TabIndex = 3;
            this.OpenProject.Text = "Открыть";
            this.OpenProject.UseVisualStyleBackColor = true;
            this.OpenProject.Click += new System.EventHandler(this.OpenProject_Click);
            // 
            // FrProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 208);
            this.Controls.Add(this.OpenProject);
            this.Controls.Add(this.CreateProject);
            this.Controls.Add(this.ProjectsList);
            this.Controls.Add(this.label1);
            this.Name = "FrProjects";
            this.Text = "Проект";
            this.Load += new System.EventHandler(this.FrProjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjectsList;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.Button OpenProject;
    }
}