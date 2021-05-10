using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using InstituteDepartment.Domain.EnumerableTypes;

namespace InstituteDepartment.UI.CustomDataControlls
{
    public partial class CustomComboControl : UserControl
    {
        public CustomComboControl()
        {
            InitializeComponent();
            var table = new TimeTable();

            //Привязали предметы
            GroupViewSubhectComponent.subjectListBindingSource.DataSource = table.SubjectList;

            //Привязали препода
            GroupTeacherComponent.teacherListBindingSource.DataSource = table.TeacherList;

            //Связали вместе 
            GroupTeacherSubj.teachersSubjectsListBindingSource
                    .DataSource =
                table.TeachersSubjects;
            GroupTeacherSubj.teachersSubjectsListBindingSource.ListChanged += TeachersSubjectsListBindingSource_ListChanged;
            GroupTeacherSubj.teacherListBindingSource.DataSource = table.TeacherList;


            GroupTeacherSubj.subjectListBindingSource.DataSource = table.SubjectList;
            timeTableBindingSource.DataSource = table;

            this.timeTableBindingSource.ResetBindings(false);
        }

        private void TeachersSubjectsListBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
        }

        public ApplicationSettingsBase Setting { get; set; }

        private void CustomComboControl_Load(object sender,
            EventArgs e)
        {
            var applicationSettingsBase = Setting;


            this.timeTableBindingSource.Clear();


            timeTableBindingSource.PositionChanged += TimeTableBindingSource_PositionChanged
                ;
        }

        private void TimeTableBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GroupTeacherSubj.valuemember1))
            {
                
            }

        }

        private void TabControl_Selected(object sender,
            TabControlEventArgs e)
        {
            if (e.TabPage == tabPage3)
            {
                GroupTeacherSubj.teachersSubjectsListBindingNavigator.DeleteItem.Enabled =
                    (bool) Setting["AllowCascadeDelete"];


                GroupTeacherSubj.teachersSubjectsListBindingNavigator.AddNewItem.Enabled =
                    (bool) Setting["AllowReferenceToReferenceRelation"];
            }
        }
    }
}