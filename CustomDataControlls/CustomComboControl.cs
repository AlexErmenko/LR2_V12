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
            TeacherSubjectsComponent.teachersSubjectsListBindingSource.DataSource = table.TeachersSubjects;

            //Control -> Binding Source Custom Control -> Data Source = 
            // TeacherSubjectsComponent.teacherListBindingSource.DataSource = table.TeachersSubjects;
            // TeacherSubjectsComponent.teacherListBindingSource.DataSource = table.TeacherList;




        }

        private void CustomComboControl_Load(object sender, EventArgs e)
        {



        }
    }
}
