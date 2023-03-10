using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.panelGestionarUsuaris = new System.Windows.Forms.Panel();
            this.textBoxFiltres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoregisterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasrepeatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourceStudents = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelGestionarUsuaris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestionarUsuaris
            // 
            this.panelGestionarUsuaris.Controls.Add(this.textBoxFiltres);
            this.panelGestionarUsuaris.Controls.Add(this.label2);
            this.panelGestionarUsuaris.Controls.Add(this.dataGridView1);
            this.panelGestionarUsuaris.Controls.Add(this.comboBoxFilter);
            this.panelGestionarUsuaris.Controls.Add(this.buttonNew);
            this.panelGestionarUsuaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionarUsuaris.Location = new System.Drawing.Point(0, 0);
            this.panelGestionarUsuaris.Name = "panelGestionarUsuaris";
            this.panelGestionarUsuaris.Size = new System.Drawing.Size(1005, 650);
            this.panelGestionarUsuaris.TabIndex = 6;
            // 
            // textBoxFiltres
            // 
            this.textBoxFiltres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltres.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFiltres.Location = new System.Drawing.Point(313, 49);
            this.textBoxFiltres.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBoxFiltres.MinimumSize = new System.Drawing.Size(450, 31);
            this.textBoxFiltres.Name = "textBoxFiltres";
            this.textBoxFiltres.Size = new System.Drawing.Size(450, 27);
            this.textBoxFiltres.TabIndex = 13;
            this.textBoxFiltres.Text = " Introdueix dades clau de l\'usuari ex. DNI, Cognom...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(313, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ex. Marcel, Garcia, 43129473F";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.surname2DataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.email,
            this.phonenumberDataGridViewTextBoxColumn,
            this.autoregisterDataGridViewCheckBoxColumn,
            this.hasrepeatedDataGridViewCheckBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.bindingSourceStudents;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(91, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 474);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "1r COGNOM";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // surname2DataGridViewTextBoxColumn
            // 
            this.surname2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname2DataGridViewTextBoxColumn.DataPropertyName = "surname2";
            this.surname2DataGridViewTextBoxColumn.HeaderText = "2n COGNOM";
            this.surname2DataGridViewTextBoxColumn.Name = "surname2DataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // autoregisterDataGridViewCheckBoxColumn
            // 
            this.autoregisterDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoregisterDataGridViewCheckBoxColumn.DataPropertyName = "autoregister";
            this.autoregisterDataGridViewCheckBoxColumn.HeaderText = "AUTOREGISTRE";
            this.autoregisterDataGridViewCheckBoxColumn.Name = "autoregisterDataGridViewCheckBoxColumn";
            // 
            // hasrepeatedDataGridViewCheckBoxColumn
            // 
            this.hasrepeatedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hasrepeatedDataGridViewCheckBoxColumn.DataPropertyName = "has_repeated";
            this.hasrepeatedDataGridViewCheckBoxColumn.HeaderText = "REPETIDOR";
            this.hasrepeatedDataGridViewCheckBoxColumn.Name = "hasrepeatedDataGridViewCheckBoxColumn";
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
            // bindingSourceStudents
            // 
            this.bindingSourceStudents.DataSource = typeof(Libe_Escriptori.Models.students);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.IntegralHeight = false;
            this.comboBoxFilter.ItemHeight = 21;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "DAM",
            "DAW",
            "SMIX",
            "..."});
            this.comboBoxFilter.Location = new System.Drawing.Point(777, 51);
            this.comboBoxFilter.MaximumSize = new System.Drawing.Size(150, 0);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(132, 29);
            this.comboBoxFilter.TabIndex = 8;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.White;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonNew.Location = new System.Drawing.Point(91, 49);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(125, 31);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Nou";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // GestionarUsuarisAlumnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelGestionarUsuaris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisAlumnes";
            this.Text = "GestionarUsuarisAlumnes";
            this.Load += new System.EventHandler(this.GestionarUsuarisAlumnes_Load);
            this.panelGestionarUsuaris.ResumeLayout(false);
            this.panelGestionarUsuaris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGestionarUsuaris;
        private DataGridView dataGridView1;
        private ComboBox comboBoxFilter;
        private Button buttonNew;
        private Label label2;
        private TextBox textBoxFiltres;

        private BindingSource bindingSourceStudents;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surname2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn autoregisterDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn hasrepeatedDataGridViewCheckBoxColumn;

        private DataGridViewButtonColumn ColumnEdit;
        private DataGridViewButtonColumn ColumnDelete;
    }
}