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
            this.components = new System.ComponentModel.Container();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelModul = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.labelClassroom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAllProfessors = new System.Windows.Forms.ListBox();
            this.bindingSourceProfesors = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxLessonProfesors = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfesors)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelDay.Location = new System.Drawing.Point(12, 21);
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
            this.labelHour.Location = new System.Drawing.Point(96, 21);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(89, 23);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "8:40 - 9:40";
            // 
            // labelModul
            // 
            this.labelModul.AutoSize = true;
            this.labelModul.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelModul.Location = new System.Drawing.Point(240, 21);
            this.labelModul.Name = "labelModul";
            this.labelModul.Size = new System.Drawing.Size(43, 23);
            this.labelModul.TabIndex = 2;
            this.labelModul.Text = "M01";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(15, 72);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(170, 21);
            this.comboBoxClass.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(146, 245);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(137, 40);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Guardar";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // labelClassroom
            // 
            this.labelClassroom.AutoSize = true;
            this.labelClassroom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassroom.Location = new System.Drawing.Point(12, 56);
            this.labelClassroom.Name = "labelClassroom";
            this.labelClassroom.Size = new System.Drawing.Size(29, 13);
            this.labelClassroom.TabIndex = 5;
            this.labelClassroom.Text = "Aula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tots els professors";
            // 
            // listBoxAllProfessors
            // 
            this.listBoxAllProfessors.DataSource = this.bindingSourceProfesors;
            this.listBoxAllProfessors.DisplayMember = "name";
            this.listBoxAllProfessors.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxAllProfessors.FormattingEnabled = true;
            this.listBoxAllProfessors.ItemHeight = 21;
            this.listBoxAllProfessors.Location = new System.Drawing.Point(15, 123);
            this.listBoxAllProfessors.Name = "listBoxAllProfessors";
            this.listBoxAllProfessors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAllProfessors.Size = new System.Drawing.Size(170, 88);
            this.listBoxAllProfessors.TabIndex = 13;
            this.listBoxAllProfessors.ValueMember = "id";
            // 
            // bindingSourceProfesors
            // 
            this.bindingSourceProfesors.DataSource = typeof(Libe_Escriptori.Models.profesors);
            // 
            // listBoxLessonProfesors
            // 
            this.listBoxLessonProfesors.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxLessonProfesors.FormattingEnabled = true;
            this.listBoxLessonProfesors.ItemHeight = 21;
            this.listBoxLessonProfesors.Location = new System.Drawing.Point(245, 123);
            this.listBoxLessonProfesors.Name = "listBoxLessonProfesors";
            this.listBoxLessonProfesors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLessonProfesors.Size = new System.Drawing.Size(170, 88);
            this.listBoxLessonProfesors.TabIndex = 14;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(195, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Professors de la classe";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::Libe_Escriptori.Properties.Resources.close1;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(406, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(18, 18);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDeleteDepartment
            // 
            this.buttonDeleteDepartment.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteDepartment.BackgroundImage = global::Libe_Escriptori.Properties.Resources.bin;
            this.buttonDeleteDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteDepartment.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDepartment.Location = new System.Drawing.Point(398, 103);
            this.buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(15, 15);
            this.buttonDeleteDepartment.TabIndex = 21;
            this.buttonDeleteDepartment.UseVisualStyleBackColor = false;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // FormScheduleCellInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 303);
            this.Controls.Add(this.buttonDeleteDepartment);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxLessonProfesors);
            this.Controls.Add(this.listBoxAllProfessors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClassroom);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelModul);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScheduleCellInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleCellInfo";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfesors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDay;
        private Label labelHour;
        private Label labelModul;
        private ComboBox comboBoxClass;
        private Button buttonDone;
        private Label labelClassroom;
        private Label label1;
        private ListBox listBoxAllProfessors;
        private ListBox listBoxLessonProfesors;
        private Button buttonAdd;
        private BindingSource bindingSourceProfesors;
        private Label label2;
        private Button buttonClose;
        private Button buttonDeleteDepartment;
    }
}