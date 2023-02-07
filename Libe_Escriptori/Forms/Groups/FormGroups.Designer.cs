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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.headerCicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerAlumnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxFilterGroups = new System.Windows.Forms.ComboBox();
            this.textBoxFilterGroups = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.BackColor = System.Drawing.Color.White;
            this.buttonNewGroup.FlatAppearance.BorderSize = 0;
            this.buttonNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewGroup.Location = new System.Drawing.Point(56, 47);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(90, 35);
            this.buttonNewGroup.TabIndex = 0;
            this.buttonNewGroup.Text = "Nou";
            this.buttonNewGroup.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerCicle,
            this.headerYear,
            this.headerClass,
            this.headerTutor,
            this.headerAlumnes,
            this.headerEdit,
            this.headerDelete});
            this.dataGridView1.Location = new System.Drawing.Point(56, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(882, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // headerCicle
            // 
            this.headerCicle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerCicle.HeaderText = "Cicle";
            this.headerCicle.Name = "headerCicle";
            this.headerCicle.ReadOnly = true;
            // 
            // headerYear
            // 
            this.headerYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerYear.HeaderText = "Any";
            this.headerYear.Name = "headerYear";
            this.headerYear.ReadOnly = true;
            // 
            // headerClass
            // 
            this.headerClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerClass.HeaderText = "Classe";
            this.headerClass.Name = "headerClass";
            this.headerClass.ReadOnly = true;
            // 
            // headerTutor
            // 
            this.headerTutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerTutor.HeaderText = "Tutor";
            this.headerTutor.Name = "headerTutor";
            this.headerTutor.ReadOnly = true;
            // 
            // headerAlumnes
            // 
            this.headerAlumnes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerAlumnes.HeaderText = "Aula";
            this.headerAlumnes.Name = "headerAlumnes";
            this.headerAlumnes.ReadOnly = true;
            // 
            // headerEdit
            // 
            this.headerEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerEdit.HeaderText = "";
            this.headerEdit.Name = "headerEdit";
            // 
            // headerDelete
            // 
            this.headerDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerDelete.HeaderText = "";
            this.headerDelete.Name = "headerDelete";
            this.headerDelete.ReadOnly = true;
            // 
            // comboBoxFilterGroups
            // 
            this.comboBoxFilterGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterGroups.FormattingEnabled = true;
            this.comboBoxFilterGroups.Items.AddRange(new object[] {
            "Cicle",
            "Any",
            "Classe",
            "Tutor",
            "Alumnes",
            "Aula"});
            this.comboBoxFilterGroups.Location = new System.Drawing.Point(817, 57);
            this.comboBoxFilterGroups.Name = "comboBoxFilterGroups";
            this.comboBoxFilterGroups.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFilterGroups.TabIndex = 2;
            // 
            // textBoxFilterGroups
            // 
            this.textBoxFilterGroups.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxFilterGroups.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterGroups.Location = new System.Drawing.Point(499, 57);
            this.textBoxFilterGroups.Name = "textBoxFilterGroups";
            this.textBoxFilterGroups.Size = new System.Drawing.Size(318, 23);
            this.textBoxFilterGroups.TabIndex = 3;
            this.textBoxFilterGroups.Text = "Búsqueda...";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.textBoxFilterGroups);
            this.Controls.Add(this.comboBoxFilterGroups);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonNewGroup);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNewGroup;
        private DataGridView dataGridView1;
        private ComboBox comboBoxFilterGroups;
        private TextBox textBoxFilterGroups;
        private DataGridViewTextBoxColumn headerCicle;
        private DataGridViewTextBoxColumn headerYear;
        private DataGridViewTextBoxColumn headerClass;
        private DataGridViewTextBoxColumn headerTutor;
        private DataGridViewTextBoxColumn headerAlumnes;
        private DataGridViewTextBoxColumn headerEdit;
        private DataGridViewTextBoxColumn headerDelete;
    }
}