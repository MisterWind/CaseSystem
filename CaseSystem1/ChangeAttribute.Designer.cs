namespace CaseSystem1
{
    partial class ChangeAttribute
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
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeAttribute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteAttribute = new System.Windows.Forms.Button();
            this.ChangeAttr = new System.Windows.Forms.Button();
            this.AddAttribute = new System.Windows.Forms.Button();
            this.textBoxDescriptio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AtNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGVChange = new System.Windows.Forms.DataGridView();
            this.NameAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.comboBoxChangeEntity = new System.Windows.Forms.ComboBox();
            this.butChange_1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVChange)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Location = new System.Drawing.Point(324, 109);
            this.textBoxDescr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(1153, 38);
            this.textBoxDescr.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Описание сущности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название сущности";
            // 
            // TypeAttribute
            // 
            this.TypeAttribute.FormattingEnabled = true;
            this.TypeAttribute.Location = new System.Drawing.Point(192, 238);
            this.TypeAttribute.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TypeAttribute.Name = "TypeAttribute";
            this.TypeAttribute.Size = new System.Drawing.Size(311, 39);
            this.TypeAttribute.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Тип атрибута";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butChange_1);
            this.groupBox1.Controls.Add(this.TypeAttribute);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TypeComboBox);
            this.groupBox1.Controls.Add(this.DeleteAttribute);
            this.groupBox1.Controls.Add(this.ChangeAttr);
            this.groupBox1.Controls.Add(this.AddAttribute);
            this.groupBox1.Controls.Add(this.textBoxDescriptio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AtNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(547, 453);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Атрибут";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(192, 174);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(311, 39);
            this.TypeComboBox.TabIndex = 11;
            // 
            // DeleteAttribute
            // 
            this.DeleteAttribute.Location = new System.Drawing.Point(225, 315);
            this.DeleteAttribute.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeleteAttribute.Name = "DeleteAttribute";
            this.DeleteAttribute.Size = new System.Drawing.Size(200, 55);
            this.DeleteAttribute.TabIndex = 10;
            this.DeleteAttribute.Text = "Удалить";
            this.DeleteAttribute.UseVisualStyleBackColor = true;
            this.DeleteAttribute.Click += new System.EventHandler(this.DeleteAttribute_Click);
            // 
            // ChangeAttr
            // 
            this.ChangeAttr.Location = new System.Drawing.Point(6, 384);
            this.ChangeAttr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ChangeAttr.Name = "ChangeAttr";
            this.ChangeAttr.Size = new System.Drawing.Size(200, 55);
            this.ChangeAttr.TabIndex = 9;
            this.ChangeAttr.Text = "Изменить";
            this.ChangeAttr.UseVisualStyleBackColor = true;
            this.ChangeAttr.Click += new System.EventHandler(this.ChangeAttr_Click);
            // 
            // AddAttribute
            // 
            this.AddAttribute.Location = new System.Drawing.Point(6, 315);
            this.AddAttribute.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddAttribute.Name = "AddAttribute";
            this.AddAttribute.Size = new System.Drawing.Size(203, 55);
            this.AddAttribute.TabIndex = 8;
            this.AddAttribute.Text = "Добавить";
            this.AddAttribute.UseVisualStyleBackColor = true;
            this.AddAttribute.Click += new System.EventHandler(this.AddAttribute_Click);
            // 
            // textBoxDescriptio
            // 
            this.textBoxDescriptio.Location = new System.Drawing.Point(192, 112);
            this.textBoxDescriptio.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxDescriptio.Name = "textBoxDescriptio";
            this.textBoxDescriptio.Size = new System.Drawing.Size(311, 38);
            this.textBoxDescriptio.TabIndex = 7;
            this.textBoxDescriptio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescriptio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип данных";
            // 
            // AtNameTextBox
            // 
            this.AtNameTextBox.Location = new System.Drawing.Point(192, 52);
            this.AtNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AtNameTextBox.Name = "AtNameTextBox";
            this.AtNameTextBox.Size = new System.Drawing.Size(311, 38);
            this.AtNameTextBox.TabIndex = 3;
            this.AtNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AtNameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // dataGVChange
            // 
            this.dataGVChange.AllowUserToAddRows = false;
            this.dataGVChange.AllowUserToDeleteRows = false;
            this.dataGVChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameAt,
            this.Description,
            this.Type,
            this.TypeAt});
            this.dataGVChange.Location = new System.Drawing.Point(580, 224);
            this.dataGVChange.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGVChange.MultiSelect = false;
            this.dataGVChange.Name = "dataGVChange";
            this.dataGVChange.ReadOnly = true;
            this.dataGVChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVChange.Size = new System.Drawing.Size(1181, 384);
            this.dataGVChange.TabIndex = 23;
            // 
            // NameAt
            // 
            this.NameAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameAt.HeaderText = "Название";
            this.NameAt.Name = "NameAt";
            this.NameAt.ReadOnly = true;
            this.NameAt.Width = 198;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 201;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.HeaderText = "Тип данных";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 206;
            // 
            // TypeAt
            // 
            this.TypeAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeAt.HeaderText = "Тип Атрибута";
            this.TypeAt.Name = "TypeAt";
            this.TypeAt.ReadOnly = true;
            this.TypeAt.Width = 228;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1386, 622);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(375, 55);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Завершить изменения";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // comboBoxChangeEntity
            // 
            this.comboBoxChangeEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxChangeEntity.FormattingEnabled = true;
            this.comboBoxChangeEntity.Location = new System.Drawing.Point(324, 24);
            this.comboBoxChangeEntity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxChangeEntity.Name = "comboBoxChangeEntity";
            this.comboBoxChangeEntity.Size = new System.Drawing.Size(1153, 45);
            this.comboBoxChangeEntity.TabIndex = 26;
            // 
            // butChange_1
            // 
            this.butChange_1.Location = new System.Drawing.Point(225, 384);
            this.butChange_1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.butChange_1.Name = "butChange_1";
            this.butChange_1.Size = new System.Drawing.Size(320, 55);
            this.butChange_1.TabIndex = 29;
            this.butChange_1.Text = "Сохранить изменения";
            this.butChange_1.UseVisualStyleBackColor = true;
            this.butChange_1.Click += new System.EventHandler(this.butChange_1_Click);
            // 
            // ChangeAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 726);
            this.Controls.Add(this.textBoxDescr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGVChange);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.comboBoxChangeEntity);
            this.Name = "ChangeAttribute";
            this.Text = "Изменение атрибутов сущности";
            this.Load += new System.EventHandler(this.ChangeAttribute_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxDescr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeAttribute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button DeleteAttribute;
        private System.Windows.Forms.Button ChangeAttr;
        private System.Windows.Forms.Button AddAttribute;
        private System.Windows.Forms.TextBox textBoxDescriptio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AtNameTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGVChange;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.ComboBox comboBoxChangeEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeAt;
        private System.Windows.Forms.Button butChange_1;
    }
}