using System.ComponentModel;
using System.Windows.Forms;
using InstituteDepartment.Domain.Main;

namespace InstituteDepartment.UI.CustomDataControlls
{
    public partial class TeachersSubjectsControl : UserControl
    {
        public TeachersSubjectsControl()
        {
            InitializeComponent();

            
   


            teachersSubjectsListBindingSource.ListChanged +=TeachersSubjectsListBindingSourceOnListChanged;

        }

        private void TeachersSubjectsListBindingSourceOnListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                var current = (TeachersSubjects) teachersSubjectsListBindingSource.DataSource;
                var teacher = teacherListBindingSource.DataSource as Teacher;

                var idSubject = current.IdSubject;
                var idTeacher = current.IdTeacher;
            }

        }

        private void TeachersSubjectsListDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void TeachersSubjectsControl_Load(object sender, System.EventArgs e)
        {
            dataGridViewTextBoxColumn1.ValueMember = "TeacherNumber";
            dataGridViewTextBoxColumn1.DisplayMember = "TeacherNumber";


            dataGridViewTextBoxColumn2.DisplayMember = "SubjectNumber";
            dataGridViewTextBoxColumn2.ValueMember = "SubjectNumber";


            dataGridViewTextBoxColumn3.DisplayMember = "Name";
            dataGridViewTextBoxColumn3.ValueMember = "Id";

            this.teachersSubjectsListBindingSource.Clear();
        }
    }
}