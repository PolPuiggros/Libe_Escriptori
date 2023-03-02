using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateScheduleGroup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelSchedule = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRightClick = new System.Windows.Forms.Label();
            this.labelLeftClick = new System.Windows.Forms.Label();
            this.pictureBoxRightClick = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftClick = new System.Windows.Forms.PictureBox();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.headerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewModuls = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelSchedule.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSchedule
            // 
            this.panelSchedule.Controls.Add(this.panel1);
            this.panelSchedule.Controls.Add(this.dataGridViewSchedule);
            this.panelSchedule.Controls.Add(this.buttonSave);
            this.panelSchedule.Controls.Add(this.buttonCancel);
            this.panelSchedule.Controls.Add(this.listViewModuls);
            this.panelSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedule.Location = new System.Drawing.Point(0, 0);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Size = new System.Drawing.Size(1005, 650);
            this.panelSchedule.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelRightClick);
            this.panel1.Controls.Add(this.labelLeftClick);
            this.panel1.Controls.Add(this.pictureBoxRightClick);
            this.panel1.Controls.Add(this.pictureBoxLeftClick);
            this.panel1.Location = new System.Drawing.Point(832, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 126);
            this.panel1.TabIndex = 16;
            // 
            // labelRightClick
            // 
            this.labelRightClick.AutoSize = true;
            this.labelRightClick.Location = new System.Drawing.Point(43, 85);
            this.labelRightClick.Name = "labelRightClick";
            this.labelRightClick.Size = new System.Drawing.Size(97, 15);
            this.labelRightClick.TabIndex = 18;
            this.labelRightClick.Text = "Veure informació";
            // 
            // labelLeftClick
            // 
            this.labelLeftClick.AutoSize = true;
            this.labelLeftClick.Location = new System.Drawing.Point(43, 27);
            this.labelLeftClick.Name = "labelLeftClick";
            this.labelLeftClick.Size = new System.Drawing.Size(77, 15);
            this.labelLeftClick.TabIndex = 17;
            this.labelLeftClick.Text = "Afegir mòdul";
            // 
            // pictureBoxRightClick
            // 
            this.pictureBoxRightClick.BackColor = System.Drawing.Color.White;
            this.pictureBoxRightClick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightClick.BackgroundImage")));
            this.pictureBoxRightClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRightClick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightClick.Image")));
            this.pictureBoxRightClick.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightClick.InitialImage")));
            this.pictureBoxRightClick.Location = new System.Drawing.Point(5, 75);
            this.pictureBoxRightClick.Name = "pictureBoxRightClick";
            this.pictureBoxRightClick.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxRightClick.TabIndex = 1;
            this.pictureBoxRightClick.TabStop = false;
            // 
            // pictureBoxLeftClick
            // 
            this.pictureBoxLeftClick.BackColor = System.Drawing.Color.White;
            this.pictureBoxLeftClick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftClick.BackgroundImage")));
            this.pictureBoxLeftClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeftClick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftClick.Image")));
            this.pictureBoxLeftClick.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftClick.InitialImage")));
            this.pictureBoxLeftClick.Location = new System.Drawing.Point(5, 17);
            this.pictureBoxLeftClick.Name = "pictureBoxLeftClick";
            this.pictureBoxLeftClick.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxLeftClick.TabIndex = 0;
            this.pictureBoxLeftClick.TabStop = false;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.AllowUserToResizeColumns = false;
            this.dataGridViewSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSchedule.ColumnHeadersHeight = 50;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.dataGridViewSchedule.Location = new System.Drawing.Point(25, 30);
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
            this.dataGridViewSchedule.Size = new System.Drawing.Size(788, 527);
            this.dataGridViewSchedule.TabIndex = 12;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellClick);
            this.dataGridViewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellDoubleClick);
            this.dataGridViewSchedule.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSchedule_CellMouseUp);
            // 
            // headerHour
            // 
            this.headerHour.HeaderText = "Hora";
            this.headerHour.Name = "headerHour";
            this.headerHour.ReadOnly = true;
            this.headerHour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.headerHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // headerMonday
            // 
            this.headerMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerMonday.HeaderText = "Dilluns";
            this.headerMonday.Name = "headerMonday";
            this.headerMonday.ReadOnly = true;
            this.headerMonday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.headerMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // headerTuesday
            // 
            this.headerTuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerTuesday.HeaderText = "Dimarts";
            this.headerTuesday.Name = "headerTuesday";
            this.headerTuesday.ReadOnly = true;
            this.headerTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.headerTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // headerWednesday
            // 
            this.headerWednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerWednesday.HeaderText = "Dimecres";
            this.headerWednesday.Name = "headerWednesday";
            this.headerWednesday.ReadOnly = true;
            this.headerWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.headerWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // headerThursday
            // 
            this.headerThursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerThursday.HeaderText = "Dijous";
            this.headerThursday.Name = "headerThursday";
            this.headerThursday.ReadOnly = true;
            this.headerThursday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.headerThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // headerFriday
            // 
            this.headerFriday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerFriday.HeaderText = "Divendres";
            this.headerFriday.Name = "headerFriday";
            this.headerFriday.ReadOnly = true;
            this.headerFriday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.headerFriday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(541, 572);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 40);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(373, 572);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 40);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // listViewModuls
            // 
            this.listViewModuls.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewModuls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewModuls.AutoArrange = false;
            this.listViewModuls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewModuls.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewModuls.FullRowSelect = true;
            this.listViewModuls.Location = new System.Drawing.Point(832, 29);
            this.listViewModuls.MultiSelect = false;
            this.listViewModuls.Name = "listViewModuls";
            this.listViewModuls.Size = new System.Drawing.Size(150, 358);
            this.listViewModuls.TabIndex = 15;
            this.listViewModuls.TileSize = new System.Drawing.Size(130, 30);
            this.listViewModuls.UseCompatibleStateImageBehavior = false;
            this.listViewModuls.View = System.Windows.Forms.View.Tile;
            this.listViewModuls.SelectedIndexChanged += new System.EventHandler(this.listViewModuls_SelectedIndexChanged);
            // 
            // FormCreateScheduleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateScheduleGroup";
            this.Text = "FormCreateScheduleGroup";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelSchedule.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panelSchedule;
        private DataGridView dataGridViewSchedule;
        private Button buttonSave;
        private Button buttonCancel;
        private ListView listViewModuls;
        private Panel panel1;
        private PictureBox pictureBoxLeftClick;
        private Label labelLeftClick;
        private PictureBox pictureBoxRightClick;
        private Label labelRightClick;
        private DataGridViewTextBoxColumn headerHour;
        private DataGridViewTextBoxColumn headerMonday;
        private DataGridViewTextBoxColumn headerTuesday;
        private DataGridViewTextBoxColumn headerWednesday;
        private DataGridViewTextBoxColumn headerThursday;
        private DataGridViewTextBoxColumn headerFriday;
    }
}