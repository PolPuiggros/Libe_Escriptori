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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomDepartament = new System.Windows.Forms.TextBox();
            this.comboBoxDepartaments = new System.Windows.Forms.ComboBox();
            this.buttonGuardarZona = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(397, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departaments";
            // 
            // textBoxNomDepartament
            // 
            this.textBoxNomDepartament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomDepartament.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNomDepartament.Location = new System.Drawing.Point(100, 118);
            this.textBoxNomDepartament.MaximumSize = new System.Drawing.Size(829, 31);
            this.textBoxNomDepartament.MinimumSize = new System.Drawing.Size(829, 31);
            this.textBoxNomDepartament.Name = "textBoxNomDepartament";
            this.textBoxNomDepartament.Size = new System.Drawing.Size(829, 31);
            this.textBoxNomDepartament.TabIndex = 2;
            this.textBoxNomDepartament.Text = " Nom del departament";
            this.textBoxNomDepartament.Enter += new System.EventHandler(this.textBoxNomDepartament_Enter);
            this.textBoxNomDepartament.Leave += new System.EventHandler(this.textBoxNomDepartament_Leave);
            // 
            // comboBoxDepartaments
            // 
            this.comboBoxDepartaments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDepartaments.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxDepartaments.FormattingEnabled = true;
            this.comboBoxDepartaments.Location = new System.Drawing.Point(100, 178);
            this.comboBoxDepartaments.MaximumSize = new System.Drawing.Size(389, 0);
            this.comboBoxDepartaments.MinimumSize = new System.Drawing.Size(389, 0);
            this.comboBoxDepartaments.Name = "comboBoxDepartaments";
            this.comboBoxDepartaments.Size = new System.Drawing.Size(389, 29);
            this.comboBoxDepartaments.TabIndex = 3;
            this.comboBoxDepartaments.Text = " Coordinador";
            // 
            // buttonGuardarZona
            // 
            this.buttonGuardarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonGuardarZona.FlatAppearance.BorderSize = 0;
            this.buttonGuardarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarZona.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarZona.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarZona.Location = new System.Drawing.Point(505, 178);
            this.buttonGuardarZona.Name = "buttonGuardarZona";
            this.buttonGuardarZona.Size = new System.Drawing.Size(137, 29);
            this.buttonGuardarZona.TabIndex = 7;
            this.buttonGuardarZona.Text = "Afegir dept.";
            this.buttonGuardarZona.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(829, 292);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormCentreDepartaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGuardarZona);
            this.Controls.Add(this.comboBoxDepartaments);
            this.Controls.Add(this.textBoxNomDepartament);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCentreDepartaments";
            this.Text = "FormCentreDepartaments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNomDepartament;
        private ComboBox comboBoxDepartaments;
        private Button buttonGuardarZona;
        private DataGridView dataGridView1;
    }
}