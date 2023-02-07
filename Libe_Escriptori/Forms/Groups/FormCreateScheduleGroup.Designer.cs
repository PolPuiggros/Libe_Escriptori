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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.buttonModul1 = new System.Windows.Forms.Button();
            this.buttonModul2 = new System.Windows.Forms.Button();
            this.headerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerHour,
            this.headerMonday,
            this.headerTuesday,
            this.headerWednesday,
            this.headerThursday,
            this.headerFriday});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(24, 55);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(734, 565);
            this.dataGridViewSchedule.TabIndex = 0;
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
            // FormCreateScheduleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
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
    }
}