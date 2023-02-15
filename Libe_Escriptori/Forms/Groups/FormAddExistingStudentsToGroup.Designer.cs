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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewExistingStudents = new System.Windows.Forms.DataGridView();
            this.headerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerSurnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonSaveStudentsGroup = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExistingStudents
            // 
            this.dataGridViewExistingStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExistingStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExistingStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExistingStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerName,
            this.headerSurnames,
            this.headerGroup});
            this.dataGridViewExistingStudents.Location = new System.Drawing.Point(27, 58);
            this.dataGridViewExistingStudents.Name = "dataGridViewExistingStudents";
            this.dataGridViewExistingStudents.RowHeadersVisible = false;
            this.dataGridViewExistingStudents.RowTemplate.Height = 25;
            this.dataGridViewExistingStudents.Size = new System.Drawing.Size(612, 349);
            this.dataGridViewExistingStudents.TabIndex = 0;
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
            // buttonSaveStudentsGroup
            // 
            this.buttonSaveStudentsGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSaveStudentsGroup.FlatAppearance.BorderSize = 0;
            this.buttonSaveStudentsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveStudentsGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveStudentsGroup.ForeColor = System.Drawing.Color.White;
            this.buttonSaveStudentsGroup.Location = new System.Drawing.Point(282, 426);
            this.buttonSaveStudentsGroup.Name = "buttonSaveStudentsGroup";
            this.buttonSaveStudentsGroup.Size = new System.Drawing.Size(94, 41);
            this.buttonSaveStudentsGroup.TabIndex = 1;
            this.buttonSaveStudentsGroup.Text = "Guardar";
            this.buttonSaveStudentsGroup.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::Libe_Escriptori.Properties.Resources.close1;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(639, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(18, 18);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 22);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // FormAddExistingStudentsToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(664, 495);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSaveStudentsGroup);
            this.Controls.Add(this.dataGridViewExistingStudents);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Button buttonClose;
        private Panel panel1;
    }
}