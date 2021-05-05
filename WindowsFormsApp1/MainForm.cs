using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstituteDepartment.UI.CustomDataControlls;
namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void НалаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainSettings().ShowDialog();
        }
    }
}


//ToDo:  Добавить реализацию вкладки TeacherSubjects.
//ToDo:  Добавить реализацию списка TeacherSubjectsList.
//ToDo:  Добавить реализацию привязки Teacher и Subject через Value member TeacherSubjects.
//ToDo:  Переименовать основную форму.
//ToDo:  Проверить ещё раз настройки, нам нужна область видимости User.
//ToDo:  Проверить ещё раз настройки, они должны сохраняться между сеансами приложения.
//ToDo:  Реализовать функционал настроек.
//ToDo:  Реализовать функционал каскадного удаления.
//ToDo:  Настроить для кнопки Delete свойство Enable в зависимости от того есть ли элементы и вкл.? ли настройка .

