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
    public partial class QuestionViewing : Form
    {
        public QuestionViewing()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        public int currentQuest;
        Question quest;
        public int currentDB;
        DataBaseProject dBP;
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            FrMain CancelBut = new FrMain();
            CancelBut.currentDBS = currentDB;
            CancelBut.ShowDialog();
            Close();
        }

        private void QuestionViewing_Load(object sender, EventArgs e)
        {
            dBP = cont.DataBaseProjectSet.Find(currentDB);
            quest = cont.QuestionSet.Find(currentQuest);
            if (quest.Attributes.Count != 0)
            {
                int amount = 0;
                int[] idAttrs = new int[quest.Attributes.Count];
                List<int> numOfNum = new List<int>();
                for (int i = 0; i < quest.Attributes.Count - 1; i++)
                {
                    for (int j = i + 1; j < quest.Attributes.Count; j++)
                    {
                        if (quest.Attributes.ElementAt(i).Name == quest.Attributes.ElementAt(j).Name)
                        {
                            numOfNum.Add(i + 1);
                            numOfNum.Add(j + 1);
                        }
                    }
                }
                foreach (Attribute at in quest.Attributes)
                {
                    amount++;
                    if (!numOfNum.Contains(amount))
                        dGVQuestResult.Columns.Add("Column" + amount.ToString(), at.Name);
                    else
                        dGVQuestResult.Columns.Add("Column" + amount.ToString(), at.Entity.Name + "." + at.Name);
                    idAttrs[amount - 1] = at.Id;
                }
                numOfNum.Clear();
                List<string> numOfExemp = quest.Execute();
                int colNum = 0;
                foreach (Attribute at in quest.Attributes)
                {
                    int rowNum = 0;
                    if (colNum == 0)
                        foreach (AttributeValue atv in at.AttributeValues)
                        {
                            if (numOfExemp.Contains(atv.Attribute.Entity.Id + "." + atv.Number))
                            {
                                dGVQuestResult.Rows.Add();
                                dGVQuestResult.Rows[rowNum].Cells[colNum].Value = atv.Value;
                                rowNum++;
                            }
                        }
                    else
                    {
                        foreach (AttributeValue atv in at.AttributeValues)
                        {
                            if (numOfExemp.Contains(atv.Attribute.Entity.Id + "." + atv.Number))
                            {
                                dGVQuestResult.Rows[rowNum].Cells[colNum].Value = atv.Value;
                                rowNum++;
                            }
                        }
                    }
                    colNum++;
                    //foreach (DataGridViewColumn dgvc in dGVQuestResult.Columns)
                    //dgvc.Name;
                }
                foreach (DataGridViewColumn dgvc in dGVQuestResult.Columns)
                    dgvc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dGVQuestResult.
            }
        }

        private void RemoveQuestion_Click(object sender, EventArgs e)
        {
            if (quest.Conditions.Count != 0)
                for (int i = quest.Conditions.Count - 1; i >= 0; i--)
                {
                    quest.Conditions.ElementAt(i).Attribute.Conditions.Remove(quest.Conditions.ElementAt(i));
                    int condId = quest.Conditions.ElementAt(i).Id;
                    quest.Conditions.ElementAt(i).Question.Conditions.Remove(quest.Conditions.ElementAt(i));
                    cont.ConditionSet.Remove(cont.ConditionSet.Find(condId));
                }
            if (quest.Attributes.Count != 0)
                for (int i = quest.Attributes.Count - 1; i >= 0; i--)
                {
                    Attribute atr = quest.Attributes.ElementAt(i);
                    atr.Questions.Remove(quest);
                    quest.Attributes.Remove(atr);
                }
            cont.QuestionSet.Remove(quest);
            cont.SaveChanges();
            Hide();
            FrMain fM = new FrMain();
            fM.currentDBS = currentDB;
            fM.ShowDialog();
            Close();
            //cond.Question.Conditions.
        }
    }
}
