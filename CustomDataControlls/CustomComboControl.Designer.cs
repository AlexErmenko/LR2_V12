
namespace InstituteDepartment.UI.CustomDataControlls
{
    partial class CustomComboControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.subjectControl1 = new InstituteDepartment.UI.CustomDataControlls.SubjectControl();
            this.teacherControl1 = new InstituteDepartment.UI.CustomDataControlls.TeacherControl();
            this.teachersSubjectsControl1 = new InstituteDepartment.UI.CustomDataControlls.TeachersSubjectsControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.subjectControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Предмети";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.teacherControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Викладачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.teachersSubjectsControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Викладачи та Предметы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // subjectControl1
            // 
            this.subjectControl1.AutoSize = true;
            this.subjectControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectControl1.Location = new System.Drawing.Point(3, 3);
            this.subjectControl1.Name = "subjectControl1";
            this.subjectControl1.Size = new System.Drawing.Size(791, 322);
            this.subjectControl1.TabIndex = 0;
            // 
            // teacherControl1
            // 
            this.teacherControl1.AutoSize = true;
            this.teacherControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherControl1.Location = new System.Drawing.Point(3, 3);
            this.teacherControl1.Name = "teacherControl1";
            this.teacherControl1.Size = new System.Drawing.Size(791, 322);
            this.teacherControl1.TabIndex = 0;
            // 
            // teachersSubjectsControl1
            // 
            this.teachersSubjectsControl1.AutoSize = true;
            this.teachersSubjectsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersSubjectsControl1.Location = new System.Drawing.Point(3, 3);
            this.teachersSubjectsControl1.Name = "teachersSubjectsControl1";
            this.teachersSubjectsControl1.Size = new System.Drawing.Size(791, 322);
            this.teachersSubjectsControl1.TabIndex = 0;
            // 
            // CustomComboControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomComboControl";
            this.Size = new System.Drawing.Size(805, 357);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private TeacherControl teacherControl1;
        private SubjectControl subjectControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private TeachersSubjectsControl teachersSubjectsControl1;
    }
}
