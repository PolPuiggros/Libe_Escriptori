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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("M01");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("M02");
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.headerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listViewModuls = new System.Windows.Forms.ListView();
            this.panelSchedule = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.AllowUserToResizeColumns = false;
            this.dataGridViewSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSchedule.ColumnHeadersHeight = 50;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerHour,
            this.headerMonday,
            this.headerTuesday,
            this.headerWednesday,
            this.headerThursday,
            this.headerFriday});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(24, 55);
            this.dataGridViewSchedule.MultiSelect = false;
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSchedule.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSchedule.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.RowTemplate.Height = 55;
            this.dataGridViewSchedule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(734, 527);
            this.dataGridViewSchedule.TabIndex = 0;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellClick);
            this.dataGridViewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellDoubleClick);
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
            // listViewModuls
            // 
            this.listViewModuls.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewModuls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewModuls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewModuls.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewModuls.FullRowSelect = true;
            this.listViewModuls.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewModuls.Location = new System.Drawing.Point(780, 55);
            this.listViewModuls.MultiSelect = false;
            this.listViewModuls.Name = "listViewModuls";
            this.listViewModuls.Scrollable = false;
            this.listViewModuls.Size = new System.Drawing.Size(204, 527);
            this.listViewModuls.TabIndex = 11;
            this.listViewModuls.TileSize = new System.Drawing.Size(360, 54);
            this.listViewModuls.UseCompatibleStateImageBehavior = false;
            this.listViewModuls.View = System.Windows.Forms.View.Tile;
            this.listViewModuls.SelectedIndexChanged += new System.EventHandler(this.listViewModuls_SelectedIndexChanged);
            // 
            // panelSchedule
            // 
            this.panelSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedule.Location = new System.Drawing.Point(0, 0);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Size = new System.Drawing.Size(1005, 650);
            this.panelSchedule.TabIndex = 12;
            // 
            // FormCreateScheduleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.listViewModuls);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.panelSchedule);
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
        private DataGridViewTextBoxColumn headerHour;
        private DataGridViewTextBoxColumn headerMonday;
        private DataGridViewTextBoxColumn headerTuesday;
        private DataGridViewTextBoxColumn headerWednesday;
        private DataGridViewTextBoxColumn headerThursday;
        private DataGridViewTextBoxColumn headerFriday;
        private Button buttonCancel;
        private Button buttonSave;
        private ListView listViewModuls;
        private Panel panelSchedule;
    }
}