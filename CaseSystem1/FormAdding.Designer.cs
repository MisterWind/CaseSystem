namespace CaseSystem1
{
    partial class FormAdding
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
            this.label5 = new System.Windows.Forms.Label();
            this.FormNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FormTypesList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateForma = new System.Windows.Forms.Button();
            this.DescriptionFormTB = new System.Windows.Forms.TextBox();
            this.dGVAttributes = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecificationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeAttribute = new System.Windows.Forms.Button();
            this.RemoveAttribute = new System.Windows.Forms.Button();
            this.AddAttribute = new System.Windows.Forms.Button();
            this.AttributeList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EntityList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 910);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "Описание формы";
            // 
            // FormNameTB
            // 
            this.FormNameTB.Location = new System.Drawing.Point(346, 831);
            this.FormNameTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FormNameTB.Name = "FormNameTB";
            this.FormNameTB.Size = new System.Drawing.Size(577, 38);
            this.FormNameTB.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 839);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Название формы";
            // 
            // FormTypesList
            // 
            this.FormTypesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormTypesList.FormattingEnabled = true;
            this.FormTypesList.Location = new System.Drawing.Point(234, 769);
            this.FormTypesList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FormTypesList.Name = "FormTypesList";
            this.FormTypesList.Size = new System.Drawing.Size(689, 39);
            this.FormTypesList.TabIndex = 27;
            this.FormTypesList.SelectedIndexChanged += new System.EventHandler(this.FormTypesList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 777);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Тип формы";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(167, 1113);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(373, 55);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateForma
            // 
            this.CreateForma.Location = new System.Drawing.Point(557, 1113);
            this.CreateForma.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CreateForma.Name = "CreateForma";
            this.CreateForma.Size = new System.Drawing.Size(371, 55);
            this.CreateForma.TabIndex = 24;
            this.CreateForma.Text = "Создать форму";
            this.CreateForma.UseVisualStyleBackColor = true;
            this.CreateForma.Click += new System.EventHandler(this.CreateForma_Click);
            // 
            // DescriptionFormTB
            // 
            this.DescriptionFormTB.Location = new System.Drawing.Point(346, 896);
            this.DescriptionFormTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DescriptionFormTB.Multiline = true;
            this.DescriptionFormTB.Name = "DescriptionFormTB";
            this.DescriptionFormTB.Size = new System.Drawing.Size(575, 197);
            this.DescriptionFormTB.TabIndex = 30;
            // 
            // dGVAttributes
            // 
            this.dGVAttributes.AllowUserToAddRows = false;
            this.dGVAttributes.AllowUserToDeleteRows = false;
            this.dGVAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TypeColumn,
            this.SpecificationColumn});
            this.dGVAttributes.Location = new System.Drawing.Point(45, 364);
            this.dGVAttributes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dGVAttributes.MultiSelect = false;
            this.dGVAttributes.Name = "dGVAttributes";
            this.dGVAttributes.ReadOnly = true;
            this.dGVAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAttributes.Size = new System.Drawing.Size(888, 396);
            this.dGVAttributes.TabIndex = 23;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameColumn.HeaderText = "Название атрибута";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 297;
            // 
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeColumn.HeaderText = "Тип атрибута";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 225;
            // 
            // SpecificationColumn
            // 
            this.SpecificationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SpecificationColumn.HeaderText = "Спецификация";
            this.SpecificationColumn.Name = "SpecificationColumn";
            this.SpecificationColumn.ReadOnly = true;
            this.SpecificationColumn.Width = 269;
            // 
            // ChangeAttribute
            // 
            this.ChangeAttribute.Location = new System.Drawing.Point(346, 269);
            this.ChangeAttribute.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ChangeAttribute.Name = "ChangeAttribute";
            this.ChangeAttribute.Size = new System.Drawing.Size(285, 55);
            this.ChangeAttribute.TabIndex = 22;
            this.ChangeAttribute.Text = "Заменить";
            this.ChangeAttribute.UseVisualStyleBackColor = true;
            this.ChangeAttribute.Click += new System.EventHandler(this.ChangeAttribute_Click);
            // 
            // RemoveAttribute
            // 
            this.RemoveAttribute.Location = new System.Drawing.Point(647, 269);
            this.RemoveAttribute.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RemoveAttribute.Name = "RemoveAttribute";
            this.RemoveAttribute.Size = new System.Drawing.Size(285, 55);
            this.RemoveAttribute.TabIndex = 21;
            this.RemoveAttribute.Text = "Удалить";
            this.RemoveAttribute.UseVisualStyleBackColor = true;
            this.RemoveAttribute.Click += new System.EventHandler(this.RemoveAttribute_Click);
            // 
            // AddAttribute
            // 
            this.AddAttribute.Location = new System.Drawing.Point(45, 269);
            this.AddAttribute.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddAttribute.Name = "AddAttribute";
            this.AddAttribute.Size = new System.Drawing.Size(285, 55);
            this.AddAttribute.TabIndex = 20;
            this.AddAttribute.Text = "Добавить";
            this.AddAttribute.UseVisualStyleBackColor = true;
            this.AddAttribute.Click += new System.EventHandler(this.AddAttribute_Click);
            // 
            // AttributeList
            // 
            this.AttributeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttributeList.FormattingEnabled = true;
            this.AttributeList.Location = new System.Drawing.Point(45, 202);
            this.AttributeList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.Size = new System.Drawing.Size(881, 39);
            this.AttributeList.TabIndex = 19;
            this.AttributeList.SelectedIndexChanged += new System.EventHandler(this.AttributeList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(791, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Укажите атрибты, которые необходимо вывести на форму";
            // 
            // EntityList
            // 
            this.EntityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntityList.FormattingEnabled = true;
            this.EntityList.Location = new System.Drawing.Point(290, 56);
            this.EntityList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EntityList.Name = "EntityList";
            this.EntityList.Size = new System.Drawing.Size(636, 39);
            this.EntityList.TabIndex = 17;
            this.EntityList.SelectedIndexChanged += new System.EventHandler(this.EntityList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Сущность";
            // 
            // FormAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 1225);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FormNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FormTypesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateForma);
            this.Controls.Add(this.DescriptionFormTB);
            this.Controls.Add(this.dGVAttributes);
            this.Controls.Add(this.ChangeAttribute);
            this.Controls.Add(this.RemoveAttribute);
            this.Controls.Add(this.AddAttribute);
            this.Controls.Add(this.AttributeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntityList);
            this.Controls.Add(this.label1);
            this.Name = "FormAdding";
            this.Text = "Добавление формы";
            this.Load += new System.EventHandler(this.FormAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FormNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FormTypesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateForma;
        private System.Windows.Forms.TextBox DescriptionFormTB;
        private System.Windows.Forms.DataGridView dGVAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecificationColumn;
        private System.Windows.Forms.Button ChangeAttribute;
        private System.Windows.Forms.Button RemoveAttribute;
        private System.Windows.Forms.Button AddAttribute;
        private System.Windows.Forms.ComboBox AttributeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EntityList;
        private System.Windows.Forms.Label label1;
    }
}