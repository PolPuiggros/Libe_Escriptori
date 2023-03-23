using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Groups
{
    partial class FormScheduleCellInfo
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
            this.labelDay = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelModul = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelDay.Location = new System.Drawing.Point(11, 15);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(61, 23);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Dilluns";
            // 
            // labelHour
            // 
            this.labelHour.AllowDrop = true;
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelHour.Location = new System.Drawing.Point(78, 15);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(89, 23);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "8:40 - 9:40";
            // 
            // labelModul
            // 
            this.labelModul.AutoSize = true;
            this.labelModul.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelModul.Location = new System.Drawing.Point(64, 41);
            this.labelModul.Name = "labelModul";
            this.labelModul.Size = new System.Drawing.Size(43, 23);
            this.labelModul.TabIndex = 2;
            this.labelModul.Text = "M01";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(29, 72);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(115, 21);
            this.comboBoxClass.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(55, 109);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(64, 28);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Guardar";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormScheduleCellInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 146);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelModul);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScheduleCellInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleCellInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDay;
        private Label labelHour;
        private Label labelModul;
        private ComboBox comboBoxClass;
        private Button buttonDone;
    }
}