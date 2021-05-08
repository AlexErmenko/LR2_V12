using System.Windows.Forms;

namespace InstituteDepartment.UI.CustomDataControlls
{
    public partial class TeachersSubjectsControl : UserControl
    {
        public TeachersSubjectsControl()
        {
            InitializeComponent();


            dataGridViewTextBoxColumn1.ValueMember = "TeacherNumber";
            dataGridViewTextBoxColumn1.DisplayMember = "TeacherNumber";


            dataGridViewTextBoxColumn2.DisplayMember = "SubjectNumber";
            dataGridViewTextBoxColumn2.ValueMember = "SubjectNumber";


            dataGridViewTextBoxColumn3.DisplayMember = "Name";
            dataGridViewTextBoxColumn3.ValueMember = "Id";
        }

        private void TeachersSubjectsListDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
    }
}