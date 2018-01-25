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
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        CaseModelContainer cont = new CaseModelContainer();
        public int currentDBS;  //ид текущего проекта
        DataBaseProject DBP;
        private void FrMain_Load(object sender, EventArgs e)
        {
            DBP = cont.DataBaseProjectSet.Find(currentDBS); //текущий проект
            ProjectName.Text = DBP.Name;
            //Заполнение выпадающего списка сущностями данного проекта из БД
            if (DBP.Entities.Count != 0)
            {
                foreach (Entity ent in DBP.Entities)
                    if (!EntityList.Items.Contains(ent.Name))
                        EntityList.Items.Add(ent.Name);
                EntityList.SelectedIndex = 0;
            }
            //Заполнение выпадающего списка связями данного проекта из БД
            if (DBP.Entities.Count != 0)
                foreach (Entity ent in DBP.Entities)
                    if (ent.Attributes.Count != 0)
                        foreach (Attribute at in ent.Attributes)
                            if (at.RelFromSource.Count != 0)
                            {
                                foreach (Relation rel in at.RelFromSource)
                                    if (!RelationList.Items.Contains(rel.Name))
                                        RelationList.Items.Add(rel.Name);
                                RelationList.SelectedIndex = 0;
                            }
            //Заполнение выпадающего списка формами данного проекта из БД
            if (DBP.Entities.Count != 0)
                foreach (Entity ent in DBP.Entities)
                    if (ent.Forms.Count != 0)
                    {
                        foreach (Forma fo in ent.Forms)
                            if (!FormList.Items.Contains(fo.Name))
                                FormList.Items.Add(fo.Name);
                        FormList.SelectedIndex = 0;
                    }
            //Заполнение выпадающего списка запросами данного проекта из БД
            if (DBP.Entities.Count != 0)
                foreach (Entity ent in DBP.Entities)
                    if (ent.Attributes.Count != 0)
                        foreach (Attribute at in ent.Attributes)
                            if (at.Questions.Count != 0)
                            {
                                
                                foreach (Question quest in at.Questions)
                                    if (!QuestionList.Items.Contains(quest.Name))
                                        QuestionList.Items.Add(quest.Name);
                                QuestionList.SelectedIndex = 0;
                            }
            //Заполнение выпадающего списка отчетами данного проекта из БД
            if (DBP.Entities.Count != 0)
                foreach (Entity ent in DBP.Entities)
                    if (ent.Attributes.Count != 0)
                        foreach (Attribute at in ent.Attributes)
                            if (at.Questions.Count != 0)
                                foreach (Question quest in at.Questions)
                                    if (quest.Reports.Count != 0)
                                    {
                                        foreach (Report rt in quest.Reports)
                                            if (!ReportList.Items.Contains(rt.Name))
                                                ReportList.Items.Add(rt.Name);
                                        ReportList.SelectedIndex = 0;
                                    }
        }

        private void AddEntity_Click(object sender, EventArgs e)
        {   //добавление сущностей
            Hide();
            EntityAdding AddEntity = new EntityAdding();
            AddEntity.currentDBS = DBP.Id;
            AddEntity.ShowDialog();
            Close();
        }

        private void OpenEntity_Click(object sender, EventArgs e)
        {   //открытие сущностей
            if (EntityList.Text == "")
                MessageBox.Show("Выберите сущность для просмотра.", "Ошибка!");
            else
            {
                Hide();
                FrEntityView OpenEntity = new FrEntityView();
                OpenEntity.NameEntityCB.Text = EntityList.Text;
                foreach (Entity en in DBP.Entities)
                    if (en.Name == EntityList.Text)
                        OpenEntity.DescrbEntityTB.Text = en.Description;
                OpenEntity.ShowDialog();
                Close();
            }
        }

        private void AddForm_Click(object sender, EventArgs e)
        {   //добавление новой формы в проект
            if (DBP.Entities.Count() != 0)
            {
                Hide();
                FormAdding fL = new FormAdding();
                fL.currentPrId = currentDBS;
                fL.ShowDialog();
                Close();
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {   //добавление нового запроса в проект
            if (DBP.Entities.Count() != 0)
            {
                Hide();
                QuestionAdding qL = new QuestionAdding();
                qL.currentDb = DBP.Id;
                qL.ShowDialog();
                Close();
            }
        }

        private void OpenQuestion_Click(object sender, EventArgs e)
        {   //открытие запроса
            if (cont.QuestionSet.Count() != 0)
            {
                Hide();
                QuestionViewing OpenQuest = new QuestionViewing();
                OpenQuest.NameQuestionCB.Text = QuestionList.Text;
                foreach (Question qu in cont.QuestionSet)
                    if (qu.Name == QuestionList.Text)
                    {
                        OpenQuest.DescrbQuestionTB.Text = qu.Description;
                        OpenQuest.currentQuest = qu.Id;
                    }
                OpenQuest.currentDB = DBP.Id;
                OpenQuest.ShowDialog();
                Close();
            }
        }

        private void ChangeProject_Click(object sender, EventArgs e)
        {   //изменение проекта
            Hide();
            FrProjects fP = new FrProjects();
            fP.ShowDialog();
            Close();
        }

        private void RemoveProject_Click(object sender, EventArgs e)    //не завершено
        {   //удаление проекта
            if (DBP.Entities.Count != 0)
            {
                for(int l = DBP.Entities.Count - 1; l >= 0; l--)    //обход сущностей
                {
                    Entity ent = DBP.Entities.ElementAt(l);
                    if (ent.Forms.Count != 0)
                    {
                        for (int j = ent.Forms.Count - 1; j >= 0; j--)  //обход форм
                        {
                            Forma forma = ent.Forms.ElementAt(j);
                            if (forma.ControlElements.Count != 0)
                                for (int i = forma.ControlElements.Count - 1; i >= 0; i--)  //обход элементов управления
                                {   //удаление элементов управления
                                    ControlElement cE = forma.ControlElements.ElementAt(i);
                                    cE.TypeControlElement.ControlElements.Remove(cE);
                                    cE.Attribute.ControlElements.Remove(cE);
                                    forma.ControlElements.Remove(cE);
                                    cont.ControlElementSet.Remove(cE);
                                }
                            forma.TypeEvent.Forms.Remove(forma);    //удаление формы из типов события
                            ent.Forms.Remove(forma);    //удаление связи между формой и сущностью
                            cont.FormaSet.Remove(forma);    //удаление формы из бд
                        }
                        //cont.FormaSet.RemoveRange()
                    }
                    if (ent.Attributes.Count != 0)
                        for (int i = ent.Attributes.Count - 1; i >= 0; i--) //обход атрибутов
                        {
                            Attribute at = ent.Attributes.ElementAt(i);
                            if (at.Conditions.Count != 0)
                                for (int j = at.Conditions.Count - 1; j>= 0; j--)   //обход условий, связанных с атрибутами
                                {   //удаление условий
                                    Condition cond = at.Conditions.ElementAt(j);
                                    cond.Question.Conditions.Remove(cond);
                                    at.Conditions.Remove(cond);
                                    cont.ConditionSet.Remove(cond);
                                }
                            if (at.Questions.Count != 0)
                                for (int j = at.Questions.Count - 1; j >= 0; j--)   //обход запросов
                                {
                                    Question quest = at.Questions.ElementAt(j);
                                    if (quest.Reports.Count != 0)
                                        for (int k = quest.Reports.Count - 1; k >= 0; k--)  //обход отчетов
                                        {   //удаление отчетов
                                            Report rp = quest.Reports.ElementAt(k);
                                            quest.Reports.Remove(rp);
                                            cont.ReportSet.Remove(rp);
                                        }
                                    if (quest.Conditions.Count != 0)
                                        for (int k = quest.Conditions.Count - 1; k >= 0; k--)   //обход запросов
                                        {   //удаление условий
                                            Condition cond = quest.Conditions.ElementAt(k);
                                            quest.Conditions.Remove(cond);
                                            cont.ConditionSet.Remove(cond);
                                        }
                                    //удаление запросов
                                    quest.Attributes.Remove(at);
                                    at.Questions.Remove(quest);
                                    cont.QuestionSet.Remove(quest);
                                }
                            //точка, на которой остановился
                            if (at.RelFromSource.Count != 0)
                                for (int j = at.RelFromSource.Count - 1; j >= 0; j--)
                                    at.RelFromSource.Remove(at.RelFromSource.ElementAt(j));
                            if (DBP.Entities.ElementAt(l).Attributes.ElementAt(i).RelToTarget.Count != 0)
                                for (int j = DBP.Entities.ElementAt(l).Attributes.ElementAt(i).RelToTarget.Count - 1; j >= 0; j--)
                                    DBP.Entities.ElementAt(l).Attributes.ElementAt(i).RelToTarget.Remove(DBP.Entities.ElementAt(l).Attributes.ElementAt(i).RelToTarget.ElementAt(j));
                            DBP.Entities.ElementAt(l).Attributes.Remove(DBP.Entities.ElementAt(l).Attributes.ElementAt(i));
                        }
                }
            }
            cont.DataBaseProjectSet.Remove(DBP);    //удаление проекта
            cont.SaveChanges();
            Hide();
            FrProjects fP = new FrProjects();
            fP.ShowDialog();
            Close();
        }

        private void OpenForm_Click(object sender, EventArgs e)
        {   //форма открытия форм
            Hide();
            FormOpening OpenForma = new FormOpening();
            foreach (Entity en in DBP.Entities)
                foreach(Forma fo in en.Forms)
                    if (fo.Name == FormList.Items[FormList.SelectedIndex].ToString())
                        OpenForma.curFormId = fo.Id;    //запоминается ид выбранной формы
            OpenForma.curProjId = DBP.Id;   //запоминается ид текущего проекта
            OpenForma.ShowDialog();
            Close();
        }

        private void AddReport_Click(object sender, EventArgs e)
        {   //переход на форму для добавления отчетов
            if (DBP.Entities.Count != 0)
            {
                bool inDB = false;  //проверка существования отчетов в текущем проекте
                foreach (Question que in cont.QuestionSet)
                {
                    foreach (Attribute at in que.Attributes)
                        if (DBP.Entities.Contains(at.Entity))
                        {
                            inDB = true;
                            break;
                        }
                    if (inDB)
                        break;
                }
                if (inDB)   //переход на форму добавления
                {
                    Hide();
                    ReportAdding ra = new ReportAdding();
                    ra.currentDBP = DBP.Id; //запоминается ид текущей формы
                    ra.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Нет ни одного запроса");

            }
            else MessageBox.Show("Нет ни одной сущности");
        }

        private void AddRelation_Click(object sender, EventArgs e)
        {   //переход на форму добавления связей
            if (cont.EntitySet.Count() != 0)
            {
                Hide();
                AddRelation AddR = new AddRelation();
                AddR.currentDBS = DBP.Id;
                AddR.ShowDialog();
                Close();
            }
        }
    }
}
