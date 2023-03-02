using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Groups
{
    partial class FormGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.headerCicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerAlumnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.comboBox3);
            this.panelGroups.Controls.Add(this.comboBox1);
            this.panelGroups.Controls.Add(this.comboBoxFilter);
            this.panelGroups.Controls.Add(this.dataGridView1);
            this.panelGroups.Controls.Add(this.buttonNewGroup);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(0, 0);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(1005, 650);
            this.panelGroups.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerCicle,
            this.headerPromotion,
            this.headerClass,
            this.headerTutor,
            this.headerAlumnes,
            this.headerEdit,
            this.headerDelete});
            this.dataGridView1.Location = new System.Drawing.Point(61, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(882, 464);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.BackColor = System.Drawing.Color.White;
            this.buttonNewGroup.FlatAppearance.BorderSize = 0;
            this.buttonNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewGroup.Location = new System.Drawing.Point(61, 66);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(137, 35);
            this.buttonNewGroup.TabIndex = 4;
            this.buttonNewGroup.Text = "Nou";
            this.buttonNewGroup.UseVisualStyleBackColor = false;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click_1);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.IntegralHeight = false;
            this.comboBoxFilter.ItemHeight = 21;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBoxFilter.Location = new System.Drawing.Point(384, 72);
            this.comboBoxFilter.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBoxFilter.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(168, 29);
            this.comboBoxFilter.TabIndex = 9;
            this.comboBoxFilter.Text = "Cicle";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 21;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBox1.Location = new System.Drawing.Point(775, 72);
            this.comboBox1.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 29);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Promoció";
            // 
            // headerCicle
            // 
            this.headerCicle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerCicle.HeaderText = "Cicle";
            this.headerCicle.Name = "headerCicle";
            this.headerCicle.ReadOnly = true;
            // 
            // headerPromotion
            // 
            this.headerPromotion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerPromotion.HeaderText = "Promoció";
            this.headerPromotion.Name = "headerPromotion";
            this.headerPromotion.ReadOnly = true;
            // 
            // headerClass
            // 
            this.headerClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerClass.HeaderText = "Classe";
            this.headerClass.Name = "headerClass";
            this.headerClass.ReadOnly = true;
            // 
            // headerTutor
            // 
            this.headerTutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerTutor.HeaderText = "Tutor";
            this.headerTutor.Name = "headerTutor";
            this.headerTutor.ReadOnly = true;
            // 
            // headerAlumnes
            // 
            this.headerAlumnes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerAlumnes.HeaderText = "Aula";
            this.headerAlumnes.Name = "headerAlumnes";
            this.headerAlumnes.ReadOnly = true;
            // 
            // headerEdit
            // 
            this.headerEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.headerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerEdit.HeaderText = "";
            this.headerEdit.Name = "headerEdit";
            this.headerEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.headerEdit.Width = 29;
            // 
            // headerDelete
            // 
            this.headerDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.headerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerDelete.HeaderText = "";
            this.headerDelete.Name = "headerDelete";
            this.headerDelete.ReadOnly = true;
            this.headerDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.headerDelete.Width = 29;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.ItemHeight = 21;
            this.comboBox3.Items.AddRange(new object[] {
            "Nom",
            "Cognom",
            "DNI"});
            this.comboBox3.Location = new System.Drawing.Point(580, 72);
            this.comboBox3.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBox3.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 29);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.Text = "Classe";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelGroups);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.panelGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGroups;
        private DataGridView dataGridView1;
        private Button buttonNewGroup;
        private ComboBox comboBoxFilter;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn headerCicle;
        private DataGridViewTextBoxColumn headerPromotion;
        private DataGridViewTextBoxColumn headerClass;
        private DataGridViewTextBoxColumn headerTutor;
        private DataGridViewTextBoxColumn headerAlumnes;
        private DataGridViewButtonColumn headerEdit;
        private DataGridViewButtonColumn headerDelete;
        private ComboBox comboBox3;
    }
}