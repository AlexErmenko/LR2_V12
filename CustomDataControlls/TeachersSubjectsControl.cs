using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using InstituteDepartment.Domain.EnumerableTypes;
using InstituteDepartment.Domain.Main;

namespace InstituteDepartment.UI.CustomDataControlls
{
    public partial class TeachersSubjectsControl : UserControl
    {

        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }

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
                teacherListBindingSource.Clear();
                subjectListBindingSource.Clear();


                teacherListBindingSource.ResetBindings(false);
                subjectListBindingSource.ResetBindings(false);

                var idSubject = current.IdSubject;



                var idTeacher = current.IdTeacher;


                var teacher1 = teacherListBindingSource.Current as Teacher;
                var subject2 = subjectListBindingSource.Current as Subject;



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
            teachersSubjectsListBindingSource.ResetBindings(
                false);
        }

        private void BindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            var teachersSubjects = teachersSubjectsListBindingSource.Current as TeachersSubjects;

             valuemember1 = dataGridViewTextBoxColumn1.ValueMember;
             valuemember2 = dataGridViewTextBoxColumn2.ValueMember;

        }

        public string valuemember1 { get; set; }
        public string valuemember2 { get; set; } 

        private void TeachersSubjectsListBindingSource_PositionChanged(object sender, System.EventArgs e)
        {
            var current = this.teachersSubjectsListBindingSource.Current as TeachersSubjects;

            if (current == null || this.teachersSubjectsListBindingSource.Position == 0)
            {
                return;
            }

            var teacherList = this.teacherListBindingSource.DataSource as TeacherList;
            var subjectList = this.subjectListBindingSource.DataSource as SubjectList;

            var teacherToRemove = teacherList.FirstOrDefault(it => it .TeacherNumber.Equals(current.IdTeacher));
            var subjectToRemove = subjectList.FirstOrDefault(it => it.SubjectNumber.Equals(current.IdTeacher));

            this.teacherListBindingSource.Remove(teacherToRemove);
            this.subjectListBindingSource.Remove(subjectToRemove);

            
            this.subjectListBindingSource.EndEdit();
            this.teacherListBindingSource.EndEdit();
            
            this.teacherListBindingSource.Clear();
            this.subjectListBindingSource.Clear();


            this.teacherListBindingSource.ResetBindings(false);
            this.subjectListBindingSource.ResetBindings(false);

            
        }
    }
}