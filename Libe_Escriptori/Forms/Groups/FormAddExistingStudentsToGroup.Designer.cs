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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewExistingStudents = new System.Windows.Forms.DataGridView();
            this.buttonSaveStudentsGroup = new System.Windows.Forms.Button();
            this.headerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerSurnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExistingStudents
            // 
            this.dataGridViewExistingStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExistingStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExistingStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExistingStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerName,
            this.headerSurnames,
            this.headerGroup});
            this.dataGridViewExistingStudents.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewExistingStudents.Name = "dataGridViewExistingStudents";
            this.dataGridViewExistingStudents.RowTemplate.Height = 25;
            this.dataGridViewExistingStudents.Size = new System.Drawing.Size(460, 349);
            this.dataGridViewExistingStudents.TabIndex = 0;
            // 
            // buttonSaveStudentsGroup
            // 
            this.buttonSaveStudentsGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSaveStudentsGroup.FlatAppearance.BorderSize = 0;
            this.buttonSaveStudentsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveStudentsGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveStudentsGroup.ForeColor = System.Drawing.Color.White;
            this.buttonSaveStudentsGroup.Location = new System.Drawing.Point(188, 408);
            this.buttonSaveStudentsGroup.Name = "buttonSaveStudentsGroup";
            this.buttonSaveStudentsGroup.Size = new System.Drawing.Size(94, 41);
            this.buttonSaveStudentsGroup.TabIndex = 1;
            this.buttonSaveStudentsGroup.Text = "Guardar";
            this.buttonSaveStudentsGroup.UseVisualStyleBackColor = false;
            // 
            // headerName
            // 
            this.headerName.HeaderText = "Nom";
            this.headerName.Name = "headerName";
            this.headerName.ReadOnly = true;
            // 
            // headerSurnames
            // 
            this.headerSurnames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerSurnames.HeaderText = "Cognoms";
            this.headerSurnames.Name = "headerSurnames";
            this.headerSurnames.ReadOnly = true;
            // 
            // headerGroup
            // 
            this.headerGroup.HeaderText = "DAM1A";
            this.headerGroup.Name = "headerGroup";
            this.headerGroup.ReadOnly = true;
            this.headerGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormAddExistingStudentsToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonSaveStudentsGroup);
            this.Controls.Add(this.dataGridViewExistingStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddExistingStudentsToGroup";
            this.Text = "FormAddExistingStudentsToGroup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewExistingStudents;
        private Button buttonSaveStudentsGroup;
        private DataGridViewTextBoxColumn headerName;
        private DataGridViewTextBoxColumn headerSurnames;
        private DataGridViewCheckBoxColumn headerGroup;
    }
}