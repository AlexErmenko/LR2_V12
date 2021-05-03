
namespace WindowsFormsApp1
{
    partial class MainSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = global::WindowsFormsApp1.Properties.Settings.Default.AllowCascadeDelete;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "AllowCascadeDelete", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(6, 183);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(401, 72);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Дозвіл каскадного видалення";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = global::WindowsFormsApp1.Properties.Settings.Default.BlockingRemoveRecord;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "BlockingRemoveRecord", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(6, 82);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(432, 77);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Блокування видалення записів таблиць даних, на які посилаються інші записи предме" +
    "тної області.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = global::WindowsFormsApp1.Properties.Settings.Default.ManagePermission;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "ManagePermission", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(6, -1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(432, 77);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Управління дозволом / забороною додавання записів, які посилаються на інші записи" +
    " предметної області.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 266);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}