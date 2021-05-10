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
            CustomTabControl.Setting = Settings.Default;
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

            CustomTabControl.GroupTeacherComponent.teacherListBindingNavigator.DeleteItem.Enabled =
                Settings.Default.AllowCascadeDelete;

            CustomTabControl.GroupTeacherComponent.teacherListBindingNavigator.DeleteItem.Enabled =
                Settings.Default.AllowCascadeDelete;

            CustomTabControl.GroupViewSubhectComponent.subjectListBindingNavigator.DeleteItem.Enabled =
                Settings.Default.AllowCascadeDelete && this.CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingSource.Count > 0;

            #endregion


            #region AllowAddNew

            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingNavigator.AddNewItem.Enabled =
                Settings.Default.AllowReferenceToReferenceRelation && (this.CustomTabControl.GroupTeacherSubj.subjectListBindingSource.Count > 0 && this.CustomTabControl.GroupTeacherSubj.teacherListBindingSource.Count > 0);


            #endregion
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region CascadeDelete

            CustomTabControl.GroupTeacherComponent.teacherListBindingNavigator.DeleteItem.Enabled =
                Settings.Default.AllowCascadeDelete;

            CustomTabControl.GroupViewSubhectComponent.subjectListBindingNavigator.DeleteItem.Enabled =
                Settings.Default.AllowCascadeDelete;
            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingNavigator.DeleteItem.Enabled =
                Settings.Default.AllowCascadeDelete && this.CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingSource.Count > 0;

            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingNavigator.Refresh();

            #endregion


            #region AllowAddNew

            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingNavigator.AddNewItem.Enabled =
                Settings.Default.AllowReferenceToReferenceRelation && (this.CustomTabControl.GroupTeacherSubj.subjectListBindingSource.Count > 0 && this.CustomTabControl.GroupTeacherSubj.teacherListBindingSource.Count > 0);

            #endregion
            Refresh();
            CustomTabControl.GroupTeacherSubj.teachersSubjectsListBindingSource.Clear();
        }
    }
}


//ToDo:  Реализовать функционал каскадного удаления.
//ToDo:  Настроить для кнопки Delete свойство Enable в зависимости от того есть ли элементы и вкл.? ли настройка .