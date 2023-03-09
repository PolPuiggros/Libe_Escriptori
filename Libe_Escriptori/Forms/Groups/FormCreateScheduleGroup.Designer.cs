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
            this.panelSchedule = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRightClick = new System.Windows.Forms.Label();
            this.labelLeftClick = new System.Windows.Forms.Label();
            this.pictureBoxRightClick = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftClick = new System.Windows.Forms.PictureBox();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.starting_hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewModuls = new System.Windows.Forms.ListView();
            this.bindingSourceLessons = new System.Windows.Forms.BindingSource(this.components);
            this.panelSchedule.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLessons)).BeginInit();
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
            this.panelSchedule.Size = new System.Drawing.Size(861, 563);
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
            this.panel1.Location = new System.Drawing.Point(713, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 109);
            this.panel1.TabIndex = 16;
            // 
            // labelRightClick
            // 
            this.labelRightClick.AutoSize = true;
            this.labelRightClick.Location = new System.Drawing.Point(37, 74);
            this.labelRightClick.Name = "labelRightClick";
            this.labelRightClick.Size = new System.Drawing.Size(86, 13);
            this.labelRightClick.TabIndex = 18;
            this.labelRightClick.Text = "Veure informació";
            // 
            // labelLeftClick
            // 
            this.labelLeftClick.AutoSize = true;
            this.labelLeftClick.Location = new System.Drawing.Point(37, 23);
            this.labelLeftClick.Name = "labelLeftClick";
            this.labelLeftClick.Size = new System.Drawing.Size(65, 13);
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
            this.pictureBoxRightClick.Location = new System.Drawing.Point(4, 65);
            this.pictureBoxRightClick.Name = "pictureBoxRightClick";
            this.pictureBoxRightClick.Size = new System.Drawing.Size(30, 30);
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
            this.pictureBoxLeftClick.Location = new System.Drawing.Point(4, 15);
            this.pictureBoxLeftClick.Name = "pictureBoxLeftClick";
            this.pictureBoxLeftClick.Size = new System.Drawing.Size(30, 30);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSchedule.ColumnHeadersHeight = 50;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.starting_hour,
            this.ColumnMonday,
            this.ColumnTuesday,
            this.ColumnWednesday,
            this.ColumnThursday,
            this.ColumnFriday});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(21, 26);
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
            this.dataGridViewSchedule.Size = new System.Drawing.Size(675, 457);
            this.dataGridViewSchedule.TabIndex = 12;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellClick);
            this.dataGridViewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellDoubleClick);
            this.dataGridViewSchedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSchedule_CellFormatting);
            this.dataGridViewSchedule.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSchedule_CellMouseUp);
            // 
            // starting_hour
            // 
            this.starting_hour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.starting_hour.DataPropertyName = "starting_hour";
            this.starting_hour.HeaderText = "";
            this.starting_hour.Name = "starting_hour";
            this.starting_hour.ReadOnly = true;
            // 
            // ColumnMonday
            // 
            this.ColumnMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMonday.HeaderText = "Dilluns";
            this.ColumnMonday.Name = "ColumnMonday";
            this.ColumnMonday.ReadOnly = true;
            // 
            // ColumnTuesday
            // 
            this.ColumnTuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTuesday.HeaderText = "Dimarts";
            this.ColumnTuesday.Name = "ColumnTuesday";
            this.ColumnTuesday.ReadOnly = true;
            // 
            // ColumnWednesday
            // 
            this.ColumnWednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnWednesday.DataPropertyName = "id";
            this.ColumnWednesday.HeaderText = "Dimecres";
            this.ColumnWednesday.Name = "ColumnWednesday";
            this.ColumnWednesday.ReadOnly = true;
            // 
            // ColumnThursday
            // 
            this.ColumnThursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnThursday.DataPropertyName = "id";
            this.ColumnThursday.HeaderText = "Dijous";
            this.ColumnThursday.Name = "ColumnThursday";
            this.ColumnThursday.ReadOnly = true;
            // 
            // ColumnFriday
            // 
            this.ColumnFriday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFriday.DataPropertyName = "id";
            this.ColumnFriday.HeaderText = "Divendres";
            this.ColumnFriday.Name = "ColumnFriday";
            this.ColumnFriday.ReadOnly = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(464, 496);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 35);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonCancel.Location = new System.Drawing.Point(320, 496);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 35);
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
            this.listViewModuls.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.listViewModuls.FullRowSelect = true;
            this.listViewModuls.HideSelection = false;
            this.listViewModuls.Location = new System.Drawing.Point(713, 25);
            this.listViewModuls.MultiSelect = false;
            this.listViewModuls.Name = "listViewModuls";
            this.listViewModuls.Size = new System.Drawing.Size(129, 310);
            this.listViewModuls.TabIndex = 15;
            this.listViewModuls.TileSize = new System.Drawing.Size(130, 30);
            this.listViewModuls.UseCompatibleStateImageBehavior = false;
            this.listViewModuls.View = System.Windows.Forms.View.List;
            this.listViewModuls.SelectedIndexChanged += new System.EventHandler(this.listViewModuls_SelectedIndexChanged);
            // 
            // bindingSourceLessons
            // 
            this.bindingSourceLessons.DataSource = typeof(Libe_Escriptori.Models.lessons);
            // 
            // FormCreateScheduleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 563);
            this.Controls.Add(this.panelSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateScheduleGroup";
            this.Text = "FormCreateScheduleGroup";
            this.Load += new System.EventHandler(this.FormCreateScheduleGroup_Load);
            this.panelSchedule.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLessons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSourceLessons;
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
        private DataGridViewTextBoxColumn starting_hour;
        private DataGridViewTextBoxColumn ColumnMonday;
        private DataGridViewTextBoxColumn ColumnTuesday;
        private DataGridViewTextBoxColumn ColumnWednesday;
        private DataGridViewTextBoxColumn ColumnThursday;
        private DataGridViewTextBoxColumn ColumnFriday;
    }
}