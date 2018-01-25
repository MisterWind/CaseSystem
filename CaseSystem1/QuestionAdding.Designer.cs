namespace CaseSystem1
{
    partial class QuestionAdding
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
            this.EntityList = new System.Windows.Forms.ComboBox();
            this.AddEntity = new System.Windows.Forms.Button();
            this.RemoveEntity = new System.Windows.Forms.Button();
            this.dGVEntities = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitEntities = new System.Windows.Forms.Button();
            this.EntitySelection = new System.Windows.Forms.GroupBox();
            this.ConnectList = new System.Windows.Forms.ComboBox();
            this.ValueText = new System.Windows.Forms.TextBox();
            this.EntitiesList = new System.Windows.Forms.ComboBox();
            this.ComparesList = new System.Windows.Forms.ComboBox();
            this.AttributeList = new System.Windows.Forms.ComboBox();
            this.dGVConditions = new System.Windows.Forms.DataGridView();
            this.OrAndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRule = new System.Windows.Forms.Button();
            this.SaveQuestion = new System.Windows.Forms.Button();
            this.ChangeEntities = new System.Windows.Forms.Button();
            this.RemoveRule = new System.Windows.Forms.Button();
            this.NotCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestName = new System.Windows.Forms.TextBox();
            this.QuestDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVAttributes = new System.Windows.Forms.DataGridView();
            this.AtrNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecificationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveAttribute = new System.Windows.Forms.Button();
            this.AddAtribute = new System.Windows.Forms.Button();
            this.TakenAttributeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AttributesAndConditionsSelection = new System.Windows.Forms.GroupBox();
            this.TakenEntities = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEntities)).BeginInit();
            this.EntitySelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttributes)).BeginInit();
            this.AttributesAndConditionsSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите сущности";
            // 
            // EntityList
            // 
            this.EntityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntityList.FormattingEnabled = true;
            this.EntityList.Location = new System.Drawing.Point(51, 110);
            this.EntityList.Name = "EntityList";
            this.EntityList.Size = new System.Drawing.Size(274, 39);
            this.EntityList.TabIndex = 1;
            // 
            // AddEntity
            // 
            this.AddEntity.Location = new System.Drawing.Point(377, 51);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(236, 55);
            this.AddEntity.TabIndex = 2;
            this.AddEntity.Text = "=>";
            this.AddEntity.UseVisualStyleBackColor = true;
            this.AddEntity.Click += new System.EventHandler(this.AddEntity_Click);
            // 
            // RemoveEntity
            // 
            this.RemoveEntity.Location = new System.Drawing.Point(377, 135);
            this.RemoveEntity.Name = "RemoveEntity";
            this.RemoveEntity.Size = new System.Drawing.Size(236, 55);
            this.RemoveEntity.TabIndex = 3;
            this.RemoveEntity.Text = "<=";
            this.RemoveEntity.UseVisualStyleBackColor = true;
            this.RemoveEntity.Click += new System.EventHandler(this.RemoveEntity_Click);
            // 
            // dGVEntities
            // 
            this.dGVEntities.AllowUserToAddRows = false;
            this.dGVEntities.AllowUserToDeleteRows = false;
            this.dGVEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DescriptionColumn});
            this.dGVEntities.Location = new System.Drawing.Point(633, 51);
            this.dGVEntities.MultiSelect = false;
            this.dGVEntities.Name = "dGVEntities";
            this.dGVEntities.ReadOnly = true;
            this.dGVEntities.RowTemplate.Height = 40;
            this.dGVEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEntities.Size = new System.Drawing.Size(1179, 231);
            this.dGVEntities.TabIndex = 4;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameColumn.HeaderText = "Название сущности";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 303;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescriptionColumn.HeaderText = "Описание";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 201;
            // 
            // SubmitEntities
            // 
            this.SubmitEntities.Location = new System.Drawing.Point(51, 209);
            this.SubmitEntities.Name = "SubmitEntities";
            this.SubmitEntities.Size = new System.Drawing.Size(562, 73);
            this.SubmitEntities.TabIndex = 5;
            this.SubmitEntities.Text = "Сохранить сущности для запроса";
            this.SubmitEntities.UseVisualStyleBackColor = true;
            this.SubmitEntities.Click += new System.EventHandler(this.SubmitEntities_Click);
            // 
            // EntitySelection
            // 
            this.EntitySelection.Controls.Add(this.dGVEntities);
            this.EntitySelection.Controls.Add(this.RemoveEntity);
            this.EntitySelection.Controls.Add(this.AddEntity);
            this.EntitySelection.Controls.Add(this.EntityList);
            this.EntitySelection.Controls.Add(this.label1);
            this.EntitySelection.Controls.Add(this.SubmitEntities);
            this.EntitySelection.Location = new System.Drawing.Point(78, 310);
            this.EntitySelection.Name = "EntitySelection";
            this.EntitySelection.Size = new System.Drawing.Size(1860, 305);
            this.EntitySelection.TabIndex = 6;
            this.EntitySelection.TabStop = false;
            this.EntitySelection.Text = "Выбор сущностей";
            // 
            // ConnectList
            // 
            this.ConnectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConnectList.FormattingEnabled = true;
            this.ConnectList.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.ConnectList.Location = new System.Drawing.Point(51, 353);
            this.ConnectList.Name = "ConnectList";
            this.ConnectList.Size = new System.Drawing.Size(183, 39);
            this.ConnectList.TabIndex = 7;
            // 
            // ValueText
            // 
            this.ValueText.Location = new System.Drawing.Point(1133, 353);
            this.ValueText.Multiline = true;
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(434, 39);
            this.ValueText.TabIndex = 12;
            // 
            // EntitiesList
            // 
            this.EntitiesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntitiesList.FormattingEnabled = true;
            this.EntitiesList.Location = new System.Drawing.Point(336, 353);
            this.EntitiesList.Name = "EntitiesList";
            this.EntitiesList.Size = new System.Drawing.Size(277, 39);
            this.EntitiesList.TabIndex = 14;
            this.EntitiesList.SelectedIndexChanged += new System.EventHandler(this.EntitiesList_SelectedIndexChanged);
            // 
            // ComparesList
            // 
            this.ComparesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComparesList.FormattingEnabled = true;
            this.ComparesList.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "=",
            "!="});
            this.ComparesList.Location = new System.Drawing.Point(985, 353);
            this.ComparesList.Name = "ComparesList";
            this.ComparesList.Size = new System.Drawing.Size(122, 39);
            this.ComparesList.TabIndex = 16;
            // 
            // AttributeList
            // 
            this.AttributeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttributeList.FormattingEnabled = true;
            this.AttributeList.Location = new System.Drawing.Point(633, 353);
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.Size = new System.Drawing.Size(330, 39);
            this.AttributeList.TabIndex = 15;
            this.AttributeList.SelectedIndexChanged += new System.EventHandler(this.AttributeList_SelectedIndexChanged);
            // 
            // dGVConditions
            // 
            this.dGVConditions.AllowUserToAddRows = false;
            this.dGVConditions.AllowUserToDeleteRows = false;
            this.dGVConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrAndColumn,
            this.NotColumn,
            this.EntityColumn,
            this.AttributeColumn,
            this.CompareColumn,
            this.ValueColumn});
            this.dGVConditions.Location = new System.Drawing.Point(51, 410);
            this.dGVConditions.MultiSelect = false;
            this.dGVConditions.Name = "dGVConditions";
            this.dGVConditions.ReadOnly = true;
            this.dGVConditions.RowTemplate.Height = 40;
            this.dGVConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVConditions.Size = new System.Drawing.Size(1516, 331);
            this.dGVConditions.TabIndex = 17;
            // 
            // OrAndColumn
            // 
            this.OrAndColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrAndColumn.HeaderText = "Условие соединения";
            this.OrAndColumn.Name = "OrAndColumn";
            this.OrAndColumn.ReadOnly = true;
            this.OrAndColumn.Width = 314;
            // 
            // NotColumn
            // 
            this.NotColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NotColumn.HeaderText = "Условие НЕ";
            this.NotColumn.Name = "NotColumn";
            this.NotColumn.ReadOnly = true;
            this.NotColumn.Width = 208;
            // 
            // EntityColumn
            // 
            this.EntityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EntityColumn.HeaderText = "Сущность";
            this.EntityColumn.Name = "EntityColumn";
            this.EntityColumn.ReadOnly = true;
            this.EntityColumn.Width = 200;
            // 
            // AttributeColumn
            // 
            this.AttributeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttributeColumn.HeaderText = "Атрибут";
            this.AttributeColumn.Name = "AttributeColumn";
            this.AttributeColumn.ReadOnly = true;
            this.AttributeColumn.Width = 176;
            // 
            // CompareColumn
            // 
            this.CompareColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompareColumn.HeaderText = "Знак сравнения";
            this.CompareColumn.Name = "CompareColumn";
            this.CompareColumn.ReadOnly = true;
            this.CompareColumn.Width = 257;
            // 
            // ValueColumn
            // 
            this.ValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValueColumn.HeaderText = "Значение";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            this.ValueColumn.Width = 198;
            // 
            // AddRule
            // 
            this.AddRule.Location = new System.Drawing.Point(1621, 353);
            this.AddRule.Name = "AddRule";
            this.AddRule.Size = new System.Drawing.Size(191, 115);
            this.AddRule.TabIndex = 18;
            this.AddRule.Text = "Добавить условие";
            this.AddRule.UseVisualStyleBackColor = true;
            this.AddRule.Click += new System.EventHandler(this.AddRule_Click);
            // 
            // SaveQuestion
            // 
            this.SaveQuestion.Location = new System.Drawing.Point(1689, 46);
            this.SaveQuestion.Name = "SaveQuestion";
            this.SaveQuestion.Size = new System.Drawing.Size(239, 98);
            this.SaveQuestion.TabIndex = 19;
            this.SaveQuestion.Text = "Сохранить запрос";
            this.SaveQuestion.UseVisualStyleBackColor = true;
            this.SaveQuestion.Click += new System.EventHandler(this.SaveQuestion_Click);
            // 
            // ChangeEntities
            // 
            this.ChangeEntities.Location = new System.Drawing.Point(1621, 626);
            this.ChangeEntities.Name = "ChangeEntities";
            this.ChangeEntities.Size = new System.Drawing.Size(191, 115);
            this.ChangeEntities.TabIndex = 20;
            this.ChangeEntities.Text = "Изменить сущности";
            this.ChangeEntities.UseVisualStyleBackColor = true;
            this.ChangeEntities.Click += new System.EventHandler(this.ChangeEntities_Click);
            // 
            // RemoveRule
            // 
            this.RemoveRule.Location = new System.Drawing.Point(1621, 485);
            this.RemoveRule.Name = "RemoveRule";
            this.RemoveRule.Size = new System.Drawing.Size(191, 115);
            this.RemoveRule.TabIndex = 21;
            this.RemoveRule.Text = "Удалить условие";
            this.RemoveRule.UseVisualStyleBackColor = true;
            this.RemoveRule.Click += new System.EventHandler(this.RemoveRule_Click);
            // 
            // NotCheckBox
            // 
            this.NotCheckBox.AutoSize = true;
            this.NotCheckBox.Location = new System.Drawing.Point(253, 356);
            this.NotCheckBox.Name = "NotCheckBox";
            this.NotCheckBox.Size = new System.Drawing.Size(61, 36);
            this.NotCheckBox.TabIndex = 22;
            this.NotCheckBox.Text = "!";
            this.NotCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1689, 165);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(239, 98);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Название запроса";
            // 
            // QuestName
            // 
            this.QuestName.Location = new System.Drawing.Point(431, 59);
            this.QuestName.Name = "QuestName";
            this.QuestName.Size = new System.Drawing.Size(1191, 38);
            this.QuestName.TabIndex = 24;
            // 
            // QuestDesc
            // 
            this.QuestDesc.Location = new System.Drawing.Point(431, 119);
            this.QuestDesc.Multiline = true;
            this.QuestDesc.Name = "QuestDesc";
            this.QuestDesc.Size = new System.Drawing.Size(1191, 144);
            this.QuestDesc.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Описание запроса";
            // 
            // dGVAttributes
            // 
            this.dGVAttributes.AllowUserToAddRows = false;
            this.dGVAttributes.AllowUserToDeleteRows = false;
            this.dGVAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AtrNameColumn,
            this.AtrDescriptionColumn,
            this.AtrTypeColumn,
            this.SpecificationColumn,
            this.EntityNameColumn});
            this.dGVAttributes.Location = new System.Drawing.Point(633, 52);
            this.dGVAttributes.MultiSelect = false;
            this.dGVAttributes.Name = "dGVAttributes";
            this.dGVAttributes.ReadOnly = true;
            this.dGVAttributes.RowTemplate.Height = 40;
            this.dGVAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAttributes.Size = new System.Drawing.Size(1179, 277);
            this.dGVAttributes.TabIndex = 10;
            // 
            // AtrNameColumn
            // 
            this.AtrNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AtrNameColumn.HeaderText = "Название атрибута";
            this.AtrNameColumn.Name = "AtrNameColumn";
            this.AtrNameColumn.ReadOnly = true;
            this.AtrNameColumn.Width = 297;
            // 
            // AtrDescriptionColumn
            // 
            this.AtrDescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AtrDescriptionColumn.HeaderText = "Описание атрибута";
            this.AtrDescriptionColumn.Name = "AtrDescriptionColumn";
            this.AtrDescriptionColumn.ReadOnly = true;
            this.AtrDescriptionColumn.Width = 300;
            // 
            // AtrTypeColumn
            // 
            this.AtrTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AtrTypeColumn.HeaderText = "Тип атрибута";
            this.AtrTypeColumn.Name = "AtrTypeColumn";
            this.AtrTypeColumn.ReadOnly = true;
            this.AtrTypeColumn.Width = 225;
            // 
            // SpecificationColumn
            // 
            this.SpecificationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SpecificationColumn.HeaderText = "Спецификация";
            this.SpecificationColumn.Name = "SpecificationColumn";
            this.SpecificationColumn.ReadOnly = true;
            this.SpecificationColumn.Width = 269;
            // 
            // EntityNameColumn
            // 
            this.EntityNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EntityNameColumn.HeaderText = "Сущность";
            this.EntityNameColumn.Name = "EntityNameColumn";
            this.EntityNameColumn.ReadOnly = true;
            this.EntityNameColumn.Width = 200;
            // 
            // RemoveAttribute
            // 
            this.RemoveAttribute.Location = new System.Drawing.Point(377, 160);
            this.RemoveAttribute.Name = "RemoveAttribute";
            this.RemoveAttribute.Size = new System.Drawing.Size(236, 55);
            this.RemoveAttribute.TabIndex = 9;
            this.RemoveAttribute.Text = "<=";
            this.RemoveAttribute.UseVisualStyleBackColor = true;
            this.RemoveAttribute.Click += new System.EventHandler(this.RemoveAttribute_Click);
            // 
            // AddAtribute
            // 
            this.AddAtribute.Location = new System.Drawing.Point(377, 89);
            this.AddAtribute.Name = "AddAtribute";
            this.AddAtribute.Size = new System.Drawing.Size(236, 55);
            this.AddAtribute.TabIndex = 8;
            this.AddAtribute.Text = "=>";
            this.AddAtribute.UseVisualStyleBackColor = true;
            this.AddAtribute.Click += new System.EventHandler(this.AddAtribute_Click);
            // 
            // TakenAttributeCombo
            // 
            this.TakenAttributeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TakenAttributeCombo.FormattingEnabled = true;
            this.TakenAttributeCombo.Location = new System.Drawing.Point(51, 236);
            this.TakenAttributeCombo.Name = "TakenAttributeCombo";
            this.TakenAttributeCombo.Size = new System.Drawing.Size(274, 39);
            this.TakenAttributeCombo.TabIndex = 7;
            this.TakenAttributeCombo.SelectedIndexChanged += new System.EventHandler(this.TakenAttributeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите атрибуты";
            // 
            // AttributesAndConditionsSelection
            // 
            this.AttributesAndConditionsSelection.Controls.Add(this.TakenEntities);
            this.AttributesAndConditionsSelection.Controls.Add(this.label5);
            this.AttributesAndConditionsSelection.Controls.Add(this.NotCheckBox);
            this.AttributesAndConditionsSelection.Controls.Add(this.dGVAttributes);
            this.AttributesAndConditionsSelection.Controls.Add(this.RemoveRule);
            this.AttributesAndConditionsSelection.Controls.Add(this.RemoveAttribute);
            this.AttributesAndConditionsSelection.Controls.Add(this.ChangeEntities);
            this.AttributesAndConditionsSelection.Controls.Add(this.AddRule);
            this.AttributesAndConditionsSelection.Controls.Add(this.AddAtribute);
            this.AttributesAndConditionsSelection.Controls.Add(this.dGVConditions);
            this.AttributesAndConditionsSelection.Controls.Add(this.TakenAttributeCombo);
            this.AttributesAndConditionsSelection.Controls.Add(this.ComparesList);
            this.AttributesAndConditionsSelection.Controls.Add(this.label4);
            this.AttributesAndConditionsSelection.Controls.Add(this.AttributeList);
            this.AttributesAndConditionsSelection.Controls.Add(this.ConnectList);
            this.AttributesAndConditionsSelection.Controls.Add(this.EntitiesList);
            this.AttributesAndConditionsSelection.Controls.Add(this.ValueText);
            this.AttributesAndConditionsSelection.Location = new System.Drawing.Point(78, 641);
            this.AttributesAndConditionsSelection.Name = "AttributesAndConditionsSelection";
            this.AttributesAndConditionsSelection.Size = new System.Drawing.Size(1860, 778);
            this.AttributesAndConditionsSelection.TabIndex = 27;
            this.AttributesAndConditionsSelection.TabStop = false;
            this.AttributesAndConditionsSelection.Text = "Выбор выводимых атрибутов и формулирование условий";
            // 
            // TakenEntities
            // 
            this.TakenEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TakenEntities.FormattingEnabled = true;
            this.TakenEntities.Location = new System.Drawing.Point(51, 120);
            this.TakenEntities.Name = "TakenEntities";
            this.TakenEntities.Size = new System.Drawing.Size(274, 39);
            this.TakenEntities.TabIndex = 24;
            this.TakenEntities.SelectedIndexChanged += new System.EventHandler(this.TakenEntities_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Выберите сущности";
            // 
            // QuestionAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1990, 1443);
            this.Controls.Add(this.AttributesAndConditionsSelection);
            this.Controls.Add(this.QuestDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EntitySelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestName);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveQuestion);
            this.Name = "QuestionAdding";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Добавление запроса";
            this.Load += new System.EventHandler(this.QuestionAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEntities)).EndInit();
            this.EntitySelection.ResumeLayout(false);
            this.EntitySelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttributes)).EndInit();
            this.AttributesAndConditionsSelection.ResumeLayout(false);
            this.AttributesAndConditionsSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EntityList;
        private System.Windows.Forms.Button AddEntity;
        private System.Windows.Forms.Button RemoveEntity;
        private System.Windows.Forms.DataGridView dGVEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.Button SubmitEntities;
        private System.Windows.Forms.GroupBox EntitySelection;
        private System.Windows.Forms.ComboBox ConnectList;
        private System.Windows.Forms.TextBox ValueText;
        private System.Windows.Forms.ComboBox EntitiesList;
        private System.Windows.Forms.ComboBox ComparesList;
        private System.Windows.Forms.ComboBox AttributeList;
        private System.Windows.Forms.DataGridView dGVConditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrAndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.Button AddRule;
        private System.Windows.Forms.Button SaveQuestion;
        private System.Windows.Forms.Button ChangeEntities;
        private System.Windows.Forms.Button RemoveRule;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox NotCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuestName;
        private System.Windows.Forms.TextBox QuestDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtrNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtrDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtrTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecificationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityNameColumn;
        private System.Windows.Forms.Button RemoveAttribute;
        private System.Windows.Forms.Button AddAtribute;
        private System.Windows.Forms.ComboBox TakenAttributeCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox AttributesAndConditionsSelection;
        private System.Windows.Forms.ComboBox TakenEntities;
        private System.Windows.Forms.Label label5;
    }
}