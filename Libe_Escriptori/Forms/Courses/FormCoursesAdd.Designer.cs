using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Courses
{
    partial class FormCoursesAdd
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
            this.panelCoursesAdd = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewModules = new System.Windows.Forms.DataGridView();
            this.buttonExistent = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceModules = new System.Windows.Forms.BindingSource(this.components);
            this.panelCoursesAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModules)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCoursesAdd
            // 
            this.panelCoursesAdd.Controls.Add(this.buttonCancel);
            this.panelCoursesAdd.Controls.Add(this.buttonSave);
            this.panelCoursesAdd.Controls.Add(this.dataGridViewModules);
            this.panelCoursesAdd.Controls.Add(this.buttonExistent);
            this.panelCoursesAdd.Controls.Add(this.buttonNew);
            this.panelCoursesAdd.Controls.Add(this.comboBox1);
            this.panelCoursesAdd.Controls.Add(this.textBox3);
            this.panelCoursesAdd.Controls.Add(this.textBoxFullName);
            this.panelCoursesAdd.Controls.Add(this.textBoxAbbreviation);
            this.panelCoursesAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoursesAdd.Location = new System.Drawing.Point(0, 0);
            this.panelCoursesAdd.Name = "panelCoursesAdd";
            this.panelCoursesAdd.Size = new System.Drawing.Size(861, 563);
            this.panelCoursesAdd.TabIndex = 0;
            this.panelCoursesAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCoursesAdd_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonCancel.Location = new System.Drawing.Point(321, 479);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 36);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(469, 479);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 36);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // dataGridViewModules
            // 
            this.dataGridViewModules.AllowUserToAddRows = false;
            this.dataGridViewModules.AllowUserToDeleteRows = false;
            this.dataGridViewModules.AutoGenerateColumns = false;
            this.dataGridViewModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.totalhoursDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridViewModules.DataSource = this.bindingSourceModules;
            this.dataGridViewModules.Location = new System.Drawing.Point(69, 218);
            this.dataGridViewModules.Name = "dataGridViewModules";
            this.dataGridViewModules.ReadOnly = true;
            this.dataGridViewModules.RowHeadersVisible = false;
            this.dataGridViewModules.RowTemplate.Height = 25;
            this.dataGridViewModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModules.Size = new System.Drawing.Size(729, 247);
            this.dataGridViewModules.TabIndex = 6;
            this.dataGridViewModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModules_CellClick);
            this.dataGridViewModules.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewModules_CellFormatting);
            this.dataGridViewModules.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewModules_CellPainting);
            // 
            // buttonExistent
            // 
            this.buttonExistent.BackColor = System.Drawing.Color.White;
            this.buttonExistent.FlatAppearance.BorderSize = 0;
            this.buttonExistent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExistent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonExistent.Location = new System.Drawing.Point(202, 179);
            this.buttonExistent.Name = "buttonExistent";
            this.buttonExistent.Size = new System.Drawing.Size(117, 27);
            this.buttonExistent.TabIndex = 5;
            this.buttonExistent.Text = "Mòdul Existent";
            this.buttonExistent.UseVisualStyleBackColor = false;
            this.buttonExistent.Click += new System.EventHandler(this.buttonExistent_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonNew.Location = new System.Drawing.Point(69, 179);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(117, 27);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Nou Mòdul";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Departament"});
            this.comboBox1.Location = new System.Drawing.Point(69, 127);
            this.comboBox1.MaximumSize = new System.Drawing.Size(266, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(266, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox3.Location = new System.Drawing.Point(396, 126);
            this.textBox3.MaximumSize = new System.Drawing.Size(403, 31);
            this.textBox3.MinimumSize = new System.Drawing.Size(403, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(403, 29);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Coordinador";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFullName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFullName.Location = new System.Drawing.Point(302, 65);
            this.textBoxFullName.MaximumSize = new System.Drawing.Size(497, 31);
            this.textBoxFullName.MinimumSize = new System.Drawing.Size(497, 31);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(497, 29);
            this.textBoxFullName.TabIndex = 1;
            this.textBoxFullName.Text = " Nom Complert del curs";
            this.textBoxFullName.Enter += new System.EventHandler(this.textBoxFullName_Enter);
            this.textBoxFullName.Leave += new System.EventHandler(this.textBoxFullName_Leave);
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxAbbreviation.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAbbreviation.Location = new System.Drawing.Point(69, 65);
            this.textBoxAbbreviation.MaximumSize = new System.Drawing.Size(169, 31);
            this.textBoxAbbreviation.MinimumSize = new System.Drawing.Size(169, 31);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(169, 29);
            this.textBoxAbbreviation.TabIndex = 0;
            this.textBoxAbbreviation.Text = " Abreviació";
            this.textBoxAbbreviation.Enter += new System.EventHandler(this.textBoxAbbreviation_Enter);
            this.textBoxAbbreviation.Leave += new System.EventHandler(this.textBoxAbbreviation_Leave);
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Width = 5;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Width = 5;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Abreviació";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalhoursDataGridViewTextBoxColumn
            // 
            this.totalhoursDataGridViewTextBoxColumn.DataPropertyName = "total_hours";
            this.totalhoursDataGridViewTextBoxColumn.HeaderText = "Hores ";
            this.totalhoursDataGridViewTextBoxColumn.Name = "totalhoursDataGridViewTextBoxColumn";
            this.totalhoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Num UFs";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceModules
            // 
            this.bindingSourceModules.DataSource = typeof(Libe_Escriptori.Models.modules);
            this.bindingSourceModules.CurrentChanged += new System.EventHandler(this.bindingSourceModules_CurrentChanged);
            // 
            // FormCoursesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 563);
            this.Controls.Add(this.panelCoursesAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCoursesAdd";
            this.Text = "FormModules";
            this.Load += new System.EventHandler(this.FormCoursesAdd_Load);
            this.panelCoursesAdd.ResumeLayout(false);
            this.panelCoursesAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCoursesAdd;
        private Button buttonNew;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBoxFullName;
        private TextBox textBoxAbbreviation;
        private Button buttonSave;
        private DataGridView dataGridViewModules;
        private Button buttonExistent;
        private Button buttonCancel;
        private BindingSource bindingSourceModules;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalhoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn ColumnEdit;
        private DataGridViewButtonColumn ColumnDelete;
    }
}