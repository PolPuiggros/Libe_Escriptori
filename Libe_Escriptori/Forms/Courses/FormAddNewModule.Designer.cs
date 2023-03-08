using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Courses
{
    partial class FormAddNewModule
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
            this.panelNewModule = new System.Windows.Forms.Panel();
            this.labelNewModule = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUF = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.bindingSourceUnits = new System.Windows.Forms.BindingSource(this.components);
            this.abreviationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNewModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNewModule
            // 
            this.panelNewModule.Controls.Add(this.labelNewModule);
            this.panelNewModule.Controls.Add(this.buttonCancel);
            this.panelNewModule.Controls.Add(this.buttonSave);
            this.panelNewModule.Controls.Add(this.labelUF);
            this.panelNewModule.Controls.Add(this.dataGridView1);
            this.panelNewModule.Controls.Add(this.textBoxHours);
            this.panelNewModule.Controls.Add(this.textBoxName);
            this.panelNewModule.Controls.Add(this.textBoxAbbreviation);
            this.panelNewModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewModule.Location = new System.Drawing.Point(0, 0);
            this.panelNewModule.Name = "panelNewModule";
            this.panelNewModule.Size = new System.Drawing.Size(1005, 650);
            this.panelNewModule.TabIndex = 0;
            // 
            // labelNewModule
            // 
            this.labelNewModule.AutoSize = true;
            this.labelNewModule.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.labelNewModule.Location = new System.Drawing.Point(82, 46);
            this.labelNewModule.Name = "labelNewModule";
            this.labelNewModule.Size = new System.Drawing.Size(153, 37);
            this.labelNewModule.TabIndex = 10;
            this.labelNewModule.Text = "Nou Modul";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.buttonCancel.Location = new System.Drawing.Point(291, 478);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 35);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(470, 478);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 35);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.labelUF.Location = new System.Drawing.Point(82, 149);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(60, 37);
            this.labelUF.TabIndex = 4;
            this.labelUF.Text = "UFs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abreviationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.totalhoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceUnits;
            this.dataGridView1.Location = new System.Drawing.Point(82, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(710, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxHours.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHours.Location = new System.Drawing.Point(245, 91);
            this.textBoxHours.MaximumSize = new System.Drawing.Size(159, 31);
            this.textBoxHours.MinimumSize = new System.Drawing.Size(159, 31);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(159, 29);
            this.textBoxHours.TabIndex = 2;
            this.textBoxHours.Text = " Hores";
            this.textBoxHours.Enter += new System.EventHandler(this.textBoxHours_Enter);
            this.textBoxHours.Leave += new System.EventHandler(this.textBoxHours_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxName.Location = new System.Drawing.Point(409, 91);
            this.textBoxName.MaximumSize = new System.Drawing.Size(384, 31);
            this.textBoxName.MinimumSize = new System.Drawing.Size(384, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(384, 29);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = " Nom complert";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxAbbreviation.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAbbreviation.Location = new System.Drawing.Point(82, 91);
            this.textBoxAbbreviation.MaximumSize = new System.Drawing.Size(154, 31);
            this.textBoxAbbreviation.MinimumSize = new System.Drawing.Size(154, 31);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(154, 29);
            this.textBoxAbbreviation.TabIndex = 0;
            this.textBoxAbbreviation.Text = " Abreviació";
            this.textBoxAbbreviation.Enter += new System.EventHandler(this.textBoxAbbreviation_Enter);
            this.textBoxAbbreviation.Leave += new System.EventHandler(this.textBoxAbbreviation_Leave);
            // 
            // bindingSourceUnits
            // 
            this.bindingSourceUnits.DataSource = typeof(Libe_Escriptori.Models.units);
            // 
            // abreviationDataGridViewTextBoxColumn
            // 
            this.abreviationDataGridViewTextBoxColumn.DataPropertyName = "abreviation";
            this.abreviationDataGridViewTextBoxColumn.HeaderText = "abreviation";
            this.abreviationDataGridViewTextBoxColumn.Name = "abreviationDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // totalhoursDataGridViewTextBoxColumn
            // 
            this.totalhoursDataGridViewTextBoxColumn.DataPropertyName = "total_hours";
            this.totalhoursDataGridViewTextBoxColumn.HeaderText = "total_hours";
            this.totalhoursDataGridViewTextBoxColumn.Name = "totalhoursDataGridViewTextBoxColumn";
            // 
            // FormAddNewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelNewModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddNewModule";
            this.Text = "FormAddModule";
            this.Load += new System.EventHandler(this.FormAddNewModule_Load);
            this.panelNewModule.ResumeLayout(false);
            this.panelNewModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNewModule;
        private Label labelUF;
        private DataGridView dataGridView1;
        private TextBox textBoxHours;
        private TextBox textBoxName;
        private TextBox textBoxAbbreviation;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelNewModule;
        private BindingSource bindingSourceUnits;
        private DataGridViewTextBoxColumn abreviationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalhoursDataGridViewTextBoxColumn;
    }
}