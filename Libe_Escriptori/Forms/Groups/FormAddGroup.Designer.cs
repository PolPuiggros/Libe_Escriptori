﻿namespace Libe_Escriptori.Forms.Groups
{
    partial class FormAddGroup
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
            this.comboBoxCicleGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxYearGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxClassGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxTutorGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxMainClassGroup = new System.Windows.Forms.ComboBox();
            this.panelManageStudents = new System.Windows.Forms.Panel();
            this.labelNoStudents = new System.Windows.Forms.Label();
            this.labelStudents = new System.Windows.Forms.Label();
            this.buttonManageStudents = new System.Windows.Forms.Button();
            this.panelManageSchedule = new System.Windows.Forms.Panel();
            this.labelNoSchedule = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelAddGroup = new System.Windows.Forms.Panel();
            this.panelManageStudents.SuspendLayout();
            this.panelManageSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCicleGroup
            // 
            this.comboBoxCicleGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCicleGroup.FormattingEnabled = true;
            this.comboBoxCicleGroup.Location = new System.Drawing.Point(59, 62);
            this.comboBoxCicleGroup.Name = "comboBoxCicleGroup";
            this.comboBoxCicleGroup.Size = new System.Drawing.Size(166, 31);
            this.comboBoxCicleGroup.TabIndex = 0;
            this.comboBoxCicleGroup.Text = "Cicle";
            // 
            // comboBoxYearGroup
            // 
            this.comboBoxYearGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxYearGroup.FormattingEnabled = true;
            this.comboBoxYearGroup.Location = new System.Drawing.Point(254, 62);
            this.comboBoxYearGroup.Name = "comboBoxYearGroup";
            this.comboBoxYearGroup.Size = new System.Drawing.Size(162, 31);
            this.comboBoxYearGroup.TabIndex = 1;
            this.comboBoxYearGroup.Text = "Any";
            // 
            // comboBoxClassGroup
            // 
            this.comboBoxClassGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClassGroup.FormattingEnabled = true;
            this.comboBoxClassGroup.Location = new System.Drawing.Point(437, 62);
            this.comboBoxClassGroup.Name = "comboBoxClassGroup";
            this.comboBoxClassGroup.Size = new System.Drawing.Size(193, 31);
            this.comboBoxClassGroup.TabIndex = 2;
            this.comboBoxClassGroup.Text = "Classe";
            // 
            // comboBoxTutorGroup
            // 
            this.comboBoxTutorGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTutorGroup.FormattingEnabled = true;
            this.comboBoxTutorGroup.Location = new System.Drawing.Point(59, 115);
            this.comboBoxTutorGroup.Name = "comboBoxTutorGroup";
            this.comboBoxTutorGroup.Size = new System.Drawing.Size(288, 31);
            this.comboBoxTutorGroup.TabIndex = 3;
            this.comboBoxTutorGroup.Text = "Tutor";
            // 
            // comboBoxMainClassGroup
            // 
            this.comboBoxMainClassGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMainClassGroup.FormattingEnabled = true;
            this.comboBoxMainClassGroup.Location = new System.Drawing.Point(380, 115);
            this.comboBoxMainClassGroup.Name = "comboBoxMainClassGroup";
            this.comboBoxMainClassGroup.Size = new System.Drawing.Size(250, 31);
            this.comboBoxMainClassGroup.TabIndex = 4;
            this.comboBoxMainClassGroup.Text = "Aula Principal";
            // 
            // panelManageStudents
            // 
            this.panelManageStudents.BackColor = System.Drawing.Color.White;
            this.panelManageStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManageStudents.Controls.Add(this.labelNoStudents);
            this.panelManageStudents.Controls.Add(this.labelStudents);
            this.panelManageStudents.Location = new System.Drawing.Point(59, 201);
            this.panelManageStudents.Name = "panelManageStudents";
            this.panelManageStudents.Size = new System.Drawing.Size(204, 174);
            this.panelManageStudents.TabIndex = 5;
            // 
            // labelNoStudents
            // 
            this.labelNoStudents.AutoSize = true;
            this.labelNoStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoStudents.Location = new System.Drawing.Point(16, 53);
            this.labelNoStudents.Name = "labelNoStudents";
            this.labelNoStudents.Size = new System.Drawing.Size(137, 25);
            this.labelNoStudents.TabIndex = 1;
            this.labelNoStudents.Text = "Sense alumnes";
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudents.Location = new System.Drawing.Point(16, 10);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(103, 31);
            this.labelStudents.TabIndex = 0;
            this.labelStudents.Text = "Alumnes";
            // 
            // buttonManageStudents
            // 
            this.buttonManageStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonManageStudents.FlatAppearance.BorderSize = 0;
            this.buttonManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageStudents.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonManageStudents.ForeColor = System.Drawing.Color.White;
            this.buttonManageStudents.Location = new System.Drawing.Point(59, 368);
            this.buttonManageStudents.Name = "buttonManageStudents";
            this.buttonManageStudents.Size = new System.Drawing.Size(204, 46);
            this.buttonManageStudents.TabIndex = 0;
            this.buttonManageStudents.Text = "Gestionar Alumnes";
            this.buttonManageStudents.UseVisualStyleBackColor = false;
            // 
            // panelManageSchedule
            // 
            this.panelManageSchedule.BackColor = System.Drawing.Color.White;
            this.panelManageSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManageSchedule.Controls.Add(this.labelNoSchedule);
            this.panelManageSchedule.Controls.Add(this.Schedule);
            this.panelManageSchedule.Location = new System.Drawing.Point(314, 201);
            this.panelManageSchedule.Name = "panelManageSchedule";
            this.panelManageSchedule.Size = new System.Drawing.Size(204, 174);
            this.panelManageSchedule.TabIndex = 6;
            // 
            // labelNoSchedule
            // 
            this.labelNoSchedule.AutoSize = true;
            this.labelNoSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoSchedule.Location = new System.Drawing.Point(26, 53);
            this.labelNoSchedule.Name = "labelNoSchedule";
            this.labelNoSchedule.Size = new System.Drawing.Size(117, 25);
            this.labelNoSchedule.TabIndex = 2;
            this.labelNoSchedule.Text = "Sense horari";
            // 
            // Schedule
            // 
            this.Schedule.AutoSize = true;
            this.Schedule.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Schedule.Location = new System.Drawing.Point(26, 10);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(77, 31);
            this.Schedule.TabIndex = 10;
            this.Schedule.Text = "Horari";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(314, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gestionar Horari";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(305, 541);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 50);
            this.buttonCancel.TabIndex = 8;
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
            this.buttonSave.Location = new System.Drawing.Point(468, 541);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 50);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelAddGroup
            // 
            this.panelAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddGroup.Location = new System.Drawing.Point(0, 0);
            this.panelAddGroup.Name = "panelAddGroup";
            this.panelAddGroup.Size = new System.Drawing.Size(1005, 650);
            this.panelAddGroup.TabIndex = 10;
            // 
            // FormAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelManageSchedule);
            this.Controls.Add(this.buttonManageStudents);
            this.Controls.Add(this.panelManageStudents);
            this.Controls.Add(this.comboBoxMainClassGroup);
            this.Controls.Add(this.comboBoxTutorGroup);
            this.Controls.Add(this.comboBoxClassGroup);
            this.Controls.Add(this.comboBoxYearGroup);
            this.Controls.Add(this.comboBoxCicleGroup);
            this.Controls.Add(this.panelAddGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddGroup";
            this.Text = "FormAddGroup";
            this.panelManageStudents.ResumeLayout(false);
            this.panelManageStudents.PerformLayout();
            this.panelManageSchedule.ResumeLayout(false);
            this.panelManageSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxCicleGroup;
        private ComboBox comboBoxYearGroup;
        private ComboBox comboBoxClassGroup;
        private ComboBox comboBoxTutorGroup;
        private ComboBox comboBoxMainClassGroup;
        private Panel panelManageStudents;
        private Label labelNoStudents;
        private Label labelStudents;
        private Button buttonManageStudents;
        private Panel panelManageSchedule;
        private Label labelNoSchedule;
        private Label Schedule;
        private Button button1;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label1;
        private Panel panelAddGroup;
    }
}