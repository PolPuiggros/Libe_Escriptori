namespace Libe_Escriptori.Forms.Courses
{
    partial class FormCourses1
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
            this.panelCourses = new System.Windows.Forms.Panel();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.abreviacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNew = new System.Windows.Forms.Button();
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
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abreviacio,
            this.nom,
            this.departament});
            this.dataGridViewCourses.Location = new System.Drawing.Point(64, 116);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.RowTemplate.Height = 25;
            this.dataGridViewCourses.Size = new System.Drawing.Size(880, 469);
            this.dataGridViewCourses.TabIndex = 3;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(64, 43);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(108, 42);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCourses1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCourses1";
            this.Text = "FormCourses";
            this.panelCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCourses;
        private Button buttonNew;
        private DataGridView dataGridViewCourses;
        private DataGridViewTextBoxColumn abreviacio;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn departament;
    }
}