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
    public partial class AddRelation : Form
    {
        public AddRelation()
        {
            InitializeComponent();
        }

        CaseModelContainer cont = new CaseModelContainer();
        public int currentDBS;
        DataBaseProject DBP;
        Entity ent1;
        Entity ent2;

        private void AddRelation_Load(object sender, EventArgs e)
        {
            DBP = cont.DataBaseProjectSet.Find(currentDBS);
            //Заполнение выпадающего списка сущностями из БД
            if (DBP.Entities.Count != 0)
            {
                foreach (Entity ent in DBP.Entities)    //заполнение сущностей из проекта
                    if (!ComboBoxEntity1.Items.Contains(ent.Name))
                        ComboBoxEntity1.Items.Add(ent.Name);
                ComboBoxEntity1.SelectedIndex = 0;
                foreach (Entity ent in DBP.Entities)    //заполнение сущностей из проекта
                    if (!ComboBoxEntity2.Items.Contains(ent.Name))
                        ComboBoxEntity2.Items.Add(ent.Name);
                ComboBoxEntity2.SelectedIndex = 0;
                ComboBoxK.SelectedIndex = 0;
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
        private void NameTBRelation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }

        //Вводятся только русские буквы с возможностью корректировать ввод (клавиша "Backspace") с пробелом, запятой и точкой - Описание сущности
        private void DescTBRelation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }
        //Вводятся только русские буквы с возможностью корректировать ввод (клавиша "Backspace") БЕЗ ПРОБЕЛА - Название сущности
        private void TextBAtt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }
        //Вводятся только русские буквы с возможностью корректировать ввод (клавиша "Backspace") БЕЗ ПРОБЕЛА - Название сущности
        private void TextBAtt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBAttDesc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void TextBAttDesc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void ComboBoxEntity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Entity en in DBP.Entities)
                if (en.Name == ComboBoxEntity1.Items[ComboBoxEntity1.SelectedIndex].ToString())
                    ent1 = en;
        }
        private void ComboBoxEntity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Entity en in DBP.Entities)
                if (en.Name == ComboBoxEntity2.Items[ComboBoxEntity2.SelectedIndex].ToString())
                    ent2 = en;
        }
        //нажатие на кнопку добавления связей
        private void BAddRelation_Click(object sender, EventArgs e)
        {   //название связи не введено или не выбраны сущности и кратности
            if (NameTBRelation.TextLength == 0 || ComboBoxEntity1.Text == "" || ComboBoxEntity2.Text == "" || ComboBoxK.Text == "")
                MessageBox.Show("Нельзя создать связь. Пожалуйста, введите ее название, а также выберите сущность и кратность.", "Ошибка!");

            else
            {
                bool flag = false;
                foreach (Relation r in cont.RelationSet)    //проверка существующих связей
                    if (r.Name == NameTBRelation.Text)
                        flag = true;
                if (flag == true)
                    MessageBox.Show("Связь с таким именем уже имеется в системе. Пожалуйста, придумайте другое название.", "Ошибка!");
                else
                {
                    if (TextBAtt1.TextLength == 0)
                    {
                        MessageBox.Show("Нельзя добавить атрибут. Пожалуйста, введите его название, описание (необязательно), тип данных и тип атрибута.", "Ошибка!");
                        TextBAtt1.Clear();
                        TextBAttDesc1.Clear();

                    }
                    else
                    {
                        bool flag1 = false;
                        foreach (Attribute at in cont.AttributeSet)
                            if (at.Entity.Name == ComboBoxEntity1.Text)
                                if (at.Name == TextBAtt1.Text)
                                    flag1 = true;
                        if (flag1 == true)
                        {
                            MessageBox.Show("Данная сущность уже имеет атрибут с таким именем. Пожалуйста, придумайте другое название.", "Ошибка!");
                            TextBAtt1.Clear();
                            TextBAttDesc1.Clear();
                        }
                        else
                        {

                            //для разных кратностей разные действия
                            switch (ComboBoxK.Items[ComboBoxK.SelectedIndex].ToString())
                            {
                                //добавляем атрибуты
                                case "0..1:0..1":
                                case "0..1:1":
                                case "0..1:*":
                                case ":0..1":
                                case "1:1":
                                case "1:*":
                                case "*:0..1":
                                case "*:1":
                                    //добавление в бд новых атрибутов, которые связываются с сущностями
                                    Attribute atr1 = new Attribute
                                    {
                                        Name = TextBAtt1.Text,
                                        Description = TextBAttDesc1.Text,
                                        Type = "int",
                                        Specification = "Внешний ключ"
                                    };
                                    ent1.Attributes.Add(atr1);
                                    Attribute atr2 = new Attribute
                                    {
                                        Name = TextBAtt2.Text,
                                        Description = TextBAttDesc2.Text,
                                        Type = "int",
                                        Specification = "Внешний ключ"
                                    };
                                    ent2.Attributes.Add(atr2);
                                    //добавление связи
                                    Relation rel = new Relation
                                    {
                                        Name = NameTBRelation.Text,
                                        Description = DescTBRelation.Text,
                                        Multiplicity = ComboBoxK.Text
                                        //Source = atr1,
                                        //Target = atr2
                                    };
                                    //атрибуты связываются с созданной связью
                                    atr1.RelToTarget.Add(rel);
                                    atr2.RelFromSource.Add(rel);
                                    cont.SaveChanges();
                                    break;
                                case "*:*":
                                    //создание связи многие со многими
                                    //создаются новые атрибуты для выбранных сущностей
                                    Attribute atr11 = new Attribute
                                    {
                                        Name = TextBAtt1.Text,
                                        Description = TextBAttDesc1.Text,
                                        Type = "int",
                                        Specification = "Внешний ключ"
                                    };
                                    ent1.Attributes.Add(atr11);
                                    Attribute atr21 = new Attribute
                                    {
                                        Name = TextBAtt2.Text,
                                        Description = TextBAttDesc2.Text,
                                        Type = "int",
                                        Specification = "Внешний ключ"
                                    };
                                    ent2.Attributes.Add(atr21);
                                    //создается промежуточная сущность с ид первой и второй сущности
                                    Entity ent3 = new Entity
                                    {
                                        Name = ent1.Name + ent2.Name,
                                        Description = "Таблица, связывающая таблицы " + ent1.Name + " и " + ent2.Name + " в связи *:*."
                                    };
                                    //создаются атрибуты для промежуточной сущности 
                                    Attribute atr31 = new Attribute
                                    {
                                        Name = TextBAtt1.Text,
                                        Description = TextBAttDesc1.Text,
                                        Type = "int",
                                        Specification = "Внешний ключ"
                                    };
                                    ent3.Attributes.Add(atr31);
                                    Attribute atr32 = new Attribute
                                    {
                                        Name = TextBAtt2.Text,
                                        Description = TextBAttDesc2.Text,
                                        Type = "int",
                                        Specification = "Внешний ключ"
                                    };
                                    ent3.Attributes.Add(atr32);
                                    //создаются связи, которые связывают выбранные сущности с промежуточной связью
                                    Relation rel1 = new Relation
                                    {
                                        Name = NameTBRelation.Text,
                                        Description = DescTBRelation.Text,
                                        Multiplicity = "1:*"
                                        //Source = atr1,
                                        //Target = atr2
                                    };
                                    DBP.Entities.Add(ent3);
                                    atr11.RelToTarget.Add(rel1);
                                    atr31.RelFromSource.Add(rel1);
                                    Relation rel2 = new Relation
                                    {
                                        Name = NameTBRelation.Text,
                                        Description = DescTBRelation.Text,
                                        Multiplicity = "1:*"
                                        //Source = atr1,
                                        //Target = atr2
                                    };
                                    atr21.RelToTarget.Add(rel2);
                                    atr32.RelFromSource.Add(rel2);
                                    cont.SaveChanges();
                                    break;
                            }

                            //после добавления возвращаемся на главную форму 
                            Hide();
                            FrMain AddR = new FrMain();
                            AddR.currentDBS = DBP.Id;
                            AddR.ShowDialog();
                            Close();
                        }
                    }
                }
            }
        }

        private void ComboBoxK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
