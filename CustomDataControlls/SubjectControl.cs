using System;
using System.Windows.Forms;
using InstituteDepartment.Domain.EnumerableTypes;

namespace InstituteDepartment.UI.CustomDataControlls
{
    public partial class SubjectControl : UserControl
    {
        public SubjectControl()
        {
            InitializeComponent();
        }

        private void SubjectListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.subjectListBindingSource.EndEdit();
        }
    }
}