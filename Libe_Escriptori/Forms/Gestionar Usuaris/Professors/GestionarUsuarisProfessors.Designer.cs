﻿namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    partial class GestionarUsuarisProfessors
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
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSurnames,
            this.ColumnDNI,
            this.ColumnDepartment,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridViewTeachers.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(93, 99);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowTemplate.Height = 25;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(818, 503);
            this.dataGridViewTeachers.TabIndex = 9;
            this.dataGridViewTeachers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewTeachers_CellPainting);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.IntegralHeight = false;
            this.comboBoxFilter.ItemHeight = 15;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBoxFilter.Location = new System.Drawing.Point(790, 48);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(110, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFilter.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(536, 48);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(150, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(251, 22);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "  Búsqueda...";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(93, 49);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(160, 22);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Nom";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurnames
            // 
            this.ColumnSurnames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSurnames.HeaderText = "Cognoms";
            this.ColumnSurnames.Name = "ColumnSurnames";
            // 
            // ColumnDNI
            // 
            this.ColumnDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDNI.HeaderText = "DNI";
            this.ColumnDNI.Name = "ColumnDNI";
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDepartment.HeaderText = "Departament";
            this.ColumnDepartment.Name = "ColumnDepartment";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Width = 21;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 21;
            // 
            // GestionarUsuarisProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisProfessors";
            this.Text = "gestionarUsuarisProfessors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewTeachers;
        private ComboBox comboBoxFilter;
        private TextBox textBoxSearch;
        private Button buttonNew;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSurnames;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnDepartment;
        private DataGridViewTextBoxColumn ColumnEdit;
        private DataGridViewTextBoxColumn ColumnDelete;
    }
}