using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Word;

//using Microsoft.Office.Interop.Word;


namespace CaseSystem1
{
    public partial class ReportAdding : Form
    {
        public ReportAdding()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        public int currentDBP;
        DataBaseProject dBP;
        Question currentQuest;
        private void ReportAdding_Load(object sender, EventArgs e)
        {
            //заполнение списка существующими запросами
            dBP = cont.DataBaseProjectSet.Find(currentDBP);
            foreach (Question quest in cont.QuestionSet)
                foreach (Attribute at in quest.Attributes)  
                    if (dBP.Entities.Contains(at.Entity) && !(QuestionList.Items.Contains(quest.Name)))
                        QuestionList.Items.Add(quest.Name);
            if (QuestionList.Items.Count != 0)
                QuestionList.SelectedIndex = 0;
            FormatList.SelectedIndex = 0;

        }

        private void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Question quest in cont.QuestionSet)
            {
                bool inDb = false;
                foreach (Attribute at in quest.Attributes)
                    if (dBP.Entities.Contains(at.Entity) && quest.Name == QuestionList.Items[QuestionList.SelectedIndex].ToString())
                    {
                        currentQuest = quest;
                        inDb = true;
                        break;
                    }
                if (inDb)
                    break;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //возвращение на главную форму
            Hide();
            FrMain main = new FrMain();
            main.currentDBS = dBP.Id;
            main.ShowDialog();
            Close();

        }

        //генерация отчета не работает из-за того, что не создается Excel.Application (метод
        //класса Report, SaveReport
        private void ReportGeneration_Click(object sender, EventArgs e)
        {
            //генерация отчетов
            if (ReportName.Text != "")
            {
                bool inDb = false;
                foreach (Entity en in dBP.Entities)
                {
                    foreach (Attribute at in en.Attributes)
                    {
                        foreach (Question qu in at.Questions)
                        {
                            foreach (Report rt in qu.Reports)
                                if (rt.Name == ReportName.Text)
                                {
                                    inDb = true;
                                    break;
                                }
                        }
                        if (inDb)
                            break;
                    }
                    if (inDb)
                        break;
                }
                if (!inDb)  //в текущем проекте нет ни одного отчета с таким же именем
                {
                    //запоминается путь до файла
                    string pathToXML = Environment.CurrentDirectory + "\\" + dBP.Id.ToString() + "." + ReportName.Text + "xlsx";
                    Report newRt = new Report
                    {
                        Name = ReportName.Text,
                        Description = pathToXML,
                        Format = FormatList.Text
                    };
                    currentQuest.Reports.Add(newRt);
                    cont.SaveChanges();
                    if (newRt.SaveReport(dBP.Id, pathToXML))    //создание отчета
                    {
                        //cont.SaveChanges();
                        Hide();
                        FrMain main = new FrMain();
                        main.currentDBS = dBP.Id;
                        main.ShowDialog();
                        Close();

                    }
                    else
                    {
                        currentQuest.Reports.Remove(newRt);
                        cont.ReportSet.Remove(newRt);
                        cont.SaveChanges();
                        newRt = new Report();
                        MessageBox.Show("Запрос пустой");
                    }
                }
                else
                    MessageBox.Show("Отчет с таким названием уже есть в данном проекте");
            }
            else
                MessageBox.Show("Название отчета не введено");
        }

        private void ReportName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar < '0' || e.KeyChar > '9')) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }
    }
}
