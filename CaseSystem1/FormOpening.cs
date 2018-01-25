using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseSystem1
{
    public partial class FormOpening : Form
    {
        //не завершенный блок
        public FormOpening()
        {
            InitializeComponent();
        }

        CaseModelContainer cont = new CaseModelContainer();
        public int curProjId;
        DataBaseProject dBS;
        public int curFormId;
        Forma curForm;
        //поменять на списки
        const int lengthArray = 10;
        Control[] textBoxArray = new Control[lengthArray];
        Control[] labelArray = new Control[lengthArray];
        Control[] comboBoxArray = new Control[lengthArray];
        Control[] checkBoxArray = new Control[lengthArray];
        int labelCounter = -1;
        int comboBoxCounter = -1;
        int textBoxCounter = -1;
        int checkBoxCounter = -1;

        //генерация элементов формы
        private void FormOpening_Load(object sender, EventArgs e)
        {
            dBS = cont.DataBaseProjectSet.Find(curProjId);
            curForm = cont.FormaSet.Find(curFormId);
            foreach (ControlElement localElement in cont.ControlElementSet)
                if (localElement.Forma.Id == curFormId)
                {
                    switch (localElement.TypeControlElement.Name)   //обход контрольных элементов
                    {
                        case "Label":
                            labelCounter++;
                            labelArray[labelCounter] = new Label() { Name = labelCounter.ToString(), Location = new Point(localElement.PositionX, localElement.PositionY), Width = localElement.Length, Height = localElement.Width, Text = localElement.Attribute.Name, Visible = true };
                            this.Controls.Add(labelArray[labelCounter]);
                            break;
                        //условие для Combobox 
                        case "ComboBox":
                            comboBoxCounter++;
                            comboBoxArray[comboBoxCounter] = new ComboBox() { Name = comboBoxCounter.ToString(), Location = new Point(localElement.PositionX, localElement.PositionY), Width = localElement.Length, Height = localElement.Width, Visible = true };
                            //items!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
                            this.Controls.Add(comboBoxArray[comboBoxCounter]);
                            break;
                        //условие для CheckBox 
                        case "CheckBox":
                            checkBoxCounter++;
                            checkBoxArray[checkBoxCounter] = new CheckBox() { Name = checkBoxCounter.ToString(), Location = new Point(localElement.PositionX, localElement.PositionY), Width = localElement.Length, Height = localElement.Width, Visible = true };
                            this.Controls.Add(checkBoxArray[checkBoxCounter]);
                            break;
                        //TextBox 
                        case "TextBox":
                            textBoxCounter++;
                            textBoxArray[textBoxCounter] = new TextBox() { Name = textBoxCounter.ToString(), Location = new Point(localElement.PositionX, localElement.PositionY), Width = localElement.Length, Height = localElement.Width, Visible = true };
                            this.Controls.Add(textBoxArray[textBoxCounter]);
                            break;
                    }
                }
        }

        //возвращение на главную форму
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            FrMain main = new FrMain();
            main.currentDBS = curProjId;
            main.ShowDialog();
            Close();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
