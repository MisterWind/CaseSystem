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
    public partial class AttributeToEntity : Form
    {
        public AttributeToEntity()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        public int currentDBS;
        DataBaseProject DBP;

        private void AttributeToEntity_Load(object sender, EventArgs e)
        {
            DBP = cont.DataBaseProjectSet.Find(currentDBS); //определяем текущий проект
            TypeComboBox.Items.AddRange(new string[] { "Byte", "Int", "Float", "Double", "Char", "Bool", "Date", "String" });
            TypeAttribute.Items.AddRange(new string[] { "Первичный ключ", "Скалярное поле" });
            comboBox1.SelectedIndex = 0;
        }

        private void AddAttribute_Click(object sender, EventArgs e)
        {   //добавление атрибутов к сущности
            if (AtNameTextBox.TextLength == 0 || TypeComboBox.Text == "" || TypeAttribute.Text == "")   //проверка введенных значений для названия, типа данных и спецификации
            {
                //данные введены некорректно или неправильно
                MessageBox.Show("Нельзя добавить атрибут. Пожалуйста, введите его название, описание (необязательно), тип данных и тип атрибута.", "Ошибка!");
                AtNameTextBox.Clear();
                textBoxDescriptio.Clear();
                TypeComboBox.Text = "";
                TypeAttribute.Text = "";
            }
            else
            {   //все верно
                bool flag = false;
                foreach (Attribute at in cont.AttributeSet) //обход атрибутов
                    if (at.Entity.Name == comboBox1.Text)
                        if (at.Name == AtNameTextBox.Text)  //проверка названий текущих атрибутов
                            flag = true;
                if (flag == true)   //атрибут с таким названием уже есть
                {
                    MessageBox.Show("Данная сущность уже имеет атрибут с таким именем. Пожалуйста, придумайте другое название.", "Ошибка!");
                    AtNameTextBox.Clear();
                    textBoxDescriptio.Clear();
                    TypeComboBox.Text = "";
                    TypeAttribute.Text = "";
                }
                else
                {   //таких атрибутов нет
                    string name = AtNameTextBox.Text;
                    string descr = textBoxDescriptio.Text;
                    string type = TypeComboBox.Text;
                    string typeAt = TypeAttribute.Text;
                    dataGridViewATT.Rows.Add(name, descr, type, typeAt);    //перенос данных в таблицу атрибутов 
                    AtNameTextBox.Clear();
                    textBoxDescriptio.Clear();
                    TypeComboBox.Text = "";
                    TypeAttribute.Text = "";

                }
            }
        }
        //удаление атрибутов из таблицы атрибутов
        private void DeleteAttribute_Click(object sender, EventArgs e)
        {
            AtNameTextBox.Clear();
            textBoxDescriptio.Clear();
            TypeComboBox.Text = "";
            try
            {
                int ind = dataGridViewATT.SelectedCells[0].RowIndex;  //Индекс строки
                dataGridViewATT.Rows.RemoveAt(ind);
                for (int k = 0; k < dataGridViewATT.Rows.Count; k++)  //Проверка заполнения данной строки
                    dataGridViewATT.Rows[k].HeaderCell.Value = (k + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Нельзя удалить строку.");  //Если строка пуста
            }
        }
        //изменение атрибутов, внесенных в таблицу
        private void ChangeAttribute_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridViewATT.SelectedCells[0].RowIndex;  //Индекс строки
                //перенос строки из таблицы в блок создания атрибутов
                AtNameTextBox.Text = dataGridViewATT.Rows[ind].Cells[0].Value.ToString();
                textBoxDescriptio.Text = dataGridViewATT.Rows[ind].Cells[1].Value.ToString();
                TypeComboBox.Text = dataGridViewATT.Rows[ind].Cells[2].Value.ToString();
                TypeAttribute.Text = dataGridViewATT.Rows[ind].Cells[3].Value.ToString();
                dataGridViewATT.Rows.RemoveAt(ind);
            }
            catch
            {
                MessageBox.Show("Нельзя изменить строку.");  //Если строка пуста
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)   //кнопка сохранения атрибутов сущности
        {   //атрибутов нет
            if (dataGridViewATT.Rows.Count == 0)
                MessageBox.Show("Задайте атрибуты сущности!", "Ошибка!");
            else
            {   //проверка на наличие первичных ключей
                int kolvo = 0;
                for (int i = 0; i < dataGridViewATT.RowCount; i++)
                {
                    if ((string)dataGridViewATT.Rows[i].Cells[3].Value == "Первичный ключ")
                        kolvo++;
                }
                //проверка, если первичных ключей нет или их более 1
                if (kolvo == 0 || kolvo > 1)
                {
                    MessageBox.Show("Для данной сущности первичный ключ задан некорректно - не задан вообще или несколько атрибутов имеют спецификатор 'Первичный ключ'. Пожалуйста, задайте данное значение для какого-либо одного атрибута сущности.", "Ошибка!");
                    TypeAttribute.Text = "";
                }
                else
                {
                    //обход строк таблиц 
                    for (int i = 0; i < dataGridViewATT.RowCount; i++)
                    {   //создание арибутов
                        Attribute at = new Attribute
                        {
                            Name = dataGridViewATT.Rows[i].Cells[0].Value.ToString(),
                            Description = dataGridViewATT.Rows[i].Cells[1].Value.ToString(),
                            Type = dataGridViewATT.Rows[i].Cells[2].Value.ToString(),
                            Specification = dataGridViewATT.Rows[i].Cells[3].Value.ToString(),
                            
                        };
                        //
                        foreach (Entity en in DBP.Entities) //добавление атрибутов в текущую сущность
                            if (en.Name == comboBox1.Items[comboBox1.SelectedIndex].ToString())
                            {
                                en.Attributes.Add(at);
                                break;
                            }
                        //cont.EntitySet.Find(((Entity)comboBox1.SelectedValue).Id).Attributes.Add(at);
                        cont.SaveChanges();
                    }
                    //переход на главную форму
                    Hide();
                    FrMain SaveButton = new FrMain();
                    SaveButton.currentDBS = DBP.Id;
                    SaveButton.ShowDialog();
                    Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {  
            //возвращение на главную форму
            Hide();
            FrMain CancelButton = new FrMain();
            CancelButton.currentDBS = DBP.Id;
            CancelButton.ShowDialog();
            Close();
        }
        //проверка ввода данных
        private void AtNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }
        //проверка ввода данных
        private void textBoxDescriptio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }
    }
}
