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
            this.panelGestionarUsuaris = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCognoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelFilterCourse = new System.Windows.Forms.Label();
            this.textBoxFilterCourse = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelGestionarUsuaris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestionarUsuaris
            // 
            this.panelGestionarUsuaris.Controls.Add(this.dataGridView1);
            this.panelGestionarUsuaris.Controls.Add(this.labelFilterCourse);
            this.panelGestionarUsuaris.Controls.Add(this.textBoxFilterCourse);
            this.panelGestionarUsuaris.Controls.Add(this.comboBoxFilter);
            this.panelGestionarUsuaris.Controls.Add(this.textBoxSearch);
            this.panelGestionarUsuaris.Controls.Add(this.buttonNew);
            this.panelGestionarUsuaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionarUsuaris.Location = new System.Drawing.Point(0, 0);
            this.panelGestionarUsuaris.Name = "panelGestionarUsuaris";
            this.panelGestionarUsuaris.Size = new System.Drawing.Size(1005, 650);
            this.panelGestionarUsuaris.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNom,
            this.ColumnCognoms,
            this.ColumnDNI,
            this.ColumnCurs,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(92, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(818, 503);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
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
            // ColumnCurs
            // 
            this.ColumnCurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCurs.HeaderText = "Curs";
            this.ColumnCurs.Name = "ColumnCurs";
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
            // labelFilterCourse
            // 
            this.labelFilterCourse.AutoSize = true;
            this.labelFilterCourse.BackColor = System.Drawing.Color.White;
            this.labelFilterCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFilterCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilterCourse.ForeColor = System.Drawing.Color.Black;
            this.labelFilterCourse.Location = new System.Drawing.Point(860, 58);
            this.labelFilterCourse.MaximumSize = new System.Drawing.Size(50, 31);
            this.labelFilterCourse.MinimumSize = new System.Drawing.Size(50, 31);
            this.labelFilterCourse.Name = "labelFilterCourse";
            this.labelFilterCourse.Padding = new System.Windows.Forms.Padding(2);
            this.labelFilterCourse.Size = new System.Drawing.Size(50, 31);
            this.labelFilterCourse.TabIndex = 10;
            this.labelFilterCourse.Text = "CURS";
            // 
            // textBoxFilterCourse
            // 
            this.textBoxFilterCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilterCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFilterCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxFilterCourse.Location = new System.Drawing.Point(688, 58);
            this.textBoxFilterCourse.MaximumSize = new System.Drawing.Size(166, 31);
            this.textBoxFilterCourse.MinimumSize = new System.Drawing.Size(166, 31);
            this.textBoxFilterCourse.Name = "textBoxFilterCourse";
            this.textBoxFilterCourse.Size = new System.Drawing.Size(166, 31);
            this.textBoxFilterCourse.TabIndex = 3;
            this.textBoxFilterCourse.Text = "  Búsqueda...";
            this.textBoxFilterCourse.Enter += new System.EventHandler(this.textBoxFilterCourse_Enter);
            this.textBoxFilterCourse.Leave += new System.EventHandler(this.textBoxFilterCourse_Leave);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.IntegralHeight = false;
            this.comboBoxFilter.ItemHeight = 21;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBoxFilter.Location = new System.Drawing.Point(546, 60);
            this.comboBoxFilter.MaximumSize = new System.Drawing.Size(121, 0);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 29);
            this.comboBoxFilter.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(289, 58);
            this.textBoxSearch.MaximumSize = new System.Drawing.Size(251, 31);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(251, 31);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(251, 31);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "  Búsqueda...";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(92, 58);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(125, 31);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click_1);
            // 
            // GestionarUsuarisAlumnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelGestionarUsuaris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisAlumnes";
            this.Text = "GestionarUsuarisAlumnes";
            this.panelGestionarUsuaris.ResumeLayout(false);
            this.panelGestionarUsuaris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGestionarUsuaris;
        private DataGridView dataGridView1;
        private Label labelFilterCourse;
        private TextBox textBoxFilterCourse;
        private ComboBox comboBoxFilter;
        private TextBox textBoxSearch;
        private Button buttonNew;
        private DataGridViewTextBoxColumn ColumnNom;
        private DataGridViewTextBoxColumn ColumnCognoms;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnCurs;
        private DataGridViewButtonColumn ColumnEdit;
        private DataGridViewButtonColumn ColumnDelete;
    }
}