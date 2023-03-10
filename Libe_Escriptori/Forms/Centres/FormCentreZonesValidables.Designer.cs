using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    partial class FormCentreZonesValidables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZoneName = new System.Windows.Forms.TextBox();
            this.textBoxZoneCoordinates = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuardarZona = new System.Windows.Forms.Button();
            this.buttonAfegirAules = new System.Windows.Forms.Button();
            this.panelZonesValidables = new System.Windows.Forms.Panel();
            this.Guardar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSourceZonesValidables = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelZonesValidables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceZonesValidables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(399, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zones Validables";
            // 
            // textBoxZoneName
            // 
            this.textBoxZoneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxZoneName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxZoneName.Location = new System.Drawing.Point(83, 99);
            this.textBoxZoneName.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBoxZoneName.MinimumSize = new System.Drawing.Size(829, 31);
            this.textBoxZoneName.Name = "textBoxZoneName";
            this.textBoxZoneName.Size = new System.Drawing.Size(829, 29);
            this.textBoxZoneName.TabIndex = 1;
            this.textBoxZoneName.Text = " Nom de la zona validable";
            this.textBoxZoneName.Enter += new System.EventHandler(this.textBoxZoneName_Enter);
            this.textBoxZoneName.Leave += new System.EventHandler(this.textBoxZoneName_Leave);
            // 
            // textBoxZoneCoordinates
            // 
            this.textBoxZoneCoordinates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxZoneCoordinates.ForeColor = System.Drawing.Color.Gray;
            this.textBoxZoneCoordinates.Location = new System.Drawing.Point(83, 165);
            this.textBoxZoneCoordinates.MaximumSize = new System.Drawing.Size(460, 31);
            this.textBoxZoneCoordinates.MinimumSize = new System.Drawing.Size(460, 31);
            this.textBoxZoneCoordinates.Name = "textBoxZoneCoordinates";
            this.textBoxZoneCoordinates.Size = new System.Drawing.Size(460, 29);
            this.textBoxZoneCoordinates.TabIndex = 2;
            this.textBoxZoneCoordinates.Text = " Coordenades de la zona";
            this.textBoxZoneCoordinates.Enter += new System.EventHandler(this.textBoxZoneCoordinates_Enter);
            this.textBoxZoneCoordinates.Leave += new System.EventHandler(this.textBoxZoneCoordinates_Leave);
            // 
            // textBoxRange
            // 
            this.textBoxRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxRange.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRange.Location = new System.Drawing.Point(586, 165);
            this.textBoxRange.MaximumSize = new System.Drawing.Size(153, 31);
            this.textBoxRange.MinimumSize = new System.Drawing.Size(153, 31);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(153, 29);
            this.textBoxRange.TabIndex = 3;
            this.textBoxRange.Text = " Radi";
            this.textBoxRange.Enter += new System.EventHandler(this.textBoxRange_Enter);
            this.textBoxRange.Leave += new System.EventHandler(this.textBoxRange_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.radiusDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.classroomsDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dataGridView1.DataSource = this.bindingSourceZonesValidables;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(83, 243);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(829, 261);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonGuardarZona
            // 
            this.buttonGuardarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonGuardarZona.FlatAppearance.BorderSize = 0;
            this.buttonGuardarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarZona.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonGuardarZona.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarZona.Location = new System.Drawing.Point(775, 165);
            this.buttonGuardarZona.Name = "buttonGuardarZona";
            this.buttonGuardarZona.Size = new System.Drawing.Size(137, 31);
            this.buttonGuardarZona.TabIndex = 16;
            this.buttonGuardarZona.Text = "Guardar zona";
            this.buttonGuardarZona.UseVisualStyleBackColor = false;
            this.buttonGuardarZona.Click += new System.EventHandler(this.buttonGuardarZona_Click);
            // 
            // buttonAfegirAules
            // 
            this.buttonAfegirAules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonAfegirAules.FlatAppearance.BorderSize = 0;
            this.buttonAfegirAules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegirAules.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonAfegirAules.ForeColor = System.Drawing.Color.Black;
            this.buttonAfegirAules.Location = new System.Drawing.Point(664, 442);
            this.buttonAfegirAules.Name = "buttonAfegirAules";
            this.buttonAfegirAules.Size = new System.Drawing.Size(117, 27);
            this.buttonAfegirAules.TabIndex = 17;
            this.buttonAfegirAules.Text = "Afegir aules";
            this.buttonAfegirAules.UseVisualStyleBackColor = false;
            this.buttonAfegirAules.Click += new System.EventHandler(this.buttonAfegirAules_Click_1);
            // 
            // panelZonesValidables
            // 
            this.panelZonesValidables.Controls.Add(this.Guardar);
            this.panelZonesValidables.Controls.Add(this.textBoxRange);
            this.panelZonesValidables.Controls.Add(this.buttonGuardarZona);
            this.panelZonesValidables.Controls.Add(this.buttonAfegirAules);
            this.panelZonesValidables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZonesValidables.Location = new System.Drawing.Point(0, 0);
            this.panelZonesValidables.Name = "panelZonesValidables";
            this.panelZonesValidables.Size = new System.Drawing.Size(1005, 650);
            this.panelZonesValidables.TabIndex = 0;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(430, 562);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(137, 40);
            this.Guardar.TabIndex = 18;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 121.8274F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Libe_Escriptori.Properties.Resources.remove;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // bindingSourceZonesValidables
            // 
            this.bindingSourceZonesValidables.DataSource = typeof(Libe_Escriptori.Models.validable_zones);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radiusDataGridViewTextBoxColumn
            // 
            this.radiusDataGridViewTextBoxColumn.DataPropertyName = "radius";
            this.radiusDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.radiusDataGridViewTextBoxColumn.HeaderText = "Radi";
            this.radiusDataGridViewTextBoxColumn.Name = "radiusDataGridViewTextBoxColumn";
            this.radiusDataGridViewTextBoxColumn.ReadOnly = true;
            this.radiusDataGridViewTextBoxColumn.Width = 131;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
            this.latitudeDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitut";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.latitudeDataGridViewTextBoxColumn.Width = 150;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
            this.longitudeDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.longitudeDataGridViewTextBoxColumn.Width = 150;
            // 
            // classroomsDataGridViewTextBoxColumn
            // 
            this.classroomsDataGridViewTextBoxColumn.DataPropertyName = "classrooms";
            this.classroomsDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.classroomsDataGridViewTextBoxColumn.HeaderText = "Nombre d\'aules";
            this.classroomsDataGridViewTextBoxColumn.Name = "classroomsDataGridViewTextBoxColumn";
            this.classroomsDataGridViewTextBoxColumn.ReadOnly = true;
            this.classroomsDataGridViewTextBoxColumn.Width = 131;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 121.8274F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::Libe_Escriptori.Properties.Resources.close__1_;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 40;
            // 
            // FormCentreZonesValidables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxZoneCoordinates);
            this.Controls.Add(this.textBoxZoneName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelZonesValidables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCentreZonesValidables";
            this.Text = "FormCentreZonesValidables";
            this.Load += new System.EventHandler(this.FormCentreZonesValidables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelZonesValidables.ResumeLayout(false);
            this.panelZonesValidables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceZonesValidables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxZoneName;
        private TextBox textBoxZoneCoordinates;
        private TextBox textBoxRange;
        private DataGridView dataGridView1;
        private Button buttonGuardarZona;
        private Button buttonAfegirAules;
        private Panel panelZonesValidables;
        private Button Guardar;
        private BindingSource bindingSourceZonesValidables;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn radiusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classroomsDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Eliminar;
    }
}