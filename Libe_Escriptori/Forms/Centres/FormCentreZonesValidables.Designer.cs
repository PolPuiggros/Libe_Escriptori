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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZoneName = new System.Windows.Forms.TextBox();
            this.textBoxZoneCoordinates = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuardarZona = new System.Windows.Forms.Button();
            this.buttonAfegirAules = new System.Windows.Forms.Button();
            this.panelZonesValidables = new System.Windows.Forms.Panel();
            this.Guardar = new System.Windows.Forms.Button();
            this.buttonAfegirAules = new System.Windows.Forms.Button();
            this.buttonGuardarZona = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRadi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelZonesValidables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelZonesValidables
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(394, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zones Validables";
            // 
            // textBoxZoneName
            // 
            this.textBoxZoneName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxZoneName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxZoneName.Location = new System.Drawing.Point(83, 99);
            this.textBoxZoneName.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBoxZoneName.MinimumSize = new System.Drawing.Size(829, 31);
            this.textBoxZoneName.Name = "textBoxZoneName";
            this.textBoxZoneName.Size = new System.Drawing.Size(829, 31);
            this.textBoxZoneName.TabIndex = 1;
            this.textBoxZoneName.Text = " Nom de la zona validable";
            this.textBoxZoneName.Enter += new System.EventHandler(this.textBoxZoneName_Enter);
            this.textBoxZoneName.Leave += new System.EventHandler(this.textBoxZoneName_Leave);
            // 
            // textBoxZoneCoordinates
            // 
            this.textBoxZoneCoordinates.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxZoneCoordinates.ForeColor = System.Drawing.Color.Gray;
            this.textBoxZoneCoordinates.Location = new System.Drawing.Point(83, 165);
            this.textBoxZoneCoordinates.MaximumSize = new System.Drawing.Size(460, 31);
            this.textBoxZoneCoordinates.MinimumSize = new System.Drawing.Size(460, 31);
            this.textBoxZoneCoordinates.Name = "textBoxZoneCoordinates";
            this.textBoxZoneCoordinates.Size = new System.Drawing.Size(460, 31);
            this.textBoxZoneCoordinates.TabIndex = 2;
            this.textBoxZoneCoordinates.Text = " Coordenades de la zona";
            this.textBoxZoneCoordinates.Enter += new System.EventHandler(this.textBoxZoneCoordinates_Enter);
            this.textBoxZoneCoordinates.Leave += new System.EventHandler(this.textBoxZoneCoordinates_Leave);
            // 
            // textBoxRange
            // 
            this.textBoxRange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRange.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRange.Location = new System.Drawing.Point(586, 165);
            this.textBoxRange.MaximumSize = new System.Drawing.Size(153, 31);
            this.textBoxRange.MinimumSize = new System.Drawing.Size(153, 31);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(153, 31);
            this.textBoxRange.TabIndex = 3;
            this.textBoxRange.Text = " Radi";
            this.textBoxRange.Enter += new System.EventHandler(this.textBoxRange_Enter);
            this.textBoxRange.Leave += new System.EventHandler(this.textBoxRange_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(829, 261);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonGuardarZona
            // 
            this.buttonGuardarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonGuardarZona.FlatAppearance.BorderSize = 0;
            this.buttonGuardarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarZona.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarZona.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarZona.Location = new System.Drawing.Point(775, 166);
            this.buttonGuardarZona.Name = "buttonGuardarZona";
            this.buttonGuardarZona.Size = new System.Drawing.Size(137, 31);
            this.buttonGuardarZona.TabIndex = 6;
            this.buttonGuardarZona.Text = "Guardar zona";
            this.buttonGuardarZona.UseVisualStyleBackColor = false;
            // 
            // buttonAfegirAules
            // 
            this.buttonAfegirAules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonAfegirAules.FlatAppearance.BorderSize = 0;
            this.buttonAfegirAules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegirAules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAfegirAules.ForeColor = System.Drawing.Color.Black;
            this.buttonAfegirAules.Location = new System.Drawing.Point(775, 508);
            this.buttonAfegirAules.Name = "buttonAfegirAules";
            this.buttonAfegirAules.Size = new System.Drawing.Size(137, 31);
            this.buttonAfegirAules.TabIndex = 9;
            this.buttonAfegirAules.Text = "Afegir aules";
            this.buttonAfegirAules.UseVisualStyleBackColor = false;
            this.panelZonesValidables.Controls.Add(this.Guardar);
            this.panelZonesValidables.Controls.Add(this.buttonAfegirAules);
            this.panelZonesValidables.Controls.Add(this.buttonGuardarZona);
            this.panelZonesValidables.Controls.Add(this.dataGridView1);
            this.panelZonesValidables.Controls.Add(this.textBoxRadi);
            this.panelZonesValidables.Controls.Add(this.textBox2);
            this.panelZonesValidables.Controls.Add(this.textBox1);
            this.panelZonesValidables.Controls.Add(this.label1);
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
            this.Guardar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(459, 570);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(137, 40);
            this.Guardar.TabIndex = 18;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            // 
            // buttonAfegirAules
            // 
            this.buttonAfegirAules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonAfegirAules.FlatAppearance.BorderSize = 0;
            this.buttonAfegirAules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegirAules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAfegirAules.ForeColor = System.Drawing.Color.Black;
            this.buttonAfegirAules.Location = new System.Drawing.Point(780, 510);
            this.buttonAfegirAules.Name = "buttonAfegirAules";
            this.buttonAfegirAules.Size = new System.Drawing.Size(137, 31);
            this.buttonAfegirAules.TabIndex = 17;
            this.buttonAfegirAules.Text = "Afegir aules";
            this.buttonAfegirAules.UseVisualStyleBackColor = false;
            this.buttonAfegirAules.Click += new System.EventHandler(this.buttonAfegirAules_Click_1);
            // 
            // buttonGuardarZona
            // 
            this.buttonGuardarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonGuardarZona.FlatAppearance.BorderSize = 0;
            this.buttonGuardarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarZona.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarZona.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarZona.Location = new System.Drawing.Point(780, 168);
            this.buttonGuardarZona.Name = "buttonGuardarZona";
            this.buttonGuardarZona.Size = new System.Drawing.Size(137, 31);
            this.buttonGuardarZona.TabIndex = 16;
            this.buttonGuardarZona.Text = "Guardar zona";
            this.buttonGuardarZona.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(829, 261);
            this.dataGridView1.TabIndex = 15;
            // 
            // textBoxRadi
            // 
            this.textBoxRadi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRadi.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxRadi.Location = new System.Drawing.Point(591, 167);
            this.textBoxRadi.MaximumSize = new System.Drawing.Size(153, 31);
            this.textBoxRadi.MinimumSize = new System.Drawing.Size(153, 31);
            this.textBoxRadi.Name = "textBoxRadi";
            this.textBoxRadi.Size = new System.Drawing.Size(153, 31);
            this.textBoxRadi.TabIndex = 14;
            this.textBoxRadi.Text = " Radi";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(88, 167);
            this.textBox2.MaximumSize = new System.Drawing.Size(460, 31);
            this.textBox2.MinimumSize = new System.Drawing.Size(460, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 31);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = " Coordenades de la zona";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(88, 101);
            this.textBox1.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBox1.MinimumSize = new System.Drawing.Size(829, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(829, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = " Nom de la zona validable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(399, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zones Validables";
            // 
            // FormCentreZonesValidables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.buttonAfegirAules);
            this.Controls.Add(this.buttonGuardarZona);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.textBoxZoneCoordinates);
            this.Controls.Add(this.textBoxZoneName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelZonesValidables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCentreZonesValidables";
            this.Text = "FormCentreZonesValidables";
            this.panelZonesValidables.ResumeLayout(false);
            this.panelZonesValidables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private Button buttonAfegirAules;
        private Button buttonGuardarZona;
        private DataGridView dataGridView1;
        private TextBox textBoxRadi;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}