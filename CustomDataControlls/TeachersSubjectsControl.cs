using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void TeachersSubjectsListDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
