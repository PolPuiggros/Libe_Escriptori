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
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxFilterGroups = new System.Windows.Forms.ComboBox();
            this.textBoxFilterGroups = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(56, 47);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(75, 40);
            this.buttonNewGroup.TabIndex = 0;
            this.buttonNewGroup.Text = "Nou";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(882, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBoxFilterGroups
            // 
            this.comboBoxFilterGroups.FormattingEnabled = true;
            this.comboBoxFilterGroups.Location = new System.Drawing.Point(817, 57);
            this.comboBoxFilterGroups.Name = "comboBoxFilterGroups";
            this.comboBoxFilterGroups.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFilterGroups.TabIndex = 2;
            // 
            // textBoxFilterGroups
            // 
            this.textBoxFilterGroups.Location = new System.Drawing.Point(534, 57);
            this.textBoxFilterGroups.Name = "textBoxFilterGroups";
            this.textBoxFilterGroups.Size = new System.Drawing.Size(283, 23);
            this.textBoxFilterGroups.TabIndex = 3;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.textBoxFilterGroups);
            this.Controls.Add(this.comboBoxFilterGroups);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonNewGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNewGroup;
        private DataGridView dataGridView1;
        private ComboBox comboBoxFilterGroups;
        private TextBox textBoxFilterGroups;
    }
}