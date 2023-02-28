namespace Libe_Escriptori.Forms.Gestionar_Usuaris
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
            this.panelGestionarUsuarisProfessors = new System.Windows.Forms.Panel();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCognoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxFiltres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGestionarUsuarisProfessors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestionarUsuarisProfessors
            // 
            this.panelGestionarUsuarisProfessors.Controls.Add(this.textBoxFiltres);
            this.panelGestionarUsuarisProfessors.Controls.Add(this.label2);
            this.panelGestionarUsuarisProfessors.Controls.Add(this.dataGridViewTeachers);
            this.panelGestionarUsuarisProfessors.Controls.Add(this.buttonNew);
            this.panelGestionarUsuarisProfessors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionarUsuarisProfessors.Location = new System.Drawing.Point(0, 0);
            this.panelGestionarUsuarisProfessors.Name = "panelGestionarUsuarisProfessors";
            this.panelGestionarUsuarisProfessors.Size = new System.Drawing.Size(1005, 650);
            this.panelGestionarUsuarisProfessors.TabIndex = 0;
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNom,
            this.ColumnCognoms,
            this.ColumnDNI,
            this.ColumnDepartament,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridViewTeachers.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(93, 99);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.RowTemplate.Height = 25;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(818, 503);
            this.dataGridViewTeachers.TabIndex = 13;
            this.dataGridViewTeachers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewTeachers_CellPainting);
            // 
            // ColumnNom
            // 
            this.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            // 
            // ColumnCognoms
            // 
            this.ColumnCognoms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCognoms.HeaderText = "Cognoms";
            this.ColumnCognoms.Name = "ColumnCognoms";
            // 
            // ColumnDNI
            // 
            this.ColumnDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDNI.HeaderText = "DNI";
            this.ColumnDNI.Name = "ColumnDNI";
            // 
            // ColumnDepartament
            // 
            this.ColumnDepartament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDepartament.HeaderText = "Departament";
            this.ColumnDepartament.Name = "ColumnDepartament";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Width = 21;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 21;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(93, 43);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(137, 31);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click_1);
            // 
            // textBoxFiltres
            // 
            this.textBoxFiltres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxFiltres.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFiltres.Location = new System.Drawing.Point(461, 43);
            this.textBoxFiltres.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBoxFiltres.MinimumSize = new System.Drawing.Size(450, 31);
            this.textBoxFiltres.Name = "textBoxFiltres";
            this.textBoxFiltres.Size = new System.Drawing.Size(450, 31);
            this.textBoxFiltres.TabIndex = 15;
            this.textBoxFiltres.Text = " Introdueix dades clau del professor ex. DNI, Cognom...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(461, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ex. Joan, Guardiola, 43129473F";
            // 
            // GestionarUsuarisProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelGestionarUsuarisProfessors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisProfessors";
            this.Text = "gestionarUsuarisProfessors";
            this.panelGestionarUsuarisProfessors.ResumeLayout(false);
            this.panelGestionarUsuarisProfessors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGestionarUsuarisProfessors;
        private DataGridView dataGridViewTeachers;
        private Button buttonNew;
        private DataGridViewTextBoxColumn ColumnNom;
        private DataGridViewTextBoxColumn ColumnCognoms;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnDepartament;
        private DataGridViewButtonColumn ColumnEdit;
        private DataGridViewButtonColumn ColumnDelete;
        private TextBox textBoxFiltres;
        private Label label2;
    }
}