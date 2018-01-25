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
    public partial class ChangeAttribute : Form
    {
        public ChangeAttribute()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        Entity ent = new Entity();
        Attribute change_at = new Attribute();//Переменная для записи изменяемого атрибута
        Attribute a1 = new Attribute();


        private void ChangeAttribute_Load(object sender, EventArgs e)
        {
            TypeComboBox.Items.AddRange(new string[] { "Byte", "Int", "Float", "Double", "Char", "Bool", "Decimal", "String" });
            TypeAttribute.Items.AddRange(new string[] { "Первичный ключ", "Скалярное поле" });
            foreach (Entity en in cont.EntitySet)
                if (en.Name == comboBoxChangeEntity.Text)
                {
                    ent = en;
                }
            butChange_1.Enabled = false;
        }
        //Отмена изменений,возвращение на страницу просмотра сущности и ее атрибутов
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            FrMain CancelButton = new FrMain();
            CancelButton.currentDBS = ent.DataBaseProject.Id;
            CancelButton.ShowDialog();
            Close();
        }
        //добавление новых атрибутов сразу в бд
        private void AddAttribute_Click(object sender, EventArgs e)
        {
            //Проверка корректности заполнения информационных полей
            if (AtNameTextBox.TextLength == 0 || TypeComboBox.Text == "" || TypeAttribute.Text == "")
            {
                MessageBox.Show("Нельзя добавить атрибут. Пожалуйста, введите его название, описание (необязательно), тип данных и тип атрибута.", "Ошибка!");
            }
            else
            {
                bool flag = false;
                foreach (Attribute at in cont.AttributeSet)
                    if (at.Entity.Name == comboBoxChangeEntity.Text)
                        if (at.Name == AtNameTextBox.Text)
                            flag = true;
                if (flag == true)
                {
                    MessageBox.Show("Данная сущность уже имеет атрибут с таким именем. Пожалуйста, придумайте другое название.", "Ошибка!");
                    AtNameTextBox.Clear();
                    textBoxDescriptio.Clear();
                    TypeComboBox.Text = "";
                    TypeAttribute.Text = "";
                }
                else //Добавление нового
                {
                    Attribute at = new Attribute();
                    at.Name = AtNameTextBox.Text;
                    at.Description = textBoxDescriptio.Text;
                    at.Type = TypeComboBox.Text;
                    at.Specification = TypeAttribute.Text;
                    ent.Attributes.Add(at);
                    cont.SaveChanges();
                    int k = 0;
                    foreach (Attribute at1 in ent.Attributes)
                        if (at1.Entity == ent)
                        {
                            dataGVChange.Rows.Add();
                            dataGVChange.Rows[k].Cells[0].Value = at1.Name;
                            dataGVChange.Rows[k].Cells[1].Value = at1.Description;
                            dataGVChange.Rows[k].Cells[2].Value = at1.Type;
                            dataGVChange.Rows[k].Cells[3].Value = at1.Specification;
                            k++;

                        }
                }
                AtNameTextBox.Clear();
                textBoxDescriptio.Clear();
                TypeComboBox.Text = "";
                TypeAttribute.Text = "";
            }
        }
        //удаление атрибутов сразу из бд
        private void DeleteAttribute_Click(object sender, EventArgs e)
        {
            AtNameTextBox.Clear();
            textBoxDescriptio.Clear();
            TypeComboBox.Text = "";

            if (dataGVChange.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить атрибут?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int ind = dataGVChange.SelectedCells[0].RowIndex;
                    string del = dataGVChange.Rows[ind].Cells[0].Value.ToString();
                    foreach (Attribute a in ent.Attributes)
                        if (a.Name == del)
                        {
                            a1 = a;
                            break;
                        }
                    //Удаление значений атрибутов
                    foreach (AttributeValue atv in cont.AttributeValueSet)
                        if (atv.Attribute == a1)
                            cont.AttributeValueSet.Remove(atv);
                    //Удаление атрибута
                    cont.AttributeSet.Remove(a1);
                    cont.SaveChanges();
                    int k = 0;
                    foreach (Attribute at1 in ent.Attributes)
                        if (at1.Entity == ent)
                        {
                            dataGVChange.Rows.Add();
                            dataGVChange.Rows[k].Cells[0].Value = at1.Name;
                            dataGVChange.Rows[k].Cells[1].Value = at1.Description;
                            dataGVChange.Rows[k].Cells[2].Value = at1.Type;
                            dataGVChange.Rows[k].Cells[3].Value = at1.Specification;
                            k++;

                        }

                }
            }
            else
                MessageBox.Show("Для удаления тура выберите тур из списка", "Ошибка!");
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeAttr_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGVChange.SelectedCells[0].RowIndex;  //Индекс строки
                string nasv = dataGVChange.Rows[ind].Cells[0].Value.ToString();
                foreach (Attribute a in ent.Attributes)
                    if (a.Name == nasv)
                        change_at = a;

                AtNameTextBox.Text = change_at.Name;
                textBoxDescriptio.Text = change_at.Description;
                TypeComboBox.Text = change_at.Type;
                TypeAttribute.Text = change_at.Specification;
                AddAttribute.Enabled = false;
                DeleteAttribute.Enabled = false;
                butChange_1.Enabled = true;
                ChangeAttr.Enabled = false;
                CancelButton.Enabled = false;

                dataGVChange.Rows.RemoveAt(ind);
            }
            catch
            {
                MessageBox.Show("Нельзя изменить строку.");  //Если строка пуста
            }
        }

        private void AtNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxDescriptio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void butChange_1_Click(object sender, EventArgs e)
        {
            //Проверка корректности заполнения информационных полей
            if (AtNameTextBox.TextLength == 0 || TypeComboBox.Text == "" || TypeAttribute.Text == "")
            {
                MessageBox.Show("Нельзя изменить атрибут. Пожалуйста, введите его название, описание (необязательно), тип данных и тип атрибута.", "Ошибка!");
            }
            else
            {
                bool flag = false;
                foreach (Attribute at in cont.AttributeSet)
                    if (at.Entity.Name == comboBoxChangeEntity.Text)
                        if (at.Name == AtNameTextBox.Text && at.Id != change_at.Id)
                            flag = true;
                if (flag == true)
                    MessageBox.Show("Данная сущность уже имеет атрибут с таким именем. Пожалуйста, придумайте другое название.", "Ошибка!");
                else //Добавление измененного
                {
                    //Добавление изменненного атрибута в массив
                    change_at.Name = AtNameTextBox.Text;
                    change_at.Description = textBoxDescriptio.Text;
                    change_at.Type = TypeComboBox.Text;
                    change_at.Specification = TypeAttribute.Text;
                    cont.SaveChanges();

                    dataGVChange.Rows.Add(change_at.Name, change_at.Description, change_at.Type, change_at.Specification);
                    AtNameTextBox.Clear();
                    textBoxDescriptio.Clear();
                    TypeComboBox.Text = "";
                    TypeAttribute.Text = "";

                    AddAttribute.Enabled = true;
                    DeleteAttribute.Enabled = true;
                    butChange_1.Enabled = false;
                    ChangeAttr.Enabled = true;
                    CancelButton.Enabled = true;
                }
            }
        }
    }
}
