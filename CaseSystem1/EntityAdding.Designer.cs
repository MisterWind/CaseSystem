namespace CaseSystem1
{
    partial class EntityAdding
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddEntity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(641, 182);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(253, 69);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEntity
            // 
            this.AddEntity.Location = new System.Drawing.Point(366, 182);
            this.AddEntity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(259, 69);
            this.AddEntity.TabIndex = 10;
            this.AddEntity.Text = "Сохранить";
            this.AddEntity.UseVisualStyleBackColor = true;
            this.AddEntity.Click += new System.EventHandler(this.AddEntity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Описание сущности";
            // 
            // DescripionTextBox
            // 
            this.DescripionTextBox.Location = new System.Drawing.Point(375, 111);
            this.DescripionTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DescripionTextBox.Name = "DescripionTextBox";
            this.DescripionTextBox.Size = new System.Drawing.Size(519, 38);
            this.DescripionTextBox.TabIndex = 8;
            this.DescripionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripionTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название сущности";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(378, 44);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(519, 38);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // EntityAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 285);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddEntity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescripionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "EntityAdding";
            this.Text = "Добавление сущности";
            this.Load += new System.EventHandler(this.EntityAdding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddEntity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}