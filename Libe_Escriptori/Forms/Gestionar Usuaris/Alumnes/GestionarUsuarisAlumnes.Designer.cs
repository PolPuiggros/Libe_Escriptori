namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    partial class GestionarUsuarisAlumnes
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxFilterCourse = new System.Windows.Forms.TextBox();
            this.labelFilterCourse = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(289, 49);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(150, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(251, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "  Búsqueda...";
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
            this.comboBoxFilter.Location = new System.Drawing.Point(543, 49);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(110, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFilter.TabIndex = 2;
            // 
            // textBoxFilterCourse
            // 
            this.textBoxFilterCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFilterCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFilterCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxFilterCourse.Location = new System.Drawing.Point(706, 49);
            this.textBoxFilterCourse.MinimumSize = new System.Drawing.Size(166, 22);
            this.textBoxFilterCourse.Name = "textBoxFilterCourse";
            this.textBoxFilterCourse.Size = new System.Drawing.Size(166, 22);
            this.textBoxFilterCourse.TabIndex = 3;
            this.textBoxFilterCourse.Text = "  Búsqueda...";
            // 
            // labelFilterCourse
            // 
            this.labelFilterCourse.AutoSize = true;
            this.labelFilterCourse.BackColor = System.Drawing.Color.White;
            this.labelFilterCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFilterCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilterCourse.ForeColor = System.Drawing.Color.Black;
            this.labelFilterCourse.Location = new System.Drawing.Point(870, 49);
            this.labelFilterCourse.Name = "labelFilterCourse";
            this.labelFilterCourse.Padding = new System.Windows.Forms.Padding(2);
            this.labelFilterCourse.Size = new System.Drawing.Size(44, 21);
            this.labelFilterCourse.TabIndex = 4;
            this.labelFilterCourse.Text = "CURS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSurnames,
            this.ColumnDNI,
            this.ColumnCourse,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(93, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(818, 503);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nom";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurnames
            // 
            this.ColumnSurnames.HeaderText = "Cognoms";
            this.ColumnSurnames.Name = "ColumnSurnames";
            // 
            // ColumnDNI
            // 
            this.ColumnDNI.HeaderText = "DNI";
            this.ColumnDNI.Name = "ColumnDNI";
            // 
            // ColumnCourse
            // 
            this.ColumnCourse.HeaderText = "Curs";
            this.ColumnCourse.Name = "ColumnCourse";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            // 
            // GestionarUsuarisAlumnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFilterCourse);
            this.Controls.Add(this.textBoxFilterCourse);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisAlumnes";
            this.Text = "GestionarUsuarisAlumnes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNew;
        private TextBox textBoxSearch;
        private ComboBox comboBoxFilter;
        private TextBox textBoxFilterCourse;
        private Label labelFilterCourse;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSurnames;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnCourse;
        private DataGridViewTextBoxColumn ColumnEdit;
        private DataGridViewTextBoxColumn ColumnDelete;
    }
}