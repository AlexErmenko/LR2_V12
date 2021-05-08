using System;
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
            GroupTeacherSubj
                    .teachersSubjectsListBindingSource
                    .DataSource =
                table.TeachersSubjects;

            GroupTeacherSubj.teacherListBindingSource.DataSource = table.TeacherList;


            GroupTeacherSubj.subjectListBindingSource.DataSource = table.SubjectList;

            //Control -> Binding Source Custom Control -> Data Source = 
            // TeacherSubjectsComponent.teacherListBindingSource.DataSource = table.TeachersSubjects;
        }

        public ApplicationSettingsBase Setting { get; set; }

        private void CustomComboControl_Load(object sender,
            EventArgs e)
        {
        }
    }
}