using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstituteDepartment.Domain.EnumerableTypes;

namespace InstituteDepartment.UI.CustomDataControlls
{
    public partial class CustomComboControl : UserControl
    {
        public ApplicationSettingsBase Setting { get; set; }


        public CustomComboControl()
        {
            InitializeComponent();

            TimeTable table = new TimeTable();


            //Привязали предметы
            GroupViewSubhectComponent.subjectListBindingSource.DataSource = table.SubjectList;

            //Привязали препода
            GroupTeacherComponent.teacherListBindingSource.DataSource = table.TeacherList;


            //Связали вместе 
            teachersSubjectsControl1
                    .teachersSubjectsListBindingSource
                    .DataSource =
                table.TeachersSubjects;

            teachersSubjectsControl1.teacherListBindingSource.DataSource = table.TeacherList;



            teachersSubjectsControl1.subjectListBindingSource.DataSource = table.SubjectList;

            //Control -> Binding Source Custom Control -> Data Source = 
            // TeacherSubjectsComponent.teacherListBindingSource.DataSource = table.TeachersSubjects;
        }

        private void CustomComboControl_Load(object sender, EventArgs e)
        {
        }
    }
}