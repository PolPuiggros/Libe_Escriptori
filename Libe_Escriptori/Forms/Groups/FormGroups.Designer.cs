﻿using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Groups
{
    partial class FormGroups
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.comboBoxFilterGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterLetter = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.bindingSourceCourses = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupletterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.headerDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.comboBoxFilterGrade);
            this.panelGroups.Controls.Add(this.comboBoxFilterLetter);
            this.panelGroups.Controls.Add(this.comboBoxFilter);
            this.panelGroups.Controls.Add(this.dataGridViewGroups);
            this.panelGroups.Controls.Add(this.buttonNewGroup);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(0, 0);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(1005, 650);
            this.panelGroups.TabIndex = 0;
            // 
            // comboBoxFilterGrade
            // 
            this.comboBoxFilterGrade.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilterGrade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFilterGrade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilterGrade.FormattingEnabled = true;
            this.comboBoxFilterGrade.IntegralHeight = false;
            this.comboBoxFilterGrade.ItemHeight = 21;
            this.comboBoxFilterGrade.Location = new System.Drawing.Point(626, 54);
            this.comboBoxFilterGrade.MaximumSize = new System.Drawing.Size(172, 0);
            this.comboBoxFilterGrade.MinimumSize = new System.Drawing.Size(104, 0);
            this.comboBoxFilterGrade.Name = "comboBoxFilterGrade";
            this.comboBoxFilterGrade.Size = new System.Drawing.Size(164, 29);
            this.comboBoxFilterGrade.TabIndex = 11;
            this.comboBoxFilterGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterGrade_SelectedIndexChanged);
            // 
            // comboBoxFilterLetter
            // 
            this.comboBoxFilterLetter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilterLetter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFilterLetter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilterLetter.FormattingEnabled = true;
            this.comboBoxFilterLetter.IntegralHeight = false;
            this.comboBoxFilterLetter.ItemHeight = 21;
            this.comboBoxFilterLetter.Location = new System.Drawing.Point(809, 54);
            this.comboBoxFilterLetter.MaximumSize = new System.Drawing.Size(172, 0);
            this.comboBoxFilterLetter.MinimumSize = new System.Drawing.Size(104, 0);
            this.comboBoxFilterLetter.Name = "comboBoxFilterLetter";
            this.comboBoxFilterLetter.Size = new System.Drawing.Size(164, 29);
            this.comboBoxFilterLetter.TabIndex = 10;
            this.comboBoxFilterLetter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterLetter_SelectedIndexChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilter.DataSource = this.bindingSourceCourses;
            this.comboBoxFilter.DisplayMember = "abreviation";
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.IntegralHeight = false;
            this.comboBoxFilter.ItemHeight = 21;
            this.comboBoxFilter.Location = new System.Drawing.Point(444, 54);
            this.comboBoxFilter.MaximumSize = new System.Drawing.Size(172, 0);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(104, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(164, 29);
            this.comboBoxFilter.TabIndex = 9;
            this.comboBoxFilter.ValueMember = "id";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // bindingSourceCourses
            // 
            this.bindingSourceCourses.DataSource = typeof(Libe_Escriptori.Models.courses);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AllowUserToResizeColumns = false;
            this.dataGridViewGroups.AllowUserToResizeRows = false;
            this.dataGridViewGroups.AutoGenerateColumns = false;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGroups.ColumnHeadersHeight = 30;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.groupletterDataGridViewTextBoxColumn,
            this.tutoridDataGridViewTextBoxColumn,
            this.studentsDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.scheduleidDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn,
            this.profesorsDataGridViewTextBoxColumn,
            this.schedulesDataGridViewTextBoxColumn,
            this.headerEdit,
            this.headerDelete});
            this.dataGridViewGroups.DataSource = this.bindingSourceGroups;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGroups.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGroups.Location = new System.Drawing.Point(46, 103);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 30;
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.Size = new System.Drawing.Size(927, 498);
            this.dataGridViewGroups.TabIndex = 5;
            this.dataGridViewGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellClick);
            this.dataGridViewGroups.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "Cicle";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Any";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupletterDataGridViewTextBoxColumn
            // 
            this.groupletterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupletterDataGridViewTextBoxColumn.DataPropertyName = "group_letter";
            this.groupletterDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.groupletterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupletterDataGridViewTextBoxColumn.Name = "groupletterDataGridViewTextBoxColumn";
            this.groupletterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutoridDataGridViewTextBoxColumn
            // 
            this.tutoridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tutoridDataGridViewTextBoxColumn.DataPropertyName = "tutor_id";
            this.tutoridDataGridViewTextBoxColumn.HeaderText = "Tutor";
            this.tutoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutoridDataGridViewTextBoxColumn.Name = "tutoridDataGridViewTextBoxColumn";
            this.tutoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsDataGridViewTextBoxColumn
            // 
            this.studentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentsDataGridViewTextBoxColumn.DataPropertyName = "students";
            this.studentsDataGridViewTextBoxColumn.HeaderText = "Alumnes";
            this.studentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentsDataGridViewTextBoxColumn.Name = "studentsDataGridViewTextBoxColumn";
            this.studentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleidDataGridViewTextBoxColumn
            // 
            this.scheduleidDataGridViewTextBoxColumn.DataPropertyName = "schedule_id";
            this.scheduleidDataGridViewTextBoxColumn.HeaderText = "schedule_id";
            this.scheduleidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scheduleidDataGridViewTextBoxColumn.Name = "scheduleidDataGridViewTextBoxColumn";
            this.scheduleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.scheduleidDataGridViewTextBoxColumn.Visible = false;
            this.scheduleidDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "courses";
            this.coursesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursesDataGridViewTextBoxColumn.Visible = false;
            this.coursesDataGridViewTextBoxColumn.Width = 125;
            // 
            // profesorsDataGridViewTextBoxColumn
            // 
            this.profesorsDataGridViewTextBoxColumn.DataPropertyName = "profesors";
            this.profesorsDataGridViewTextBoxColumn.HeaderText = "profesors";
            this.profesorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profesorsDataGridViewTextBoxColumn.Name = "profesorsDataGridViewTextBoxColumn";
            this.profesorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.profesorsDataGridViewTextBoxColumn.Visible = false;
            this.profesorsDataGridViewTextBoxColumn.Width = 125;
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            this.schedulesDataGridViewTextBoxColumn.DataPropertyName = "schedules";
            this.schedulesDataGridViewTextBoxColumn.HeaderText = "schedules";
            this.schedulesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            this.schedulesDataGridViewTextBoxColumn.ReadOnly = true;
            this.schedulesDataGridViewTextBoxColumn.Visible = false;
            this.schedulesDataGridViewTextBoxColumn.Width = 125;
            // 
            // headerEdit
            // 
            this.headerEdit.HeaderText = "";
            this.headerEdit.Image = global::Libe_Escriptori.Properties.Resources.pencil1;
            this.headerEdit.MinimumWidth = 6;
            this.headerEdit.Name = "headerEdit";
            this.headerEdit.ReadOnly = true;
            this.headerEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.headerEdit.Width = 40;
            // 
            // headerDelete
            // 
            this.headerDelete.HeaderText = "";
            this.headerDelete.Image = global::Libe_Escriptori.Properties.Resources.close__1_;
            this.headerDelete.MinimumWidth = 6;
            this.headerDelete.Name = "headerDelete";
            this.headerDelete.ReadOnly = true;
            this.headerDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.headerDelete.Width = 40;
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(Libe_Escriptori.Models.groups);
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonNewGroup.FlatAppearance.BorderSize = 0;
            this.buttonNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonNewGroup.ForeColor = System.Drawing.Color.White;
            this.buttonNewGroup.Location = new System.Drawing.Point(46, 54);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(137, 31);
            this.buttonNewGroup.TabIndex = 4;
            this.buttonNewGroup.Text = "Nou";
            this.buttonNewGroup.UseVisualStyleBackColor = false;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click_1);
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelGroups);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.Load += new System.EventHandler(this.FormGroups_Load);
            this.panelGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGroups;
        private DataGridView dataGridViewGroups;
        private Button buttonNewGroup;
        private ComboBox comboBoxFilter;
        private ComboBox comboBoxFilterLetter;
        private ComboBox comboBoxFilterGrade;
        private BindingSource bindingSourceGroups;
        private DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupletterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tutoridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scheduleidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private DataGridViewImageColumn headerEdit;
        private DataGridViewImageColumn headerDelete;
        private BindingSource bindingSourceCourses;
    }
}