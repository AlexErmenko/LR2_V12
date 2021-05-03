
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectControl1 = new InstituteDepartment.UI.CustomDataControlls.SubjectControl();
            this.teacherControl1 = new InstituteDepartment.UI.CustomDataControlls.TeacherControl();
            this.SuspendLayout();
            // 
            // subjectControl1
            // 
            this.subjectControl1.AutoSize = true;
            this.subjectControl1.Location = new System.Drawing.Point(23, 343);
            this.subjectControl1.Name = "subjectControl1";
            this.subjectControl1.Size = new System.Drawing.Size(1279, 335);
            this.subjectControl1.TabIndex = 0;
            // 
            // teacherControl1
            // 
            this.teacherControl1.AutoSize = true;
            this.teacherControl1.Location = new System.Drawing.Point(66, 64);
            this.teacherControl1.Name = "teacherControl1";
            this.teacherControl1.Size = new System.Drawing.Size(862, 226);
            this.teacherControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 717);
            this.Controls.Add(this.teacherControl1);
            this.Controls.Add(this.subjectControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InstituteDepartment.UI.CustomDataControlls.SubjectControl subjectControl1;
        private InstituteDepartment.UI.CustomDataControlls.TeacherControl teacherControl1;
    }
}

