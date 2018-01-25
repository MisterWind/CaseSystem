namespace CaseSystem1
{
    partial class FormOpening
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
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LastValueButton = new System.Windows.Forms.Button();
            this.NextValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(1144, 24);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(265, 91);
            this.SaveChangesButton.TabIndex = 0;
            this.SaveChangesButton.Text = "Сохранить";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(853, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(274, 91);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LastValueButton
            // 
            this.LastValueButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LastValueButton.Location = new System.Drawing.Point(48, 24);
            this.LastValueButton.Name = "LastValueButton";
            this.LastValueButton.Size = new System.Drawing.Size(75, 90);
            this.LastValueButton.TabIndex = 2;
            this.LastValueButton.Text = "<=";
            this.LastValueButton.UseVisualStyleBackColor = false;
            this.LastValueButton.Visible = false;
            // 
            // NextValueButton
            // 
            this.NextValueButton.BackColor = System.Drawing.Color.SkyBlue;
            this.NextValueButton.Location = new System.Drawing.Point(141, 24);
            this.NextValueButton.Name = "NextValueButton";
            this.NextValueButton.Size = new System.Drawing.Size(75, 90);
            this.NextValueButton.TabIndex = 3;
            this.NextValueButton.Text = "=>";
            this.NextValueButton.UseVisualStyleBackColor = false;
            this.NextValueButton.Visible = false;
            // 
            // FormOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 1022);
            this.Controls.Add(this.NextValueButton);
            this.Controls.Add(this.LastValueButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Name = "FormOpening";
            this.Text = "FormOpening";
            this.Load += new System.EventHandler(this.FormOpening_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LastValueButton;
        private System.Windows.Forms.Button NextValueButton;
    }
}