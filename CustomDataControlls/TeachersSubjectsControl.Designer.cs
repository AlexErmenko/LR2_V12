﻿
namespace InstituteDepartment.UI.CustomDataControlls
{
    partial class TeachersSubjectsControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersSubjectsControl));
            this.teachersSubjectsListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.teachersSubjectsListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teachersSubjectsListDataGridView = new System.Windows.Forms.DataGridView();
            this.teachersSubjectsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentTypeLesson = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsListBindingNavigator)).BeginInit();
            this.teachersSubjectsListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfLessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teachersSubjectsListBindingNavigator
            // 
            this.teachersSubjectsListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teachersSubjectsListBindingNavigator.BindingSource = this.teachersSubjectsListBindingSource;
            this.teachersSubjectsListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teachersSubjectsListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teachersSubjectsListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.teachersSubjectsListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.teachersSubjectsListBindingNavigatorSaveItem});
            this.teachersSubjectsListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teachersSubjectsListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teachersSubjectsListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teachersSubjectsListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teachersSubjectsListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teachersSubjectsListBindingNavigator.Name = "teachersSubjectsListBindingNavigator";
            this.teachersSubjectsListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teachersSubjectsListBindingNavigator.Size = new System.Drawing.Size(592, 27);
            this.teachersSubjectsListBindingNavigator.TabIndex = 0;
            this.teachersSubjectsListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // teachersSubjectsListBindingNavigatorSaveItem
            // 
            this.teachersSubjectsListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teachersSubjectsListBindingNavigatorSaveItem.Enabled = false;
            this.teachersSubjectsListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teachersSubjectsListBindingNavigatorSaveItem.Image")));
            this.teachersSubjectsListBindingNavigatorSaveItem.Name = "teachersSubjectsListBindingNavigatorSaveItem";
            this.teachersSubjectsListBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.teachersSubjectsListBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // teachersSubjectsListDataGridView
            // 
            this.teachersSubjectsListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teachersSubjectsListDataGridView.AutoGenerateColumns = false;
            this.teachersSubjectsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersSubjectsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.CurrentTypeLesson});
            this.teachersSubjectsListDataGridView.DataSource = this.teachersSubjectsListBindingSource;
            this.teachersSubjectsListDataGridView.Location = new System.Drawing.Point(0, 34);
            this.teachersSubjectsListDataGridView.Name = "teachersSubjectsListDataGridView";
            this.teachersSubjectsListDataGridView.RowHeadersWidth = 51;
            this.teachersSubjectsListDataGridView.RowTemplate.Height = 24;
            this.teachersSubjectsListDataGridView.Size = new System.Drawing.Size(592, 196);
            this.teachersSubjectsListDataGridView.TabIndex = 1;
            // 
            // teachersSubjectsListBindingSource
            // 
            this.teachersSubjectsListBindingSource.DataSource = typeof(InstituteDepartment.Domain.EnumerableTypes.TeachersSubjectsList);
            // 
            // typeOfLessonBindingSource
            // 
            this.typeOfLessonBindingSource.DataMember = "TypeOfLesson";
            this.typeOfLessonBindingSource.DataSource = this.teachersSubjectsListBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn1.HeaderText = "Преподаватель";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdSubject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GroupNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер группы";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // CurrentTypeLesson
            // 
            this.CurrentTypeLesson.DataPropertyName = "CurrentTypeLesson";
            this.CurrentTypeLesson.DataSource = this.typeOfLessonBindingSource;
            this.CurrentTypeLesson.DisplayMember = "Name";
            this.CurrentTypeLesson.HeaderText = "CurrentTypeLesson";
            this.CurrentTypeLesson.MinimumWidth = 6;
            this.CurrentTypeLesson.Name = "CurrentTypeLesson";
            this.CurrentTypeLesson.ValueMember = "Id";
            this.CurrentTypeLesson.Width = 125;
            // 
            // TeachersSubjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.teachersSubjectsListDataGridView);
            this.Controls.Add(this.teachersSubjectsListBindingNavigator);
            this.Name = "TeachersSubjectsControl";
            this.Size = new System.Drawing.Size(592, 244);
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsListBindingNavigator)).EndInit();
            this.teachersSubjectsListBindingNavigator.ResumeLayout(false);
            this.teachersSubjectsListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersSubjectsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfLessonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton teachersSubjectsListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView teachersSubjectsListDataGridView;
        internal System.Windows.Forms.BindingSource teachersSubjectsListBindingSource;
        internal System.Windows.Forms.BindingNavigator teachersSubjectsListBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrentTypeLesson;
        private System.Windows.Forms.BindingSource typeOfLessonBindingSource;
    }
}