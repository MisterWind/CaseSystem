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
    public partial class FrProjects : Form
    {
        public FrProjects()
        {
            InitializeComponent();
        }
        //стартовая форма
        CaseModelContainer cont = new CaseModelContainer();

        private void FrProjects_Load(object sender, EventArgs e)   
        {
            ProjectsList.DataSource = cont.DataBaseProjectSet.ToList(); //все проекты, созданные в приложении выводятся в комбобокс
            ProjectsList.DisplayMember = "Name";
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            //переход на форму создания проекта
            Hide();
            ProjectAdding prAd = new ProjectAdding();
            prAd.ShowDialog();
            Close();
        }

        private void OpenProject_Click(object sender, EventArgs e)
        {   //открытие данных, связанных с проектом
            if (ProjectsList.Items.Count != 0)  //проверяем количество существующих в бд проектов
            {
                DataBaseProject dBS = new DataBaseProject();
                foreach (DataBaseProject dbs in cont.DataBaseProjectSet)    //обход проектов в бд
                    if (dbs == ProjectsList.Items[ProjectsList.SelectedIndex])  
                        dBS = dbs;  //запоминается выбранный проект
                Hide();
                FrMain fM = new FrMain();
                fM.currentDBS = dBS.Id; //передаем ид текущего проекта
                fM.ShowDialog();    //переход на главную форму
                Close();
            }
            else
                MessageBox.Show("Нет ни одного проекта в БД");
        }
    }
}
