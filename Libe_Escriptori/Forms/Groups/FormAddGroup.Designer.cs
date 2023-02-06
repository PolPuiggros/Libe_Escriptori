namespace Libe_Escriptori.Forms.Groups
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
            this.buttonManageStudents = new System.Windows.Forms.Button();
            this.panelManageSchedule = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelNoStudents = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.Label();
            this.labelNoSchedule = new System.Windows.Forms.Label();
            this.panelManageStudents.SuspendLayout();
            this.panelManageSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCicleGroup
            // 
            this.comboBoxCicleGroup.FormattingEnabled = true;
            this.comboBoxCicleGroup.Location = new System.Drawing.Point(59, 62);
            this.comboBoxCicleGroup.Name = "comboBoxCicleGroup";
            this.comboBoxCicleGroup.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCicleGroup.TabIndex = 0;
            // 
            // comboBoxYearGroup
            // 
            this.comboBoxYearGroup.FormattingEnabled = true;
            this.comboBoxYearGroup.Location = new System.Drawing.Point(254, 62);
            this.comboBoxYearGroup.Name = "comboBoxYearGroup";
            this.comboBoxYearGroup.Size = new System.Drawing.Size(121, 23);
            this.comboBoxYearGroup.TabIndex = 1;
            // 
            // comboBoxClassGroup
            // 
            this.comboBoxClassGroup.FormattingEnabled = true;
            this.comboBoxClassGroup.Location = new System.Drawing.Point(437, 62);
            this.comboBoxClassGroup.Name = "comboBoxClassGroup";
            this.comboBoxClassGroup.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClassGroup.TabIndex = 2;
            // 
            // comboBoxTutorGroup
            // 
            this.comboBoxTutorGroup.FormattingEnabled = true;
            this.comboBoxTutorGroup.Location = new System.Drawing.Point(59, 115);
            this.comboBoxTutorGroup.Name = "comboBoxTutorGroup";
            this.comboBoxTutorGroup.Size = new System.Drawing.Size(269, 23);
            this.comboBoxTutorGroup.TabIndex = 3;
            // 
            // comboBoxMainClassGroup
            // 
            this.comboBoxMainClassGroup.FormattingEnabled = true;
            this.comboBoxMainClassGroup.Location = new System.Drawing.Point(354, 115);
            this.comboBoxMainClassGroup.Name = "comboBoxMainClassGroup";
            this.comboBoxMainClassGroup.Size = new System.Drawing.Size(204, 23);
            this.comboBoxMainClassGroup.TabIndex = 4;
            // 
            // panelManageStudents
            // 
            this.panelManageStudents.Controls.Add(this.labelNoStudents);
            this.panelManageStudents.Controls.Add(this.labelStudents);
            this.panelManageStudents.Location = new System.Drawing.Point(59, 191);
            this.panelManageStudents.Name = "panelManageStudents";
            this.panelManageStudents.Size = new System.Drawing.Size(193, 123);
            this.panelManageStudents.TabIndex = 5;
            // 
            // buttonManageStudents
            // 
            this.buttonManageStudents.Location = new System.Drawing.Point(59, 314);
            this.buttonManageStudents.Name = "buttonManageStudents";
            this.buttonManageStudents.Size = new System.Drawing.Size(193, 23);
            this.buttonManageStudents.TabIndex = 0;
            this.buttonManageStudents.Text = "Gestionar Alumnes";
            this.buttonManageStudents.UseVisualStyleBackColor = true;
            // 
            // panelManageSchedule
            // 
            this.panelManageSchedule.Controls.Add(this.labelNoSchedule);
            this.panelManageSchedule.Controls.Add(this.Schedule);
            this.panelManageSchedule.Location = new System.Drawing.Point(308, 191);
            this.panelManageSchedule.Name = "panelManageSchedule";
            this.panelManageSchedule.Size = new System.Drawing.Size(193, 123);
            this.panelManageSchedule.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gestionar Horari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 541);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(483, 541);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(16, 10);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(54, 15);
            this.labelStudents.TabIndex = 0;
            this.labelStudents.Text = "Alumnes";
            // 
            // labelNoStudents
            // 
            this.labelNoStudents.AutoSize = true;
            this.labelNoStudents.Location = new System.Drawing.Point(16, 40);
            this.labelNoStudents.Name = "labelNoStudents";
            this.labelNoStudents.Size = new System.Drawing.Size(85, 15);
            this.labelNoStudents.TabIndex = 1;
            this.labelNoStudents.Text = "Sense alumnes";
            // 
            // Schedule
            // 
            this.Schedule.AutoSize = true;
            this.Schedule.Location = new System.Drawing.Point(26, 10);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(40, 15);
            this.Schedule.TabIndex = 10;
            this.Schedule.Text = "Horari";
            // 
            // labelNoSchedule
            // 
            this.labelNoSchedule.AutoSize = true;
            this.labelNoSchedule.Location = new System.Drawing.Point(26, 40);
            this.labelNoSchedule.Name = "labelNoSchedule";
            this.labelNoSchedule.Size = new System.Drawing.Size(71, 15);
            this.labelNoSchedule.TabIndex = 2;
            this.labelNoSchedule.Text = "Sense horari";
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
    }
}