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
            this.panelCoursesAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModules)).BeginInit();
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
            this.panelCoursesAdd.Size = new System.Drawing.Size(1005, 650);
            this.panelCoursesAdd.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(375, 553);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 41);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(547, 553);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 41);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // dataGridViewModules
            // 
            this.dataGridViewModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModules.Location = new System.Drawing.Point(80, 285);
            this.dataGridViewModules.Name = "dataGridViewModules";
            this.dataGridViewModules.RowTemplate.Height = 25;
            this.dataGridViewModules.Size = new System.Drawing.Size(851, 238);
            this.dataGridViewModules.TabIndex = 6;
            // 
            // buttonExistent
            // 
            this.buttonExistent.BackColor = System.Drawing.Color.White;
            this.buttonExistent.FlatAppearance.BorderSize = 0;
            this.buttonExistent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExistent.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExistent.Location = new System.Drawing.Point(241, 215);
            this.buttonExistent.Name = "buttonExistent";
            this.buttonExistent.Size = new System.Drawing.Size(184, 41);
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
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(80, 215);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(131, 41);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Nou Mòdul";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Departament"});
            this.comboBox1.Location = new System.Drawing.Point(80, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(462, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(469, 29);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Coordinador";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFullName.Location = new System.Drawing.Point(352, 75);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(579, 29);
            this.textBoxFullName.TabIndex = 1;
            this.textBoxFullName.Text = "Nom Complert del curs";
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAbbreviation.Location = new System.Drawing.Point(80, 75);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(197, 29);
            this.textBoxAbbreviation.TabIndex = 0;
            this.textBoxAbbreviation.Text = "Abreviació";
            // 
            // FormCoursesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelCoursesAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCoursesAdd";
            this.Text = "FormModules";
            this.panelCoursesAdd.ResumeLayout(false);
            this.panelCoursesAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModules)).EndInit();
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
    }
}