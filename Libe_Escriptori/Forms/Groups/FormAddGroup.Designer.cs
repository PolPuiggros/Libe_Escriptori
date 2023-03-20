using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddGroup = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGestionarHorari = new System.Windows.Forms.Button();
            this.panelManageSchedule = new System.Windows.Forms.Panel();
            this.labelNoSchedule = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.Label();
            this.buttonManageStudents = new System.Windows.Forms.Button();
            this.panelManageStudents = new System.Windows.Forms.Panel();
            this.labelNoStudents = new System.Windows.Forms.Label();
            this.labelStudents = new System.Windows.Forms.Label();
            this.comboBoxMainClassGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxTutorGroup = new System.Windows.Forms.ComboBox();
            this.profesorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxClassGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxYearGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxCicleGroup = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelAddGroup.SuspendLayout();
            this.panelManageSchedule.SuspendLayout();
            this.panelManageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAddGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 650);
            this.panel1.TabIndex = 0;
            // 
            // panelAddGroup
            // 
            this.panelAddGroup.Controls.Add(this.buttonSave);
            this.panelAddGroup.Controls.Add(this.buttonCancel);
            this.panelAddGroup.Controls.Add(this.buttonGestionarHorari);
            this.panelAddGroup.Controls.Add(this.panelManageSchedule);
            this.panelAddGroup.Controls.Add(this.buttonManageStudents);
            this.panelAddGroup.Controls.Add(this.panelManageStudents);
            this.panelAddGroup.Controls.Add(this.comboBoxMainClassGroup);
            this.panelAddGroup.Controls.Add(this.comboBoxTutorGroup);
            this.panelAddGroup.Controls.Add(this.comboBoxClassGroup);
            this.panelAddGroup.Controls.Add(this.comboBoxYearGroup);
            this.panelAddGroup.Controls.Add(this.comboBoxCicleGroup);
            this.panelAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddGroup.Location = new System.Drawing.Point(0, 0);
            this.panelAddGroup.Margin = new System.Windows.Forms.Padding(4);
            this.panelAddGroup.Name = "panelAddGroup";
            this.panelAddGroup.Size = new System.Drawing.Size(1005, 650);
            this.panelAddGroup.TabIndex = 1;
            this.panelAddGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddGroup_Paint);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(468, 541);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 40);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonCancel.Location = new System.Drawing.Point(305, 541);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 40);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonGestionarHorari
            // 
            this.buttonGestionarHorari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonGestionarHorari.FlatAppearance.BorderSize = 0;
            this.buttonGestionarHorari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarHorari.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonGestionarHorari.ForeColor = System.Drawing.Color.White;
            this.buttonGestionarHorari.Location = new System.Drawing.Point(314, 368);
            this.buttonGestionarHorari.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestionarHorari.Name = "buttonGestionarHorari";
            this.buttonGestionarHorari.Size = new System.Drawing.Size(233, 49);
            this.buttonGestionarHorari.TabIndex = 19;
            this.buttonGestionarHorari.Text = "Gestionar Horari";
            this.buttonGestionarHorari.UseVisualStyleBackColor = false;
            this.buttonGestionarHorari.Click += new System.EventHandler(this.buttonGestionarHorari_Click);
            // 
            // panelManageSchedule
            // 
            this.panelManageSchedule.BackColor = System.Drawing.Color.White;
            this.panelManageSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManageSchedule.Controls.Add(this.labelNoSchedule);
            this.panelManageSchedule.Controls.Add(this.Schedule);
            this.panelManageSchedule.Location = new System.Drawing.Point(314, 201);
            this.panelManageSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.panelManageSchedule.Name = "panelManageSchedule";
            this.panelManageSchedule.Size = new System.Drawing.Size(233, 185);
            this.panelManageSchedule.TabIndex = 18;
            // 
            // labelNoSchedule
            // 
            this.labelNoSchedule.AutoSize = true;
            this.labelNoSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelNoSchedule.Location = new System.Drawing.Point(29, 57);
            this.labelNoSchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoSchedule.Name = "labelNoSchedule";
            this.labelNoSchedule.Size = new System.Drawing.Size(146, 32);
            this.labelNoSchedule.TabIndex = 2;
            this.labelNoSchedule.Text = "Sense horari";
            // 
            // Schedule
            // 
            this.Schedule.AutoSize = true;
            this.Schedule.Font = new System.Drawing.Font("Segoe UI", 17.25F);
            this.Schedule.Location = new System.Drawing.Point(29, 11);
            this.Schedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(97, 40);
            this.Schedule.TabIndex = 10;
            this.Schedule.Text = "Horari";
            // 
            // buttonManageStudents
            // 
            this.buttonManageStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonManageStudents.FlatAppearance.BorderSize = 0;
            this.buttonManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageStudents.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonManageStudents.ForeColor = System.Drawing.Color.White;
            this.buttonManageStudents.Location = new System.Drawing.Point(59, 368);
            this.buttonManageStudents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonManageStudents.Name = "buttonManageStudents";
            this.buttonManageStudents.Size = new System.Drawing.Size(233, 49);
            this.buttonManageStudents.TabIndex = 11;
            this.buttonManageStudents.Text = "Gestionar Alumnes";
            this.buttonManageStudents.UseVisualStyleBackColor = false;
            this.buttonManageStudents.Click += new System.EventHandler(this.buttonManageStudents_Click_1);
            // 
            // panelManageStudents
            // 
            this.panelManageStudents.BackColor = System.Drawing.Color.White;
            this.panelManageStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManageStudents.Controls.Add(this.labelNoStudents);
            this.panelManageStudents.Controls.Add(this.labelStudents);
            this.panelManageStudents.Location = new System.Drawing.Point(59, 201);
            this.panelManageStudents.Margin = new System.Windows.Forms.Padding(4);
            this.panelManageStudents.Name = "panelManageStudents";
            this.panelManageStudents.Size = new System.Drawing.Size(233, 185);
            this.panelManageStudents.TabIndex = 17;
            // 
            // labelNoStudents
            // 
            this.labelNoStudents.AutoSize = true;
            this.labelNoStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelNoStudents.Location = new System.Drawing.Point(19, 57);
            this.labelNoStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoStudents.Name = "labelNoStudents";
            this.labelNoStudents.Size = new System.Drawing.Size(174, 32);
            this.labelNoStudents.TabIndex = 1;
            this.labelNoStudents.Text = "Sense alumnes";
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Segoe UI", 17.25F);
            this.labelStudents.Location = new System.Drawing.Point(19, 11);
            this.labelStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(127, 40);
            this.labelStudents.TabIndex = 0;
            this.labelStudents.Text = "Alumnes";
            // 
            // comboBoxMainClassGroup
            // 
            this.comboBoxMainClassGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxMainClassGroup.FormattingEnabled = true;
            this.comboBoxMainClassGroup.Location = new System.Drawing.Point(380, 115);
            this.comboBoxMainClassGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMainClassGroup.Name = "comboBoxMainClassGroup";
            this.comboBoxMainClassGroup.Size = new System.Drawing.Size(250, 36);
            this.comboBoxMainClassGroup.TabIndex = 16;
            this.comboBoxMainClassGroup.Text = "Aula Principal";
            // 
            // comboBoxTutorGroup
            // 
            this.comboBoxTutorGroup.DataSource = this.profesorsBindingSource;
            this.comboBoxTutorGroup.DisplayMember = "name";
            this.comboBoxTutorGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxTutorGroup.FormattingEnabled = true;
            this.comboBoxTutorGroup.Location = new System.Drawing.Point(59, 115);
            this.comboBoxTutorGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTutorGroup.Name = "comboBoxTutorGroup";
            this.comboBoxTutorGroup.Size = new System.Drawing.Size(288, 36);
            this.comboBoxTutorGroup.TabIndex = 15;
            this.comboBoxTutorGroup.ValueMember = "id";
            // 
            // profesorsBindingSource
            // 
            this.profesorsBindingSource.DataSource = typeof(Libe_Escriptori.Models.profesors);
            // 
            // comboBoxClassGroup
            // 
            this.comboBoxClassGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxClassGroup.FormattingEnabled = true;
            this.comboBoxClassGroup.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBoxClassGroup.Location = new System.Drawing.Point(437, 62);
            this.comboBoxClassGroup.Name = "comboBoxClassGroup";
            this.comboBoxClassGroup.Size = new System.Drawing.Size(193, 36);
            this.comboBoxClassGroup.TabIndex = 14;
            this.comboBoxClassGroup.Text = "Classe";
            // 
            // comboBoxYearGroup
            // 
            this.comboBoxYearGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxYearGroup.FormattingEnabled = true;
            this.comboBoxYearGroup.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxYearGroup.Location = new System.Drawing.Point(254, 62);
            this.comboBoxYearGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxYearGroup.Name = "comboBoxYearGroup";
            this.comboBoxYearGroup.Size = new System.Drawing.Size(162, 36);
            this.comboBoxYearGroup.TabIndex = 13;
            this.comboBoxYearGroup.Text = "Any";
            // 
            // comboBoxCicleGroup
            // 
            this.comboBoxCicleGroup.DataSource = this.coursesBindingSource;
            this.comboBoxCicleGroup.DisplayMember = "abreviation";
            this.comboBoxCicleGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCicleGroup.FormattingEnabled = true;
            this.comboBoxCicleGroup.Location = new System.Drawing.Point(59, 62);
            this.comboBoxCicleGroup.MinimumSize = new System.Drawing.Size(189, 0);
            this.comboBoxCicleGroup.Name = "comboBoxCicleGroup";
            this.comboBoxCicleGroup.Size = new System.Drawing.Size(189, 36);
            this.comboBoxCicleGroup.TabIndex = 12;
            this.comboBoxCicleGroup.ValueMember = "id";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataSource = typeof(Libe_Escriptori.Models.courses);
            this.coursesBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(Libe_Escriptori.Models.groups);
            // 
            // FormAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddGroup";
            this.Text = "FormAddGroup";
            this.Load += new System.EventHandler(this.FormAddGroup_Load);
            this.panel1.ResumeLayout(false);
            this.panelAddGroup.ResumeLayout(false);
            this.panelManageSchedule.ResumeLayout(false);
            this.panelManageSchedule.PerformLayout();
            this.panelManageStudents.ResumeLayout(false);
            this.panelManageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panelAddGroup;
        private Button buttonSave;
        private Button buttonCancel;
        private Button buttonGestionarHorari;
        private Panel panelManageSchedule;
        private Label labelNoSchedule;
        private Label Schedule;
        private Button buttonManageStudents;
        private Panel panelManageStudents;
        private Label labelNoStudents;
        private Label labelStudents;
        private ComboBox comboBoxMainClassGroup;
        private ComboBox comboBoxTutorGroup;
        private ComboBox comboBoxClassGroup;
        private ComboBox comboBoxYearGroup;
        private ComboBox comboBoxCicleGroup;
        private BindingSource groupsBindingSource;
        private BindingSource coursesBindingSource;
        private BindingSource profesorsBindingSource;
    }
}