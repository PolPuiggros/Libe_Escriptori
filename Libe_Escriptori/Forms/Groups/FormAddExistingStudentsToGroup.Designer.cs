using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Groups
{
    partial class FormAddExistingStudentsToGroup
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
            this.dataGridViewExistingStudents = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSaveStudentsGroup = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExistingStudents
            // 
            this.dataGridViewExistingStudents.AllowUserToAddRows = false;
            this.dataGridViewExistingStudents.AllowUserToDeleteRows = false;
            this.dataGridViewExistingStudents.AllowUserToResizeColumns = false;
            this.dataGridViewExistingStudents.AllowUserToResizeRows = false;
            this.dataGridViewExistingStudents.AutoGenerateColumns = false;
            this.dataGridViewExistingStudents.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExistingStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExistingStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExistingStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.surname2DataGridViewTextBoxColumn,
            this.groupidDataGridViewTextBoxColumn,
            this.headerGroup});
            this.dataGridViewExistingStudents.DataSource = this.studentsBindingSource;
            this.dataGridViewExistingStudents.Location = new System.Drawing.Point(20, 47);
            this.dataGridViewExistingStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewExistingStudents.MultiSelect = false;
            this.dataGridViewExistingStudents.Name = "dataGridViewExistingStudents";
            this.dataGridViewExistingStudents.RowHeadersVisible = false;
            this.dataGridViewExistingStudents.RowHeadersWidth = 51;
            this.dataGridViewExistingStudents.RowTemplate.Height = 25;
            this.dataGridViewExistingStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExistingStudents.Size = new System.Drawing.Size(459, 284);
            this.dataGridViewExistingStudents.TabIndex = 0;
            this.dataGridViewExistingStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExistingStudents_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "1r Cognom";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surname2DataGridViewTextBoxColumn
            // 
            this.surname2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname2DataGridViewTextBoxColumn.DataPropertyName = "surname2";
            this.surname2DataGridViewTextBoxColumn.HeaderText = "2n Cognom";
            this.surname2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surname2DataGridViewTextBoxColumn.Name = "surname2DataGridViewTextBoxColumn";
            this.surname2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "group_id";
            this.groupidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupidDataGridViewTextBoxColumn.Visible = false;
            this.groupidDataGridViewTextBoxColumn.Width = 125;
            // 
            // headerGroup
            // 
            this.headerGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.headerGroup.HeaderText = "DAM1A";
            this.headerGroup.MinimumWidth = 6;
            this.headerGroup.Name = "headerGroup";
            this.headerGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGroup.Width = 84;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataSource = typeof(Libe_Escriptori.Models.students);
            // 
            // buttonSaveStudentsGroup
            // 
            this.buttonSaveStudentsGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSaveStudentsGroup.FlatAppearance.BorderSize = 0;
            this.buttonSaveStudentsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveStudentsGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSaveStudentsGroup.ForeColor = System.Drawing.Color.White;
            this.buttonSaveStudentsGroup.Location = new System.Drawing.Point(201, 346);
            this.buttonSaveStudentsGroup.Name = "buttonSaveStudentsGroup";
            this.buttonSaveStudentsGroup.Size = new System.Drawing.Size(103, 32);
            this.buttonSaveStudentsGroup.TabIndex = 1;
            this.buttonSaveStudentsGroup.Text = "Guardar";
            this.buttonSaveStudentsGroup.UseVisualStyleBackColor = false;
            this.buttonSaveStudentsGroup.Click += new System.EventHandler(this.buttonSaveStudentsGroup_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::Libe_Escriptori.Properties.Resources.close1;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(548, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(15, 16);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 19);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // FormAddExistingStudentsToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(498, 402);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSaveStudentsGroup);
            this.Controls.Add(this.dataGridViewExistingStudents);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddExistingStudentsToGroup";
            this.Text = "FormAddExistingStudentsToGroup";
            this.Load += new System.EventHandler(this.FormAddExistingStudentsToGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewExistingStudents;
        private Button buttonSaveStudentsGroup;
        private Button buttonClose;
        private Panel panel1;
        private BindingSource studentsBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surname2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn headerGroup;
    }
}