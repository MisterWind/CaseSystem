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
    public partial class EntityAdding : Form
    {
        public EntityAdding()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        public int currentDBS;
        DataBaseProject DBP;
        //Переход на форму добавления атрибутов сущности
        private void AddEntity_Click(object sender, EventArgs e)
        {
            //Проверка корректности заполнения информационных полей
            if (NameTextBox.TextLength == 0)
                MessageBox.Show("Нельзя создать сущность. Пожалуйста, введите ее название.", "Ошибка!");
            else
            {
                bool flag = false;
                foreach (Entity c in cont.EntitySet)
                    if (c.Name == NameTextBox.Text)
                        flag = true;
                if (flag == true)
                    MessageBox.Show("Сущность с таким именем уже зарегистрирована в системе. Пожалуйста, придумайте другое название.", "Ошибка!");
                else
                {
                    Entity en = new Entity
                    {
                        Name = NameTextBox.Text,
                        Description = DescripionTextBox.Text,
                       
                    };
                    //добавление сущности в базу данных
                    DBP.Entities.Add(en);
                    cont.SaveChanges();
                    //переход к форме добавления атрибутов
                    Hide();
                    AttributeToEntity AddEntity = new AttributeToEntity();
                    AddEntity.currentDBS = DBP.Id;
                    AddEntity.comboBox1.Items.Add(NameTextBox.Text);
                    AddEntity.comboBox1.Enabled = false;
                    AddEntity.ShowDialog();
                    Close();
                }
            }
        }

        //Возврат на главную рабочую страницу
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            FrMain CancelButton = new FrMain();
            CancelButton.currentDBS = DBP.Id;
            CancelButton.ShowDialog();
            Close();
        }

        //Вводятся только русские буквы с возможностью корректировать ввод (клавиша "Backspace") БЕЗ ПРОБЕЛА - Название сущности
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }

        //Вводятся только русские буквы с возможностью корректировать ввод (клавиша "Backspace") с пробелом, запятой и точкой - Описание сущности
        private void DescripionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void EntityAdding_Load(object sender, EventArgs e)
        {
            DBP = cont.DataBaseProjectSet.Find(currentDBS);
        }
    }
}
