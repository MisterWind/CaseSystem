namespace CaseSystem1
{
    partial class FrEntityView
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
            this.butChange = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.dGVEnAt = new System.Windows.Forms.DataGridView();
            this.DescrbEntityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameEntityCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butDeleteEntity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnAt)).BeginInit();
            this.SuspendLayout();
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(936, 774);
            this.butChange.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(392, 55);
            this.butChange.TabIndex = 26;
            this.butChange.Text = "Изменить сущность";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(1344, 774);
            this.CancelBut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(200, 55);
            this.CancelBut.TabIndex = 25;
            this.CancelBut.Text = "Назад";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // dGVEnAt
            // 
            this.dGVEnAt.AllowUserToAddRows = false;
            this.dGVEnAt.AllowUserToDeleteRows = false;
            this.dGVEnAt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEnAt.Location = new System.Drawing.Point(43, 190);
            this.dGVEnAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dGVEnAt.MultiSelect = false;
            this.dGVEnAt.Name = "dGVEnAt";
            this.dGVEnAt.ReadOnly = true;
            this.dGVEnAt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnAt.Size = new System.Drawing.Size(1501, 570);
            this.dGVEnAt.TabIndex = 24;
            // 
            // DescrbEntityTB
            // 
            this.DescrbEntityTB.Enabled = false;
            this.DescrbEntityTB.Location = new System.Drawing.Point(342, 97);
            this.DescrbEntityTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DescrbEntityTB.Name = "DescrbEntityTB";
            this.DescrbEntityTB.Size = new System.Drawing.Size(1196, 38);
            this.DescrbEntityTB.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Описание сущности";
            // 
            // NameEntityCB
            // 
            this.NameEntityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NameEntityCB.Enabled = false;
            this.NameEntityCB.FormattingEnabled = true;
            this.NameEntityCB.Location = new System.Drawing.Point(342, 25);
            this.NameEntityCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameEntityCB.Name = "NameEntityCB";
            this.NameEntityCB.Size = new System.Drawing.Size(1196, 45);
            this.NameEntityCB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название сущности";
            // 
            // butDeleteEntity
            // 
            this.butDeleteEntity.Location = new System.Drawing.Point(528, 774);
            this.butDeleteEntity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.butDeleteEntity.Name = "butDeleteEntity";
            this.butDeleteEntity.Size = new System.Drawing.Size(392, 55);
            this.butDeleteEntity.TabIndex = 27;
            this.butDeleteEntity.Text = "Удалить сущность";
            this.butDeleteEntity.UseVisualStyleBackColor = true;
            this.butDeleteEntity.Click += new System.EventHandler(this.butDeleteEntity_Click);
            // 
            // FrEntityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 865);
            this.Controls.Add(this.butDeleteEntity);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.dGVEnAt);
            this.Controls.Add(this.DescrbEntityTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameEntityCB);
            this.Controls.Add(this.label1);
            this.Name = "FrEntityView";
            this.Text = "Просмотр информации о сущности";
            this.Load += new System.EventHandler(this.FrEntityView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.DataGridView dGVEnAt;
        public System.Windows.Forms.TextBox DescrbEntityTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox NameEntityCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDeleteEntity;
    }
}