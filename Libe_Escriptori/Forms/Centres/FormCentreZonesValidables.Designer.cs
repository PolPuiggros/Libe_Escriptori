namespace Libe_Escriptori.Forms
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
            this.Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
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
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(454, 568);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(137, 40);
            this.Guardar.TabIndex = 10;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCentreZonesValidables";
            this.Text = "FormCentreZonesValidables";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Button Guardar;
    }
}