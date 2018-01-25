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
    public partial class FormAdding : Form
    {
        public FormAdding() //форма добавления форм
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        Entity selectedEntity = new Entity();
        Attribute selectedAttribute = new Attribute();
        TypeEvent selectedEvent = new TypeEvent();
        public int currentPrId;
        DataBaseProject dBP;
        private void FormAdding_Load(object sender, EventArgs e)
        {
            dBP = cont.DataBaseProjectSet.Find(currentPrId);    //текущий проект 
            foreach (Entity en in dBP.Entities) //заполнение списка сущностей
                EntityList.Items.Add(en.Name);
            EntityList.SelectedIndex = 0;
            foreach (TypeEvent te in cont.TypeEventSet) //заполнение типов событий
                FormTypesList.Items.Add(te.Name);
            FormTypesList.SelectedIndex = 0;
        }

        private void EntityList_SelectedIndexChanged(object sender, EventArgs e)
        {   //смена элемента списка сущностей
            if (EntityList.Items.Count != 0)
            {
                foreach (Entity en in dBP.Entities)
                    if (en.Name == EntityList.Items[EntityList.SelectedIndex].ToString())
                        selectedEntity = en;
                AttributeList.Items.Clear();
                if (selectedEntity != null)
                    foreach (Attribute at in selectedEntity.Attributes)
                        AttributeList.Items.Add(at.Name);
                AttributeList.SelectedIndex = 0;
                dGVAttributes.Rows.Clear();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {   //переход на главную форму
            Hide();
            FrMain main = new FrMain();
            main.currentDBS = dBP.Id;
            main.ShowDialog();
            Close();
        }

        private void AttributeList_SelectedIndexChanged(object sender, EventArgs e)
        {   //выбор атрибутов, которые должны выводиться на форму
            if (AttributeList.Items.Count != 0)
            {
                foreach (Attribute at in selectedEntity.Attributes)
                    if (at.Name == AttributeList.Items[AttributeList.SelectedIndex].ToString())
                        selectedAttribute = at;
            }
            else selectedAttribute = new Attribute();
        }

        private void AddAttribute_Click(object sender, EventArgs e)
        {   //добавление атрибутов в список атрибутов, связанных с формой
            if (AttributeList.Items.Count != 0) //если список атрибутов не пустой
            {   //добавление атрибута в таблицу с удалением элемента из списка на выбор,
                //для избежания повторения
                dGVAttributes.Rows.Add();
                dGVAttributes.Rows[dGVAttributes.Rows.Count - 1].Cells[0].Value = selectedAttribute.Name;
                dGVAttributes.Rows[dGVAttributes.Rows.Count - 1].Cells[1].Value = selectedAttribute.Type;
                dGVAttributes.Rows[dGVAttributes.Rows.Count - 1].Cells[2].Value = selectedAttribute.Specification;
                AttributeList.Items.Remove(AttributeList.SelectedItem);
                if (AttributeList.Items.Count != 0)
                    AttributeList.SelectedIndex = 0;
                else selectedAttribute = new Attribute();
            }
            else
                MessageBox.Show("Все атрибуты уже добавлены / отсутствуют");
        }

        private void ChangeAttribute_Click(object sender, EventArgs e)
        {   //замена атрибута
            if (AttributeList.Items.Count != 0) //если список атрибутов не пуст
            {
                if (dGVAttributes.Rows.Count != 0)  //если таблица атрибутов не пустая
                {
                    
                    foreach (DataGridViewRow dgvr in dGVAttributes.SelectedRows)
                    {
                        //атрибут, выбранный в списке меняется местами с
                        //атрибутом, выбранным в таблице
                        AttributeList.Items.Add(dgvr.Cells[0].Value);
                        dgvr.Cells[0].Value = selectedAttribute.Name;
                        dgvr.Cells[1].Value = selectedAttribute.Type;
                        dgvr.Cells[2].Value = selectedAttribute.Specification;
                        AttributeList.Items.Remove(AttributeList.SelectedItem);
                        AttributeList.SelectedIndex = 0;
                    }
                }
                else
                    MessageBox.Show("Таблица пуста");
            }
            else
                MessageBox.Show("Все атрибуты уже добавлены / отсутствуют");
        }

        private void RemoveAttribute_Click(object sender, EventArgs e)  //удаление атрибутов
        {
            if (dGVAttributes.Rows.Count != 0)  //если талица не пустая
            {
                foreach (DataGridViewRow dgvr in dGVAttributes.SelectedRows)
                {
                    AttributeList.Items.Add(dgvr.Cells[0].Value);   //возвращение атрибута в список атрибутов
                }
                for (int i = dGVAttributes.SelectedRows.Count - 1; i >= 0; i--)
                    dGVAttributes.Rows.Remove(dGVAttributes.SelectedRows[i]);   //удаление атрибута
                AttributeList.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Таблица пуста");
        }

        private void CreateForma_Click(object sender, EventArgs e)
        {
            //создание формы
            if (dGVAttributes.Rows.Count != 0)
            {
                if (FormNameTB.Text != "")
                {
                    bool inDb = false;
                    foreach (Entity en in dBP.Entities)
                        foreach (Forma f in en.Forms)
                            if (f.Name == FormNameTB.Text)
                                inDb = true;    //есть форма с таким названием
                    if (!inDb)
                    {
                        //формы с таким названием нет
                        Forma newForm = new Forma();    //создание новой формы
                        newForm.Name = FormNameTB.Text;
                        newForm.Description = DescriptionFormTB.Text;
                        selectedEvent.Forms.Add(newForm);
                        selectedEntity.Forms.Add(newForm);
                        TypeControlElement label = new TypeControlElement();
                        TypeControlElement textB = new TypeControlElement();
                        TypeControlElement comboB = new TypeControlElement();
                        TypeControlElement checkB = new TypeControlElement();
                        foreach (TypeControlElement tce in cont.TypeControlElementSet)
                        {
                            if (tce.Name == "Label")
                                label = tce;
                            if (tce.Name == "TextBox")
                                textB = tce;
                            if (tce.Name == "ComboBox")
                                comboB = tce;
                            if (tce.Name == "CheckBox")
                                checkB = tce;

                        }
                        int y = 70;
                        foreach (DataGridViewRow dgvr in dGVAttributes.Rows)    
                        {   //создание новых контрольных элементов на форме
                            int x = 10;
                            switch (selectedEvent.Name)
                            {
                                case "Добавление":
                                case "Изменение":
                                case "Удаление":
                                    foreach (Attribute at in selectedEntity.Attributes)
                                    {
                                        if (dgvr.Cells[0].Value == at.Name)
                                        {
                                            //добавление элемента label
                                            ControlElement cEL = new ControlElement
                                            {
                                                Name = at.Name,
                                                Enabled = false,
                                                PositionX = x,
                                                PositionY = y,
                                                Length = 80,
                                                Width = 15
                                            };
                                            newForm.ControlElements.Add(cEL);
                                            label.ControlElements.Add(cEL);
                                            at.ControlElements.Add(cEL);
                                            x += 100;
                                            switch (at.Specification)   //обход спецификаций атрибутов
                                            {
                                                case "Первичный ключ":
                                                    //добавление textbox
                                                    ControlElement cETE = new ControlElement
                                                    {
                                                        Name = at.Name,
                                                        Enabled = false,
                                                        PositionX = x,
                                                        PositionY = y,
                                                        Length = 15,
                                                        Width = 15
                                                    };
                                                    newForm.ControlElements.Add(cETE);
                                                    textB.ControlElements.Add(cETE);
                                                    at.ControlElements.Add(cETE);
                                                    break;
                                                case "Скалярное поле":
                                                    if (at.Type != "bool")
                                                    {
                                                        //добавление textbox
                                                        ControlElement cET = new ControlElement
                                                        {
                                                            Name = at.Name,
                                                            Enabled = false,
                                                            PositionX = x,
                                                            PositionY = y,
                                                            Length = 120,
                                                            Width = 15
                                                        };
                                                        newForm.ControlElements.Add(cET);
                                                        textB.ControlElements.Add(cET);
                                                        at.ControlElements.Add(cET);
                                                    }
                                                    else
                                                    {
                                                        //добавление checkbox
                                                        ControlElement cECh = new ControlElement
                                                        {
                                                            Name = at.Name,
                                                            Enabled = false,
                                                            PositionX = x,
                                                            PositionY = y,
                                                            Length = 15,
                                                            Width = 15
                                                        };
                                                        newForm.ControlElements.Add(cECh);
                                                        checkB.ControlElements.Add(cECh);
                                                        at.ControlElements.Add(cECh);
                                                    }
                                                    break;
                                                case "Внешний ключ":
                                                    //добавление combobox
                                                    ControlElement cEC = new ControlElement
                                                    {
                                                        Name = at.Name,
                                                        Enabled = false,
                                                        PositionX = x,
                                                        PositionY = y,
                                                        Length = 80,
                                                        Width = 15
                                                    };
                                                    newForm.ControlElements.Add(cEC);
                                                    comboB.ControlElements.Add(cEC);
                                                    at.ControlElements.Add(cEC);
                                                    break;
                                            }
                                            y += 30;
                                        }
                                    }
                                    break;
                                case "Поиск":
                                    foreach (Attribute at in selectedEntity.Attributes)
                                    {
                                        if (dgvr.Cells[0].Value == at.Name)
                                        {
                                            ControlElement cEL = new ControlElement
                                            {
                                                Name = at.Name,
                                                Enabled = false,
                                                PositionX = x,
                                                PositionY = y,
                                                Length = 80,
                                                Width = 15
                                            };
                                            newForm.ControlElements.Add(cEL);
                                            label.ControlElements.Add(cEL);
                                            at.ControlElements.Add(cEL);
                                            x += 100;
                                            ControlElement cEC = new ControlElement
                                            {
                                                Name = at.Name,
                                                Enabled = true,
                                                PositionX = x,
                                                PositionY = y,
                                                Length = 80,
                                                Width = 15
                                            };
                                            newForm.ControlElements.Add(cEC);
                                            comboB.ControlElements.Add(cEC);
                                            at.ControlElements.Add(cEC);
                                            y += 30;
                                        }
                                    }
                                    break;
                                case "Просмотр":
                                    foreach (Attribute at in selectedEntity.Attributes)
                                    {
                                        if (dgvr.Cells[0].Value == at.Name)
                                        {
                                            ControlElement cEL = new ControlElement
                                            {
                                                Name = at.Name,
                                                Enabled = false,
                                                PositionX = x,
                                                PositionY = y,
                                                Length = 80,
                                                Width = 15
                                            };
                                            newForm.ControlElements.Add(cEL);
                                            label.ControlElements.Add(cEL);
                                            at.ControlElements.Add(cEL);
                                            x += 100;
                                            switch (at.Specification)
                                            {
                                                case "Первичный ключ":
                                                    ControlElement cETE = new ControlElement
                                                    {
                                                        Name = at.Name,
                                                        Enabled = false,
                                                        PositionX = x,
                                                        PositionY = y,
                                                        Length = 15,
                                                        Width = 15
                                                    };
                                                    newForm.ControlElements.Add(cETE);
                                                    textB.ControlElements.Add(cETE);
                                                    at.ControlElements.Add(cETE);
                                                    break;
                                                case "Скалярное свойство":
                                                    if (at.Type != "bool")
                                                    {
                                                        ControlElement cET = new ControlElement
                                                        {
                                                            Name = at.Name,
                                                            Enabled = false,
                                                            PositionX = x,
                                                            PositionY = y,
                                                            Length = 120,
                                                            Width = 15
                                                        };
                                                        newForm.ControlElements.Add(cET);
                                                        textB.ControlElements.Add(cET);
                                                        at.ControlElements.Add(cET);
                                                    }
                                                    else
                                                    {
                                                        ControlElement cECh = new ControlElement
                                                        {
                                                            Name = at.Name,
                                                            Enabled = false,
                                                            PositionX = x,
                                                            PositionY = y,
                                                            Length = 15,
                                                            Width = 15
                                                        };
                                                        newForm.ControlElements.Add(cECh);
                                                        checkB.ControlElements.Add(cECh);
                                                        at.ControlElements.Add(cECh);
                                                    }
                                                    break;
                                                case "Внешний ключ":
                                                    ControlElement cEC = new ControlElement
                                                    {
                                                        Name = at.Name,
                                                        Enabled = false,
                                                        PositionX = x,
                                                        PositionY = y,
                                                        Length = 80,
                                                        Width = 15
                                                    };
                                                    newForm.ControlElements.Add(cEC);
                                                    comboB.ControlElements.Add(cEC);
                                                    at.ControlElements.Add(cEC);
                                                    break;
                                            }
                                            y += 30;
                                        }
                                    }
                                    break;


                            }
                        }
                        cont.SaveChanges();
                        Hide();
                        FrMain main = new FrMain();
                        main.currentDBS = dBP.Id;
                        main.ShowDialog();
                        Close();
                    }
                    else
                        MessageBox.Show("В базе есть форма с таким названием");
                }
                else MessageBox.Show("Не введено название формы.");
            }
            else MessageBox.Show("Не выбраны атрибуты? на основе которых будет создаваться форма");
        }

        private void FormTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormTypesList.Items.Count != 0)
                foreach (TypeEvent ev in cont.TypeEventSet)
                    if (ev.Name == FormTypesList.Items[FormTypesList.SelectedIndex].ToString())
                        selectedEvent = ev;
        }
    }
}
