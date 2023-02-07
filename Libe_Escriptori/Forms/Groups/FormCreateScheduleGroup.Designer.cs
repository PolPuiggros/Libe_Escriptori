namespace Libe_Escriptori.Forms.Groups
{
    partial class FormCreateScheduleGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.headerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModul1 = new System.Windows.Forms.Button();
            this.buttonModul2 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToResizeColumns = false;
            this.dataGridViewSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSchedule.ColumnHeadersHeight = 100;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerHour,
            this.headerMonday,
            this.headerTuesday,
            this.headerWednesday,
            this.headerThursday,
            this.headerFriday});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(24, 55);
            this.dataGridViewSchedule.MultiSelect = false;
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.RowTemplate.Height = 55;
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(734, 527);
            this.dataGridViewSchedule.TabIndex = 0;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellClick);
            // 
            // headerHour
            // 
            this.headerHour.HeaderText = "Hora";
            this.headerHour.Name = "headerHour";
            this.headerHour.ReadOnly = true;
            // 
            // headerMonday
            // 
            this.headerMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerMonday.HeaderText = "Dilluns";
            this.headerMonday.Name = "headerMonday";
            this.headerMonday.ReadOnly = true;
            // 
            // headerTuesday
            // 
            this.headerTuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerTuesday.HeaderText = "Dimarts";
            this.headerTuesday.Name = "headerTuesday";
            this.headerTuesday.ReadOnly = true;
            // 
            // headerWednesday
            // 
            this.headerWednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerWednesday.HeaderText = "Dimecres";
            this.headerWednesday.Name = "headerWednesday";
            this.headerWednesday.ReadOnly = true;
            // 
            // headerThursday
            // 
            this.headerThursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerThursday.HeaderText = "Dijous";
            this.headerThursday.Name = "headerThursday";
            this.headerThursday.ReadOnly = true;
            // 
            // headerFriday
            // 
            this.headerFriday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerFriday.HeaderText = "Divendres";
            this.headerFriday.Name = "headerFriday";
            this.headerFriday.ReadOnly = true;
            // 
            // buttonModul1
            // 
            this.buttonModul1.Location = new System.Drawing.Point(773, 55);
            this.buttonModul1.Name = "buttonModul1";
            this.buttonModul1.Size = new System.Drawing.Size(95, 62);
            this.buttonModul1.TabIndex = 1;
            this.buttonModul1.Text = "M01";
            this.buttonModul1.UseVisualStyleBackColor = true;
            this.buttonModul1.Click += new System.EventHandler(this.buttonModul1_Click);
            // 
            // buttonModul2
            // 
            this.buttonModul2.Location = new System.Drawing.Point(884, 55);
            this.buttonModul2.Name = "buttonModul2";
            this.buttonModul2.Size = new System.Drawing.Size(95, 62);
            this.buttonModul2.TabIndex = 2;
            this.buttonModul2.Text = "M02";
            this.buttonModul2.UseVisualStyleBackColor = true;
            this.buttonModul2.Click += new System.EventHandler(this.buttonModul2_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(334, 588);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 50);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(502, 588);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 50);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // FormCreateScheduleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModul2);
            this.Controls.Add(this.buttonModul1);
            this.Controls.Add(this.dataGridViewSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateScheduleGroup";
            this.Text = "FormCreateScheduleGroup";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dataGridViewSchedule;
        private Button buttonModul1;
        private Button buttonModul2;
        private DataGridViewTextBoxColumn headerHour;
        private DataGridViewTextBoxColumn headerMonday;
        private DataGridViewTextBoxColumn headerTuesday;
        private DataGridViewTextBoxColumn headerWednesday;
        private DataGridViewTextBoxColumn headerThursday;
        private DataGridViewTextBoxColumn headerFriday;
        private Button buttonCancel;
        private Button buttonSave;
    }
}