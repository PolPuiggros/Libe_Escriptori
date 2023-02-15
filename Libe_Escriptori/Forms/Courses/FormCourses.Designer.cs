﻿namespace Libe_Escriptori.Forms.Courses
{
    partial class FormCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.abreviacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCourses
            // 
            this.panelCourses.Controls.Add(this.dataGridViewCourses);
            this.panelCourses.Controls.Add(this.buttonNew);
            this.panelCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourses.Location = new System.Drawing.Point(0, 0);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(1005, 650);
            this.panelCourses.TabIndex = 0;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToOrderColumns = true;
            this.dataGridViewCourses.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abreviacio,
            this.nom,

            this.departament});
            this.dataGridViewCourses.Location = new System.Drawing.Point(62, 127);

            this.departament,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridViewCourses.Location = new System.Drawing.Point(64, 116);

            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.RowHeadersVisible = false;
            this.dataGridViewCourses.RowTemplate.Height = 25;
            this.dataGridViewCourses.Size = new System.Drawing.Size(880, 469);

            this.dataGridViewCourses.TabIndex = 5;
            // 
            // abreviacio
            // 
            this.abreviacio.DataPropertyName = "abreviacio";
            this.abreviacio.HeaderText = "Abreviació Curs";
            this.abreviacio.Name = "abreviacio";
            this.abreviacio.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // departament
            // 
            this.departament.DataPropertyName = "departament";
            this.departament.HeaderText = "Departament";
            this.departament.Name = "departament";
            this.departament.ReadOnly = true;

            this.dataGridViewCourses.TabIndex = 3;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewCourses.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewCourses_CellPainting);

            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(62, 54);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(108, 42);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 

            // FormCourses

            // abreviacio
            // 
            this.abreviacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abreviacio.DataPropertyName = "abreviacio";
            this.abreviacio.HeaderText = "Abreviació Curs";
            this.abreviacio.Name = "abreviacio";
            this.abreviacio.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // departament
            // 
            this.departament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departament.DataPropertyName = "departament";
            this.departament.HeaderText = "Departament";
            this.departament.Name = "departament";
            this.departament.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEdit.UseColumnTextForButtonValue = true;
            this.ColumnEdit.Width = 24;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Width = 21;
            // 
            // FormCourses1

            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCourses";
            this.Text = "FormCourses";
            this.panelCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCourses;
        private DataGridView dataGridViewCourses;
        private DataGridViewTextBoxColumn abreviacio;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn departament;

        private Button buttonNew;

        private DataGridViewButtonColumn ColumnEdit;
        private DataGridViewButtonColumn ColumnDelete;

    }
}