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
    public partial class ProjectAdding : Form
    {

        public ProjectAdding()
        {
            InitializeComponent();
        }
        CaseModelContainer cont = new CaseModelContainer();
        private void SaveProject_Click(object sender, EventArgs e)
        {   //сохранение проекта в бд
            if (ProjectName.Text != "") //введен ли проект?
            {
                bool inDBS = false; //флаг, показывающий, есть ли в бд проект с таким же названием  
                if (cont.DataBaseProjectSet.Count() != 0)
                {   //обход проектов в бд
                    foreach (DataBaseProject dbp in cont.DataBaseProjectSet)
                        if (dbp.Name == ProjectName.Text)   //сравнение названий проектов
                            inDBS = true;
                }
                if (!inDBS) //в бд нет проектов с таким же названием
                {
                    DataBaseProject dbp = new DataBaseProject   //создание нового проекта
                    {
                        Name = ProjectName.Text,
                        Description = ProjectDscr.Text
                    };
                    cont.DataBaseProjectSet.Add(dbp);   //добавление в базу данных
                    cont.SaveChanges(); //сохранение изменений
                    Hide();
                    FrProjects fp = new FrProjects();
                    fp.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Такой проект уже есть в базе данных");
            }
            else MessageBox.Show("Не введено название проекта");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {   //кнопка "отмена" 
            Hide();
            FrProjects fp = new FrProjects();
            fp.ShowDialog();
            Close();
        }

        private void ProjectAdding_Load(object sender, EventArgs e)
        {
            //
        }

        private void ProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {   //проверка ввода данных для названия проекта
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void ProjectDscr_KeyPress(object sender, KeyPressEventArgs e)
        {//проверка ввода данных для описания проекта
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }
    }
}
