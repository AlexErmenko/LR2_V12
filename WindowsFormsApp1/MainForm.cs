using System;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

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
            var mainSettings = new MainSettings();
            mainSettings.FormClosed += MainSettings_FormClosed;
            mainSettings.ShowDialog();
        }

        private void MainSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
            CustomTabControl.timeTableBindingSource.ResetBindings(false);


            #region CascadeDelete

            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingNavigator.DeleteItem.Enabled =
                Properties.Settings.Default.AllowCascadeDelete;

            CustomTabControl.GroupTeacherComponent.teacherListBindingNavigator.DeleteItem.Enabled =
                Properties.Settings.Default.AllowCascadeDelete;

            CustomTabControl.GroupViewSubhectComponent.subjectListBindingNavigator.DeleteItem.Enabled =
                Properties.Settings.Default.AllowCascadeDelete;

            #endregion


            #region AllowAddNew
            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingNavigator.AddNewItem.Enabled =
                Settings.Default.AllowReferenceToReferenceRelation;

            #endregion
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomTabControl.Setting = Settings.Default;
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