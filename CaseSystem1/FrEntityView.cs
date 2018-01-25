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
    public partial class FrEntityView : Form
    {
        public FrEntityView()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        Entity ent = new Entity();
        private void FrEntityView_Load(object sender, EventArgs e)
        {
            foreach (Entity en in cont.EntitySet)
                if (en.Name == NameEntityCB.Text)
                {
                    ent = en;
                }
            //заполнение названий столбцов названиями атрибутов
            int amount = 0;
            int[] idAttrs = new int[ent.Attributes.Count];
            List<int> numOfEnt = new List<int>();
            foreach (Attribute at in ent.Attributes)
            {
                amount++;
                dGVEnAt.Columns.Add("Column" + amount.ToString(), at.Name);
                idAttrs[amount - 1] = at.Id;
                foreach (AttributeValue atv in at.AttributeValues)
                    if (!numOfEnt.Contains(atv.Number))
                        numOfEnt.Add(atv.Number);
            }
            //добавление строк в зависимости от количества экземпляров текущей сущности
            foreach (int num in numOfEnt)
            {
                dGVEnAt.Rows.Add();
            }
            int k = 0;
            foreach (Attribute at in ent.Attributes)    
            {   //заполнение по столбцам
                //int i = 0;
                foreach (AttributeValue atv in at.AttributeValues)  //заполнение значениями атрибутов
                {
                    if (numOfEnt.Contains(atv.Number))
                        dGVEnAt.Rows[atv.Number - 1].Cells[k].Value = atv.Value;
                    //i++;
                }
                k++;
            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            Hide();
            ChangeAttribute butChange = new ChangeAttribute();
            butChange.comboBoxChangeEntity.Text = NameEntityCB.Text;
            foreach (Entity en in cont.EntitySet)
                if (en.Name == NameEntityCB.Text)
                {
                    ent = en;
                    butChange.textBoxDescr.Text = ent.Description;
                }
            int k = 0;
            foreach (Attribute at in ent.Attributes)
                if (at.Entity.Name == NameEntityCB.Text)
                {
                    butChange.dataGVChange.Rows.Add();
                    butChange.dataGVChange.Rows[k].Cells[0].Value = at.Name;
                    butChange.dataGVChange.Rows[k].Cells[1].Value = at.Description;
                    butChange.dataGVChange.Rows[k].Cells[2].Value = at.Type;
                    butChange.dataGVChange.Rows[k].Cells[3].Value = at.Specification;
                    k++;
                }
            butChange.ShowDialog();
            Close();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            Hide();
            FrMain CancelBut = new FrMain();
            CancelBut.currentDBS = ent.DataBaseProject.Id;
            CancelBut.ShowDialog();
            Close();
        }
        //не полное решение, не работает, если у сущности есть формы или запросы
        private void butDeleteEntity_Click(object sender, EventArgs e)
        {
            //Поиск сущности

            foreach (Entity en in cont.EntitySet)
                if (en.Name == NameEntityCB.Text)
                    ent = en;
            DataBaseProject dbs = ent.DataBaseProject;
            //Удаление значений атрибутов сущности
            foreach (Forma f in ent.Forms)
            {
                foreach (ControlElement ce in f.ControlElements)
                {

                }
            }
            foreach (AttributeValue atv in cont.AttributeValueSet)
                if (atv.Attribute.Entity == ent)
                    cont.AttributeValueSet.Remove(atv);
            //Удаление связей сущности
            foreach (Relation rel in cont.RelationSet)
                if (rel.Source.Entity == ent || rel.Target.Entity == ent)
                    cont.RelationSet.Remove(rel);
            //Удаление атрибутов сущности
            foreach (Attribute at in cont.AttributeSet)
                if (at.Entity == ent)
                    cont.AttributeSet.Remove(at);
            //Удаление сущности
            cont.EntitySet.Remove(ent);
            cont.SaveChanges();
            Hide();
            FrMain butDeleteEntity = new FrMain();
            butDeleteEntity.currentDBS = dbs.Id;
            butDeleteEntity.ShowDialog();
            Close();
        }
    }
}
