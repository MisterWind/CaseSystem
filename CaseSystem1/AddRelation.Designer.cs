namespace CaseSystem1
{
    partial class AddRelation
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
            this.label2 = new System.Windows.Forms.Label();
            this.NameTBRelation = new System.Windows.Forms.TextBox();
            this.DescTBRelation = new System.Windows.Forms.TextBox();
            this.ComboBoxEntity1 = new System.Windows.Forms.ComboBox();
            this.ComboBoxEntity2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxK = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BAddRelation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBAttDesc1 = new System.Windows.Forms.TextBox();
            this.TextBAtt1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBAtt2 = new System.Windows.Forms.TextBox();
            this.TextBAttDesc2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название связи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание связи:";
            // 
            // NameTBRelation
            // 
            this.NameTBRelation.Location = new System.Drawing.Point(109, 100);
            this.NameTBRelation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameTBRelation.Name = "NameTBRelation";
            this.NameTBRelation.Size = new System.Drawing.Size(961, 38);
            this.NameTBRelation.TabIndex = 2;
            // 
            // DescTBRelation
            // 
            this.DescTBRelation.Location = new System.Drawing.Point(109, 200);
            this.DescTBRelation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DescTBRelation.Name = "DescTBRelation";
            this.DescTBRelation.Size = new System.Drawing.Size(961, 38);
            this.DescTBRelation.TabIndex = 3;
            // 
            // ComboBoxEntity1
            // 
            this.ComboBoxEntity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEntity1.FormattingEnabled = true;
            this.ComboBoxEntity1.Location = new System.Drawing.Point(109, 317);
            this.ComboBoxEntity1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ComboBoxEntity1.Name = "ComboBoxEntity1";
            this.ComboBoxEntity1.Size = new System.Drawing.Size(353, 39);
            this.ComboBoxEntity1.TabIndex = 4;
            this.ComboBoxEntity1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEntity1_SelectedIndexChanged);
            this.ComboBoxEntity1.SelectedValueChanged += new System.EventHandler(this.ComboBoxEntity1_SelectedIndexChanged);
            // 
            // ComboBoxEntity2
            // 
            this.ComboBoxEntity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEntity2.FormattingEnabled = true;
            this.ComboBoxEntity2.Location = new System.Drawing.Point(709, 317);
            this.ComboBoxEntity2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ComboBoxEntity2.Name = "ComboBoxEntity2";
            this.ComboBoxEntity2.Size = new System.Drawing.Size(361, 39);
            this.ComboBoxEntity2.TabIndex = 5;
            this.ComboBoxEntity2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEntity2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сущность 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сущность 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кратность:";
            // 
            // ComboBoxK
            // 
            this.ComboBoxK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxK.FormattingEnabled = true;
            this.ComboBoxK.Items.AddRange(new object[] {
            "0..1:0..1",
            "0..1:1",
            "0..1:*",
            "1:0..1",
            "1:1",
            "1:*",
            "*:0..1",
            "*:1",
            "*:*"});
            this.ComboBoxK.Location = new System.Drawing.Point(485, 317);
            this.ComboBoxK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ComboBoxK.Name = "ComboBoxK";
            this.ComboBoxK.Size = new System.Drawing.Size(193, 39);
            this.ComboBoxK.TabIndex = 10;
            this.ComboBoxK.SelectedIndexChanged += new System.EventHandler(this.ComboBoxK_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(824, 873);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(253, 69);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BAddRelation
            // 
            this.BAddRelation.Location = new System.Drawing.Point(528, 873);
            this.BAddRelation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BAddRelation.Name = "BAddRelation";
            this.BAddRelation.Size = new System.Drawing.Size(259, 69);
            this.BAddRelation.TabIndex = 12;
            this.BAddRelation.Text = "Добавить";
            this.BAddRelation.UseVisualStyleBackColor = true;
            this.BAddRelation.Click += new System.EventHandler(this.BAddRelation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBAttDesc1);
            this.groupBox1.Controls.Add(this.TextBAtt1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(109, 408);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(461, 403);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Атрибут-источник";
            // 
            // TextBAttDesc1
            // 
            this.TextBAttDesc1.Location = new System.Drawing.Point(27, 198);
            this.TextBAttDesc1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextBAttDesc1.Multiline = true;
            this.TextBAttDesc1.Name = "TextBAttDesc1";
            this.TextBAttDesc1.Size = new System.Drawing.Size(412, 154);
            this.TextBAttDesc1.TabIndex = 3;
            // 
            // TextBAtt1
            // 
            this.TextBAtt1.Location = new System.Drawing.Point(27, 88);
            this.TextBAtt1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextBAtt1.Name = "TextBAtt1";
            this.TextBAtt1.Size = new System.Drawing.Size(412, 38);
            this.TextBAtt1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Описание:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBAtt2);
            this.groupBox2.Controls.Add(this.TextBAttDesc2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(611, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(467, 403);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Атрибут-приемник";
            // 
            // TextBAtt2
            // 
            this.TextBAtt2.Location = new System.Drawing.Point(24, 88);
            this.TextBAtt2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextBAtt2.Name = "TextBAtt2";
            this.TextBAtt2.Size = new System.Drawing.Size(420, 38);
            this.TextBAtt2.TabIndex = 3;
            // 
            // TextBAttDesc2
            // 
            this.TextBAttDesc2.Location = new System.Drawing.Point(24, 198);
            this.TextBAttDesc2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextBAttDesc2.Multiline = true;
            this.TextBAttDesc2.Name = "TextBAttDesc2";
            this.TextBAttDesc2.Size = new System.Drawing.Size(420, 154);
            this.TextBAttDesc2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Описание:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Название:";
            // 
            // AddRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 971);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BAddRelation);
            this.Controls.Add(this.ComboBoxK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxEntity2);
            this.Controls.Add(this.ComboBoxEntity1);
            this.Controls.Add(this.DescTBRelation);
            this.Controls.Add(this.NameTBRelation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddRelation";
            this.Text = "Добавление связи";
            this.Load += new System.EventHandler(this.AddRelation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTBRelation;
        private System.Windows.Forms.TextBox DescTBRelation;
        private System.Windows.Forms.ComboBox ComboBoxEntity1;
        private System.Windows.Forms.ComboBox ComboBoxEntity2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxK;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BAddRelation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBAttDesc1;
        private System.Windows.Forms.TextBox TextBAtt1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBAtt2;
        private System.Windows.Forms.TextBox TextBAttDesc2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}