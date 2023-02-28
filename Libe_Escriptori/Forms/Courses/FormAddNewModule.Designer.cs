namespace Libe_Escriptori.Forms.Courses
{
    partial class FormAddNewModule
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
            this.labelNewModule = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUF = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
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
            this.panelNewModule.Controls.Add(this.textBoxName);
            this.panelNewModule.Controls.Add(this.textBoxAbbreviation);
            this.panelNewModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewModule.Location = new System.Drawing.Point(0, 0);
            this.panelNewModule.Name = "panelNewModule";
            this.panelNewModule.Size = new System.Drawing.Size(1005, 650);
            this.panelNewModule.TabIndex = 0;
            // 
            // labelNewModule
            // 
            this.labelNewModule.AutoSize = true;
            this.labelNewModule.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewModule.Location = new System.Drawing.Point(96, 53);
            this.labelNewModule.Name = "labelNewModule";
            this.labelNewModule.Size = new System.Drawing.Size(153, 37);
            this.labelNewModule.TabIndex = 10;
            this.labelNewModule.Text = "Nou Modul";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(340, 551);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 40);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
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
            this.buttonSave.Size = new System.Drawing.Size(137, 40);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUF.Location = new System.Drawing.Point(96, 172);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(60, 37);
            this.labelUF.TabIndex = 4;
            this.labelUF.Text = "UFs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(828, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHours.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHours.Location = new System.Drawing.Point(286, 105);
            this.textBoxHours.MaximumSize = new System.Drawing.Size(185, 31);
            this.textBoxHours.MinimumSize = new System.Drawing.Size(185, 31);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(185, 31);
            this.textBoxHours.TabIndex = 2;
            this.textBoxHours.Text = " Hores";
            this.textBoxHours.Enter += new System.EventHandler(this.textBoxHours_Enter);
            this.textBoxHours.Leave += new System.EventHandler(this.textBoxHours_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxName.Location = new System.Drawing.Point(477, 105);
            this.textBoxName.MaximumSize = new System.Drawing.Size(447, 31);
            this.textBoxName.MinimumSize = new System.Drawing.Size(447, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(447, 31);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = " Nom complert";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAbbreviation.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAbbreviation.Location = new System.Drawing.Point(96, 105);
            this.textBoxAbbreviation.MaximumSize = new System.Drawing.Size(179, 31);
            this.textBoxAbbreviation.MinimumSize = new System.Drawing.Size(179, 31);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(179, 31);
            this.textBoxAbbreviation.TabIndex = 0;
            this.textBoxAbbreviation.Text = " Abreviació";
            this.textBoxAbbreviation.Enter += new System.EventHandler(this.textBoxAbbreviation_Enter);
            this.textBoxAbbreviation.Leave += new System.EventHandler(this.textBoxAbbreviation_Leave);
            // 
            // FormAddNewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelNewModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddNewModule";
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
        private TextBox textBoxName;
        private TextBox textBoxAbbreviation;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelNewModule;
    }
}