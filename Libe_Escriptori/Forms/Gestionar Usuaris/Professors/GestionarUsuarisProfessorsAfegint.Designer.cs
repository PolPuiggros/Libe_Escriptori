namespace Libe_Escriptori.Forms.Gestionar_Usuaris.Professors
{
    partial class GestionarUsuarisProfessorsAfegint
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
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDepartmentTeacher = new System.Windows.Forms.Label();
            this.listBoxAllDepartments = new System.Windows.Forms.ListBox();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxteacherDespartments = new System.Windows.Forms.ListBox();
            this.labelAllDepartments = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDni
            // 
            this.textBoxDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxDni.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDni.Location = new System.Drawing.Point(543, 237);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(366, 29);
            this.textBoxDni.TabIndex = 9;
            this.textBoxDni.Text = " DNI";
            this.textBoxDni.Enter += new System.EventHandler(this.textBoxDni_Enter);
            this.textBoxDni.Leave += new System.EventHandler(this.textBoxDni_Leave);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPhone.Location = new System.Drawing.Point(99, 237);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(366, 29);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.Text = " Tel";
            this.textBoxPhone.Enter += new System.EventHandler(this.textBoxPhone_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(99, 156);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(810, 29);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = " Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurname.Location = new System.Drawing.Point(376, 79);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(533, 29);
            this.textBoxSurname.TabIndex = 6;
            this.textBoxSurname.Text = " Cognoms";
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxName.Location = new System.Drawing.Point(99, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 29);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = " Nom";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // labelDepartmentTeacher
            // 
            this.labelDepartmentTeacher.AutoSize = true;
            this.labelDepartmentTeacher.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDepartmentTeacher.Location = new System.Drawing.Point(543, 315);
            this.labelDepartmentTeacher.Name = "labelDepartmentTeacher";
            this.labelDepartmentTeacher.Size = new System.Drawing.Size(221, 23);
            this.labelDepartmentTeacher.TabIndex = 11;
            this.labelDepartmentTeacher.Text = "Departaments del professor";
            // 
            // listBoxAllDepartments
            // 
            this.listBoxAllDepartments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAllDepartments.FormattingEnabled = true;
            this.listBoxAllDepartments.ItemHeight = 21;
            this.listBoxAllDepartments.Items.AddRange(new object[] {
            "Informàtica",
            "Jardineria",
            "Artistic"});
            this.listBoxAllDepartments.Location = new System.Drawing.Point(99, 346);
            this.listBoxAllDepartments.Name = "listBoxAllDepartments";
            this.listBoxAllDepartments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAllDepartments.Size = new System.Drawing.Size(366, 151);
            this.listBoxAllDepartments.TabIndex = 12;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonAfegir.FlatAppearance.BorderSize = 0;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAfegir.ForeColor = System.Drawing.Color.White;
            this.buttonAfegir.Location = new System.Drawing.Point(519, 540);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(145, 45);
            this.buttonAfegir.TabIndex = 14;
            this.buttonAfegir.Text = "Afegir";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(341, 540);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(145, 45);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // listBoxteacherDespartments
            // 
            this.listBoxteacherDespartments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxteacherDespartments.FormattingEnabled = true;
            this.listBoxteacherDespartments.ItemHeight = 21;
            this.listBoxteacherDespartments.Location = new System.Drawing.Point(543, 346);
            this.listBoxteacherDespartments.Name = "listBoxteacherDespartments";
            this.listBoxteacherDespartments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxteacherDespartments.Size = new System.Drawing.Size(366, 151);
            this.listBoxteacherDespartments.TabIndex = 15;
            // 
            // labelAllDepartments
            // 
            this.labelAllDepartments.AutoSize = true;
            this.labelAllDepartments.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAllDepartments.Location = new System.Drawing.Point(99, 316);
            this.labelAllDepartments.Name = "labelAllDepartments";
            this.labelAllDepartments.Size = new System.Drawing.Size(176, 23);
            this.labelAllDepartments.TabIndex = 16;
            this.labelAllDepartments.Text = "Tots els departaments";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(483, 414);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDeleteDepartment
            // 
            this.buttonDeleteDepartment.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteDepartment.BackgroundImage = global::Libe_Escriptori.Properties.Resources.bin;
            this.buttonDeleteDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteDepartment.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDepartment.Location = new System.Drawing.Point(885, 318);
            this.buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(24, 23);
            this.buttonDeleteDepartment.TabIndex = 18;
            this.buttonDeleteDepartment.UseVisualStyleBackColor = false;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // GestionarUsuarisProfessorsAfegint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.buttonDeleteDepartment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAllDepartments);
            this.Controls.Add(this.listBoxteacherDespartments);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listBoxAllDepartments);
            this.Controls.Add(this.labelDepartmentTeacher);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisProfessorsAfegint";
            this.Text = "GestionarUsuarisProfessorsAfegint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDni;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label labelDepartmentTeacher;
        private ListBox listBoxAllDepartments;
        private Button buttonAfegir;
        private Button buttonCancel;
        private ListBox listBoxteacherDespartments;
        private Label labelAllDepartments;
        private Button buttonAdd;
        private Button buttonDeleteDepartment;
    }
}