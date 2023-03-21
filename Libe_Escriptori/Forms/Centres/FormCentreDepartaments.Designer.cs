using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    partial class FormCentreDepartaments
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomDepartament = new System.Windows.Forms.TextBox();
            this.comboBoxCoordinador = new System.Windows.Forms.ComboBox();
            this.bindingSourceCoordinator = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardarDepartament = new System.Windows.Forms.Button();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.bindingSourceDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorinchargeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoordinator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(397, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departaments";
            // 
            // textBoxNomDepartament
            // 
            this.textBoxNomDepartament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxNomDepartament.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNomDepartament.Location = new System.Drawing.Point(100, 118);
            this.textBoxNomDepartament.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBoxNomDepartament.MinimumSize = new System.Drawing.Size(711, 31);
            this.textBoxNomDepartament.Name = "textBoxNomDepartament";
            this.textBoxNomDepartament.Size = new System.Drawing.Size(829, 29);
            this.textBoxNomDepartament.TabIndex = 2;
            this.textBoxNomDepartament.Text = " Nom del departament";
            this.textBoxNomDepartament.Enter += new System.EventHandler(this.textBoxNomDepartament_Enter);
            this.textBoxNomDepartament.Leave += new System.EventHandler(this.textBoxNomDepartament_Leave);
            // 
            // comboBoxCoordinador
            // 
            this.comboBoxCoordinador.DataSource = this.bindingSourceCoordinator;
            this.comboBoxCoordinador.DisplayMember = "name";
            this.comboBoxCoordinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoordinador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.comboBoxCoordinador.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxCoordinador.FormattingEnabled = true;
            this.comboBoxCoordinador.Location = new System.Drawing.Point(100, 178);
            this.comboBoxCoordinador.MaximumSize = new System.Drawing.Size(389, 0);
            this.comboBoxCoordinador.MinimumSize = new System.Drawing.Size(389, 0);
            this.comboBoxCoordinador.Name = "comboBoxCoordinador";
            this.comboBoxCoordinador.Size = new System.Drawing.Size(389, 29);
            this.comboBoxCoordinador.TabIndex = 3;
            this.comboBoxCoordinador.ValueMember = "id";
            // 
            // bindingSourceCoordinator
            // 
            this.bindingSourceCoordinator.DataSource = typeof(Libe_Escriptori.Models.profesors);
            // 
            // buttonGuardarDepartament
            // 
            this.buttonGuardarDepartament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonGuardarDepartament.FlatAppearance.BorderSize = 0;
            this.buttonGuardarDepartament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarDepartament.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonGuardarDepartament.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarDepartament.Location = new System.Drawing.Point(505, 178);
            this.buttonGuardarDepartament.Name = "buttonGuardarDepartament";
            this.buttonGuardarDepartament.Size = new System.Drawing.Size(137, 29);
            this.buttonGuardarDepartament.TabIndex = 7;
            this.buttonGuardarDepartament.Text = "Afegir dept.";
            this.buttonGuardarDepartament.UseVisualStyleBackColor = false;
            this.buttonGuardarDepartament.Click += new System.EventHandler(this.buttonGuardarDepartament_Click);
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.AllowUserToDeleteRows = false;
            this.dataGridViewDepartments.AllowUserToResizeRows = false;
            this.dataGridViewDepartments.AutoGenerateColumns = false;
            this.dataGridViewDepartments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.profesorinchargeidDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewDepartments.DataSource = this.bindingSourceDepartments;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(100, 255);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.ReadOnly = true;
            this.dataGridViewDepartments.RowHeadersVisible = false;
            this.dataGridViewDepartments.RowTemplate.Height = 30;
            this.dataGridViewDepartments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(829, 292);
            this.dataGridViewDepartments.TabIndex = 8;
            this.dataGridViewDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartments_CellClick);
            this.dataGridViewDepartments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDepartments_CellFormatting);
            // 
            // bindingSourceDepartments
            // 
            this.bindingSourceDepartments.DataSource = typeof(Libe_Escriptori.Models.departments);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorinchargeidDataGridViewTextBoxColumn
            // 
            this.profesorinchargeidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.profesorinchargeidDataGridViewTextBoxColumn.DataPropertyName = "profesor_in_charge_id";
            this.profesorinchargeidDataGridViewTextBoxColumn.HeaderText = "Coordinador";
            this.profesorinchargeidDataGridViewTextBoxColumn.Name = "profesorinchargeidDataGridViewTextBoxColumn";
            this.profesorinchargeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.profesorinchargeidDataGridViewTextBoxColumn.Width = 408;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Libe_Escriptori.Properties.Resources.pencil__1_;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 40;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Libe_Escriptori.Properties.Resources.close__1_;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 40;
            // 
            // FormCentreDepartaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.buttonGuardarDepartament);
            this.Controls.Add(this.comboBoxCoordinador);
            this.Controls.Add(this.textBoxNomDepartament);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCentreDepartaments";
            this.Text = "FormCentreDepartaments";
            this.Load += new System.EventHandler(this.FormCentreDepartaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoordinator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNomDepartament;
        private ComboBox comboBoxCoordinador;
        private Button buttonGuardarDepartament;
        private DataGridView dataGridViewDepartments;
        private BindingSource bindingSourceDepartments;
        private BindingSource bindingSourceCoordinator;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorinchargeidDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}