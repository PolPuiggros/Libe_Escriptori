using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
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
            this.headerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.comboBox3);
            this.panelGroups.Controls.Add(this.comboBox1);
            this.panelGroups.Controls.Add(this.comboBoxFilter);
            this.panelGroups.Controls.Add(this.dataGridViewGroups);
            this.panelGroups.Controls.Add(this.buttonNewGroup);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(0, 0);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(1005, 650);
            this.panelGroups.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.ItemHeight = 21;
            this.comboBox3.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBox3.Location = new System.Drawing.Point(626, 54);
            this.comboBox3.MaximumSize = new System.Drawing.Size(172, 0);
            this.comboBox3.MinimumSize = new System.Drawing.Size(104, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(164, 29);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.Text = "Classe";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 21;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBox1.Location = new System.Drawing.Point(809, 54);
            this.comboBox1.MaximumSize = new System.Drawing.Size(172, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(104, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 29);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Any";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.IntegralHeight = false;
            this.comboBoxFilter.ItemHeight = 21;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBoxFilter.Location = new System.Drawing.Point(444, 54);
            this.comboBoxFilter.MaximumSize = new System.Drawing.Size(172, 0);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(104, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(164, 29);
            this.comboBoxFilter.TabIndex = 9;
            this.comboBoxFilter.Text = "Cicle";
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AllowUserToResizeColumns = false;
            this.dataGridViewGroups.AllowUserToResizeRows = false;
            this.dataGridViewGroups.AutoGenerateColumns = false;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGroups.ColumnHeadersHeight = 35;
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
            this.dataGridViewGroups.Location = new System.Drawing.Point(46, 103);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 25;
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.Size = new System.Drawing.Size(927, 498);
            this.dataGridViewGroups.TabIndex = 5;
            this.dataGridViewGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellClick);
            this.dataGridViewGroups.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridViewGroups.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
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
            this.headerEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.headerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerEdit.HeaderText = "";
            this.headerEdit.MinimumWidth = 6;
            this.headerEdit.Name = "headerEdit";
            this.headerEdit.ReadOnly = true;
            this.headerEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.headerEdit.Width = 29;
            // 
            // headerDelete
            // 
            this.headerDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.headerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerDelete.HeaderText = "";
            this.headerDelete.MinimumWidth = 6;
            this.headerDelete.Name = "headerDelete";
            this.headerDelete.ReadOnly = true;
            this.headerDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.headerDelete.Width = 29;
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(Libe_Escriptori.Models.groups);
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.BackColor = System.Drawing.Color.White;
            this.buttonNewGroup.FlatAppearance.BorderSize = 0;
            this.buttonNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonNewGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewGroup.Location = new System.Drawing.Point(46, 54);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(137, 31);
            this.buttonNewGroup.TabIndex = 4;
            this.buttonNewGroup.Text = "Nou";
            this.buttonNewGroup.UseVisualStyleBackColor = false;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click_1);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(Libe_Escriptori.Models.groups);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGroups;
        private DataGridView dataGridViewGroups;
        private Button buttonNewGroup;
        private ComboBox comboBoxFilter;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private BindingSource groupsBindingSource;
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
        private DataGridViewButtonColumn headerEdit;
        private DataGridViewButtonColumn headerDelete;
    }
}