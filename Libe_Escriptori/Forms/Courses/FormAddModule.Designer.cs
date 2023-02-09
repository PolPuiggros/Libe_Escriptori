namespace Libe_Escriptori.Forms.Courses
{
    partial class FormAddModule
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
            this.panelNewModule = new System.Windows.Forms.Panel();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelUF = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNewModule = new System.Windows.Forms.Label();
            this.panelNewModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNewModule
            // 
            this.panelNewModule.Controls.Add(this.labelNewModule);
            this.panelNewModule.Controls.Add(this.buttonCancel);
            this.panelNewModule.Controls.Add(this.buttonSave);
            this.panelNewModule.Controls.Add(this.labelUF);
            this.panelNewModule.Controls.Add(this.dataGridView1);
            this.panelNewModule.Controls.Add(this.textBoxHours);
            this.panelNewModule.Controls.Add(this.textBox2);
            this.panelNewModule.Controls.Add(this.textBoxAbbreviation);
            this.panelNewModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewModule.Location = new System.Drawing.Point(0, 0);
            this.panelNewModule.Name = "panelNewModule";
            this.panelNewModule.Size = new System.Drawing.Size(1005, 650);
            this.panelNewModule.TabIndex = 0;
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAbbreviation.Location = new System.Drawing.Point(101, 105);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(179, 31);
            this.textBoxAbbreviation.TabIndex = 0;
            this.textBoxAbbreviation.Text = "Abreviació";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(477, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Nom complert";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHours.Location = new System.Drawing.Point(286, 105);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(185, 31);
            this.textBoxHours.TabIndex = 2;
            this.textBoxHours.Text = "Hores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(823, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUF.Location = new System.Drawing.Point(96, 173);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(41, 25);
            this.labelUF.TabIndex = 4;
            this.labelUF.Text = "UFs";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(548, 551);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 41);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(340, 551);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 41);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelNewModule
            // 
            this.labelNewModule.AutoSize = true;
            this.labelNewModule.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewModule.Location = new System.Drawing.Point(96, 64);
            this.labelNewModule.Name = "labelNewModule";
            this.labelNewModule.Size = new System.Drawing.Size(103, 25);
            this.labelNewModule.TabIndex = 10;
            this.labelNewModule.Text = "Nou Modul";
            // 
            // FormAddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelNewModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddModule";
            this.Text = "FormAddModule";
            this.panelNewModule.ResumeLayout(false);
            this.panelNewModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNewModule;
        private Label labelUF;
        private DataGridView dataGridView1;
        private TextBox textBoxHours;
        private TextBox textBox2;
        private TextBox textBoxAbbreviation;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelNewModule;
    }
}