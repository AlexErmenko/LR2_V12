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
    public partial class TeacherControl : UserControl
    {
        public TeacherControl()
        {
            InitializeComponent();
            dataGridViewTextBoxColumn5.ValueMember = "Id";
            dataGridViewTextBoxColumn5.DisplayMember = "Name";
            dataGridViewTextBoxColumn5.DataSource = this.academicDegreesBindingSource;

            dataGridViewTextBoxColumn6.ValueMember = "Id";
            dataGridViewTextBoxColumn6.DisplayMember = "Name";
            dataGridViewTextBoxColumn6.DataSource = this.positionsBindingSource;

        }

        private void TeacherListDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
    }
}