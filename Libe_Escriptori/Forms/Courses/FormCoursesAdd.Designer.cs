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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCoursesAdd = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewModules = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSourceModules = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExistent = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.bindingSourceDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCoordinator = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.panelCoursesAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCoursesAdd
            // 
            this.panelCoursesAdd.Controls.Add(this.buttonCancel);
            this.panelCoursesAdd.Controls.Add(this.buttonSave);
            this.panelCoursesAdd.Controls.Add(this.dataGridViewModules);
            this.panelCoursesAdd.Controls.Add(this.buttonExistent);
            this.panelCoursesAdd.Controls.Add(this.buttonNew);
            this.panelCoursesAdd.Controls.Add(this.comboBoxDepartment);
            this.panelCoursesAdd.Controls.Add(this.textBoxCoordinator);
            this.panelCoursesAdd.Controls.Add(this.textBoxFullName);
            this.panelCoursesAdd.Controls.Add(this.textBoxAbbreviation);
            this.panelCoursesAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoursesAdd.Location = new System.Drawing.Point(0, 0);
            this.panelCoursesAdd.Name = "panelCoursesAdd";
            this.panelCoursesAdd.Size = new System.Drawing.Size(1005, 650);
            this.panelCoursesAdd.TabIndex = 0;
            this.panelCoursesAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCoursesAdd_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonCancel.Location = new System.Drawing.Point(375, 553);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 41);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(547, 553);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 41);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewModules
            // 
            this.dataGridViewModules.AllowUserToAddRows = false;
            this.dataGridViewModules.AllowUserToDeleteRows = false;
            this.dataGridViewModules.AllowUserToResizeColumns = false;
            this.dataGridViewModules.AllowUserToResizeRows = false;
            this.dataGridViewModules.AutoGenerateColumns = false;
            this.dataGridViewModules.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.totalhoursDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridViewModules.DataSource = this.bindingSourceModules;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewModules.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewModules.Location = new System.Drawing.Point(80, 252);
            this.dataGridViewModules.Name = "dataGridViewModules";
            this.dataGridViewModules.ReadOnly = true;
            this.dataGridViewModules.RowHeadersVisible = false;
            this.dataGridViewModules.RowHeadersWidth = 51;
            this.dataGridViewModules.RowTemplate.Height = 30;
            this.dataGridViewModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModules.Size = new System.Drawing.Size(851, 285);
            this.dataGridViewModules.TabIndex = 6;
            this.dataGridViewModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModules_CellClick);
            this.dataGridViewModules.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewModules_CellFormatting);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Abreviació";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalhoursDataGridViewTextBoxColumn
            // 
            this.totalhoursDataGridViewTextBoxColumn.DataPropertyName = "total_hours";
            this.totalhoursDataGridViewTextBoxColumn.HeaderText = "Hores ";
            this.totalhoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalhoursDataGridViewTextBoxColumn.Name = "totalhoursDataGridViewTextBoxColumn";
            this.totalhoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalhoursDataGridViewTextBoxColumn.Width = 200;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Num UFs";
            this.unitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitsDataGridViewTextBoxColumn.Width = 200;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Image = global::Libe_Escriptori.Properties.Resources.pencil1;
            this.ColumnEdit.MinimumWidth = 15;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEdit.Width = 40;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Image = global::Libe_Escriptori.Properties.Resources.close__1_;
            this.ColumnDelete.MinimumWidth = 6;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.Width = 40;
            // 
            // bindingSourceModules
            // 
            this.bindingSourceModules.DataSource = typeof(Libe_Escriptori.Models.modules);
            // 
            // buttonExistent
            // 
            this.buttonExistent.BackColor = System.Drawing.Color.White;
            this.buttonExistent.FlatAppearance.BorderSize = 0;
            this.buttonExistent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExistent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonExistent.Location = new System.Drawing.Point(236, 206);
            this.buttonExistent.Name = "buttonExistent";
            this.buttonExistent.Size = new System.Drawing.Size(137, 31);
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
            this.buttonNew.Location = new System.Drawing.Point(80, 206);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(137, 31);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Nou Mòdul";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DataSource = this.bindingSourceDepartments;
            this.comboBoxDepartment.DisplayMember = "name";
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.IntegralHeight = false;
            this.comboBoxDepartment.Location = new System.Drawing.Point(80, 147);
            this.comboBoxDepartment.MaximumSize = new System.Drawing.Size(266, 0);
            this.comboBoxDepartment.MinimumSize = new System.Drawing.Size(266, 0);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(266, 29);
            this.comboBoxDepartment.TabIndex = 3;
            this.comboBoxDepartment.ValueMember = "id";
            this.comboBoxDepartment.SelectedValueChanged += new System.EventHandler(this.comboBoxDepartment_SelectedValueChanged);
            // 
            // bindingSourceDepartments
            // 
            this.bindingSourceDepartments.DataSource = typeof(Libe_Escriptori.Models.departments);
            // 
            // textBoxCoordinator
            // 
            this.textBoxCoordinator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCoordinator.Location = new System.Drawing.Point(462, 145);
            this.textBoxCoordinator.MaximumSize = new System.Drawing.Size(403, 31);
            this.textBoxCoordinator.MinimumSize = new System.Drawing.Size(403, 31);
            this.textBoxCoordinator.Name = "textBoxCoordinator";
            this.textBoxCoordinator.ReadOnly = true;
            this.textBoxCoordinator.Size = new System.Drawing.Size(403, 29);
            this.textBoxCoordinator.TabIndex = 2;
            this.textBoxCoordinator.Text = "Coordinador";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFullName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFullName.Location = new System.Drawing.Point(352, 75);
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
            this.textBoxAbbreviation.Location = new System.Drawing.Point(80, 75);
            this.textBoxAbbreviation.MaximumSize = new System.Drawing.Size(169, 31);
            this.textBoxAbbreviation.MinimumSize = new System.Drawing.Size(169, 31);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(169, 29);
            this.textBoxAbbreviation.TabIndex = 0;
            this.textBoxAbbreviation.Text = " Abreviació";
            this.textBoxAbbreviation.Enter += new System.EventHandler(this.textBoxAbbreviation_Enter);
            this.textBoxAbbreviation.Leave += new System.EventHandler(this.textBoxAbbreviation_Leave);
            // 
            // FormCoursesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelCoursesAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCoursesAdd";
            this.Text = "FormModules";
            this.Load += new System.EventHandler(this.FormCoursesAdd_Load);
            this.panelCoursesAdd.ResumeLayout(false);
            this.panelCoursesAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCoursesAdd;
        private Button buttonNew;
        private ComboBox comboBoxDepartment;
        private TextBox textBoxCoordinator;
        private TextBox textBoxFullName;
        private TextBox textBoxAbbreviation;
        private Button buttonSave;
        private DataGridView dataGridViewModules;
        private Button buttonExistent;
        private Button buttonCancel;
        private BindingSource bindingSourceModules;
        private BindingSource bindingSourceDepartments;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalhoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private DataGridViewImageColumn ColumnEdit;
        private DataGridViewImageColumn ColumnDelete;
    }
}