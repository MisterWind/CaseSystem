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
    public partial class QuestionAdding : Form
    {
        public QuestionAdding()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        Entity selectedEntity = new Entity();
        Entity takenEntity = new Entity();
        Attribute takenAttribute = new Attribute();
        Attribute selectedAttribute = new Attribute();
        public int currentDb;
        DataBaseProject dBP;
        private void QuestionAdding_Load(object sender, EventArgs e)
        {
            dBP = cont.DataBaseProjectSet.Find(currentDb);
            foreach (Entity en in dBP.Entities)
                EntityList.Items.Add(en.Name);
            //EntityList.DataSource = cont.EntitySet.ToList(); 
            //EntityList.DisplayMember = "Name"; 
            if (EntityList.Items.Count != 0)
                EntityList.SelectedIndex = 0;
            AttributesAndConditionsSelection.Enabled = false;
            TakenAttributeCombo.Items.Clear();
            dGVAttributes.Rows.Clear();
            ConnectList.SelectedIndex = 0;
            ComparesList.SelectedIndex = 0;
        }

        private void AddEntity_Click(object sender, EventArgs e)
        {
            //запоминаются сущности, по которым будут выполняться запросы
            if (EntityList.SelectedItem != null)
            {
                //int id = 0; 
                
                foreach (Entity en in cont.EntitySet)
                    if (en.Name == EntityList.Items[EntityList.SelectedIndex].ToString() && en.DataBaseProject.Id == currentDb) 
                    {
                        //id = en.Id; 
                        dGVEntities.Rows.Add();
                        dGVEntities.Rows[dGVEntities.Rows.Count - 1].Cells[0].Value = en.Name;
                        dGVEntities.Rows[dGVEntities.Rows.Count - 1].Cells[1].Value = en.Description;
                        break;
                    }
                EntityList.Items.RemoveAt(EntityList.SelectedIndex);
                if (EntityList.Items.Count != 0)
                    EntityList.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Все сущности выбраны!");
        }

        private void RemoveEntity_Click(object sender, EventArgs e)
        {
            //удаляются сущности из списка сущностей, по которым будет выполняться запрос
            if (dGVEntities.Rows.Count != 0)
            {
                for (int i = dGVEntities.SelectedRows.Count - 1; i >= 0; i--)
                {
                    EntityList.Items.Add(dGVEntities.SelectedRows[i].Cells[0].Value);
                    dGVEntities.Rows.Remove(dGVEntities.SelectedRows[i]);
                }
            }
            else
                MessageBox.Show("Таблица сущностей пуста!");
        }

        private void SubmitEntities_Click(object sender, EventArgs e)
        {
            //сущности фиксируются, переносятся в область выбор выводимых атрибутов и
            //формирования условий
            if (dGVEntities.Rows.Count != 0)
            {
                foreach (DataGridViewRow dgvr in dGVEntities.Rows)
                {
                    EntitiesList.Items.Add(dgvr.Cells[0].Value);
                    TakenEntities.Items.Add(dgvr.Cells[0].Value);
                }
                EntitiesList.SelectedIndex = 0;
                TakenEntities.SelectedIndex = 0;
                //foreach (Entity en in cont.EntitySet)
                //    if (dGVEntities[0, 0].Value.ToString() == en.Name)
                //    {
                //        selectedEntity = en;
                //        takenEntity = en;
                //        break;
                //    }
                dGVEntities.Rows.Clear();
                EntityList.Items.Clear();
                EntitySelection.Enabled = false;
                AttributesAndConditionsSelection.Enabled = true;
            }
            else
                MessageBox.Show("Для запроса не были выбраны сущности");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //кнопка для возвращения на главную форму
            Hide();
            FrMain main = new FrMain();
            main.currentDBS = dBP.Id;
            main.ShowDialog();
            Close();
        }

        private void EntitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //изменение индекса выбранной сущности
            AttributeList.Items.Clear();
            foreach (Entity en in cont.EntitySet)
                if (en.Name == EntitiesList.Items[EntitiesList.SelectedIndex].ToString() && en.DataBaseProject.Id == currentDb)
                {
                    selectedEntity = en;
                    break;
                }
            if (selectedEntity.Attributes.Count != 0)
            {
                foreach (Attribute at in selectedEntity.Attributes)
                    AttributeList.Items.Add(at.Name);
                AttributeList.SelectedIndex = 0;
            }
        }

        private void ChangeEntities_Click(object sender, EventArgs e)
        {
            //выбранные сущности, атрибуты и условия обнуляются
            dGVConditions.Rows.Clear();
            //for (int i = dGVConditions.Rows.Count - 1; i >= 0; i--)
            //    dGVConditions.Rows.Remove(dGVConditions.Rows[i]);
            TakenEntities.Items.Clear();
            TakenAttributeCombo.Items.Clear();
            NotCheckBox.Checked = false;
            EntitiesList.Items.Clear();
            AttributeList.Items.Clear();
            ValueText.Text = "";
            EntitySelection.Enabled = true;
            QuestionAdding_Load(sender, e);
        }

        private void AddRule_Click(object sender, EventArgs e)
        {
            //добавление условий
            if (AttributeList.Items.Count != 0)
                if (ValueText.Text != "")
                {
                    bool ok = false;
                    //var result;
                    switch (selectedAttribute.Type)
                    {
                        //обход типов атрибута
                        case "Byte":
                            //result = new Byte();ин
                            byte result1;
                            ok = Byte.TryParse(ValueText.Text, out result1);
                            break;
                        case "Int":
                            int result2;
                            ok = Int32.TryParse(ValueText.Text, out result2);
                            break;
                        case "Float":
                            float result3;
                            ok = float.TryParse(ValueText.Text, out result3);
                            break;
                        case "Double":
                            double result4;
                            ok = Double.TryParse(ValueText.Text, out result4);
                            break;
                        case "Char":
                            char result5;
                            ok = Char.TryParse(ValueText.Text, out result5);
                            break;
                        case "Bool":
                            bool result6;
                            ok = Boolean.TryParse(ValueText.Text, out result6);
                            break;
                        case "Date":
                            DateTime result7;
                            ok = DateTime.TryParse(ValueText.Text, out result7);
                            break;
                        case "String":
                            ok = true;
                            break;
                    }
                    if (ok) //проверка на соответствие вводимых значений и текущего типа данных
                    {
                        if (dGVConditions.Rows.Count == 0)
                        {
                            dGVConditions.Rows.Add();
                            dGVConditions[0, 0].Value = "";
                        }
                        else
                        {
                            dGVConditions.Rows.Add();
                            dGVConditions[0, dGVConditions.Rows.Count - 1].Value = ConnectList.Items[ConnectList.SelectedIndex].ToString(); ;
                        }
                        if (NotCheckBox.Checked)
                            dGVConditions[1, dGVConditions.Rows.Count - 1].Value = true;
                        else
                            dGVConditions[1, dGVConditions.Rows.Count - 1].Value = false;
                        dGVConditions[2, dGVConditions.Rows.Count - 1].Value = EntitiesList.Items[EntitiesList.SelectedIndex].ToString();
                        dGVConditions[3, dGVConditions.Rows.Count - 1].Value = AttributeList.Items[AttributeList.SelectedIndex].ToString();
                        dGVConditions[4, dGVConditions.Rows.Count - 1].Value = ComparesList.Items[ComparesList.SelectedIndex].ToString();
                        dGVConditions[5, dGVConditions.Rows.Count - 1].Value = ValueText.Text;

                    }
                    else MessageBox.Show("Сравниваемое значение не совпадает с типом атрибута");
                }
                else MessageBox.Show("Не введено сравниваемое значение");
            else MessageBox.Show("У выбранной сущности нет атрибутов");
        }

        private void RemoveRule_Click(object sender, EventArgs e)
        {
            //удаление условий
            if (dGVConditions.Rows.Count != 0)
            {
                if (dGVConditions.SelectedRows.Contains(dGVConditions.Rows[0]))
                {
                    for (int i = dGVConditions.SelectedRows.Count - 1; i >= 0; i--)
                        dGVConditions.Rows.Remove(dGVConditions.SelectedRows[i]);
                    if (dGVConditions.Rows.Count != 0)
                        dGVConditions[0, 0].Value = "";
                }
                else
                    for (int i = dGVConditions.SelectedRows.Count - 1; i >= 0; i--)
                        dGVConditions.Rows.Remove(dGVConditions.SelectedRows[i]);
            }
            else
                MessageBox.Show("Таблица условий пуста");
        }

        private void AttributeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Attribute at in selectedEntity.Attributes)
                if (at.Name == AttributeList.Items[AttributeList.SelectedIndex].ToString())
                    selectedAttribute = at;
        }

        private void SaveQuestion_Click(object sender, EventArgs e)
        {
            //сохранение запросов
            if (QuestName.Text != "")
                if (dGVConditions.Rows.Count != 0)
                {
                    bool inDB = false;
                    foreach(Entity en in dBP.Entities)
                        foreach (Attribute at in en.Attributes)
                            foreach (Question que in at.Questions)
                                if (que.Name == QuestName.Text)
                                    inDB = true;
                    if (!inDB)  //запросы с подобным именем есть в текущем проекте
                    {
                        Question quest = new Question
                        {
                            Name = QuestName.Text,
                            Description = QuestDesc.Text
                        };
                        cont.QuestionSet.Add(quest);    //добавление запроса в бд
                        Entity ent = new Entity();
                        foreach (DataGridViewRow dgvr in dGVAttributes.Rows)
                        {
                            foreach (Entity en in dBP.Entities)
                                if (en.Name == dgvr.Cells[4].Value.ToString())
                                {
                                    ent = en;
                                    break;
                                }
                            foreach (Attribute at in ent.Attributes)
                                if (at.Name == dgvr.Cells[0].Value.ToString() && at.Description == dgvr.Cells[1].Value.ToString() && at.Type == dgvr.Cells[2].Value.ToString() && at.Specification == dgvr.Cells[3].Value.ToString())
                                {
                                    at.Questions.Add(quest);
                                    quest.Attributes.Add(at);   //запросы связываются с атрибутами
                                }
                        }
                        foreach (DataGridViewRow dgvr in dGVConditions.Rows)
                        {
                            foreach (Entity en in cont.EntitySet)
                                if (en.Name == dgvr.Cells[2].Value.ToString())
                                    ent = en;
                            Attribute atr = new Attribute();
                            foreach (Attribute at in ent.Attributes)
                                if (at.Name == dgvr.Cells[3].Value.ToString())
                                    atr = at;
                            Condition cond = new Condition
                            {
                                Operation = dgvr.Cells[0].Value.ToString(),
                                Not = (bool)dgvr.Cells[1].Value,
                                Compare = dgvr.Cells[4].Value.ToString(),
                                Value = dgvr.Cells[5].Value.ToString()
                            };
                            quest.Conditions.Add(cond); //запросы связываются с условиями
                            atr.Conditions.Add(cond);
                        }
                        cont.SaveChanges();
                        Hide();
                        FrMain main = new FrMain();
                        main.currentDBS = dBP.Id;
                        main.ShowDialog();
                        Close();
                    }
                    else MessageBox.Show("Запрос с таким названием уже есть в базе данных");
                }
                else MessageBox.Show("Нет ни одного условия");
            else MessageBox.Show("Не введено название запроса");
        }

        private void TakenEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakenAttributeCombo.Items.Clear();
            foreach (Entity en in dBP.Entities)
                if (en.Name == TakenEntities.Items[TakenEntities.SelectedIndex].ToString())
                {
                    
                    takenEntity = en;
                    break;
                }
            if (takenEntity.Attributes.Count != 0)
            {
                foreach (Attribute at in takenEntity.Attributes)
                {
                    bool ok = false;
                    foreach (DataGridViewRow dgvr in dGVAttributes.Rows)
                        if (dgvr.Cells[0].Value.ToString() == at.Name && dgvr.Cells[4].Value.ToString() == at.Entity.Name)
                            ok = true;
                    if (!ok)
                        TakenAttributeCombo.Items.Add(at.Name);
                }
                TakenAttributeCombo.SelectedIndex = 0;
            }
        }

        private void TakenAttributeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Attribute at in takenEntity.Attributes)
                if (at.Name == TakenAttributeCombo.Items[TakenAttributeCombo.SelectedIndex].ToString())
                    takenAttribute = at;
        }

        private void AddAtribute_Click(object sender, EventArgs e)
        {
            if (TakenEntities.Items.Count != 0)
            {
                if (TakenAttributeCombo.Items.Count != 0)
                {
                    dGVAttributes.Rows.Add();
                    dGVAttributes[0, dGVAttributes.Rows.Count - 1].Value = takenAttribute.Name;
                    dGVAttributes[1, dGVAttributes.Rows.Count - 1].Value = takenAttribute.Description;
                    dGVAttributes[2, dGVAttributes.Rows.Count - 1].Value = takenAttribute.Type;
                    dGVAttributes[3, dGVAttributes.Rows.Count - 1].Value = takenAttribute.Specification;
                    dGVAttributes[4, dGVAttributes.Rows.Count - 1].Value = takenAttribute.Entity.Name;
                    TakenAttributeCombo.Items.RemoveAt(TakenAttributeCombo.SelectedIndex);
                    if (TakenAttributeCombo.Items.Count != 0)
                        TakenAttributeCombo.SelectedIndex = 0;
                    else
                        TakenEntities.Items.RemoveAt(TakenEntities.SelectedIndex);
                    if (TakenEntities.Items.Count != 0)
                        TakenEntities.SelectedIndex = 0;
                }
                else
                    MessageBox.Show("У сущности нет атрибутов");
            }
            else
                MessageBox.Show("Все сущности выбраны");
        }

        private void RemoveAttribute_Click(object sender, EventArgs e)
        {
            if (dGVAttributes.Rows.Count != 0)
            {
                for (int i = dGVAttributes.SelectedRows.Count - 1; i >= 0; i--)
                {
                    if (!TakenEntities.Items.Contains(dGVAttributes.SelectedRows[i].Cells[4].Value))
                        TakenEntities.Items.Add(dGVAttributes.SelectedRows[i].Cells[4].Value);
                    dGVAttributes.Rows.Remove(dGVAttributes.SelectedRows[i]);
                }
                TakenEntities.SelectedIndex = 0;
                TakenEntities_SelectedIndexChanged(sender, e);
            }
        }
    }
}
