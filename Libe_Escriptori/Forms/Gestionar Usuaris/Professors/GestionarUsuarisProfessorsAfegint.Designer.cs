using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurname1 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDepartmentTeacher = new System.Windows.Forms.Label();
            this.listBoxAllDepartments = new System.Windows.Forms.ListBox();
            this.bindingSourceDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxteacherDespartments = new System.Windows.Forms.ListBox();
            this.labelAllDepartments = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            this.textBoxSurname2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPhone.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPhone.Location = new System.Drawing.Point(99, 237);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(810, 29);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.Text = " Tel";
            this.textBoxPhone.Enter += new System.EventHandler(this.textBoxPhone_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(99, 156);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(810, 29);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = " Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxSurname1
            // 
            this.textBoxSurname1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSurname1.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurname1.Location = new System.Drawing.Point(376, 79);
            this.textBoxSurname1.Name = "textBoxSurname1";
            this.textBoxSurname1.Size = new System.Drawing.Size(247, 29);
            this.textBoxSurname1.TabIndex = 6;
            this.textBoxSurname1.Text = " 1r Cognom";
            this.textBoxSurname1.Enter += new System.EventHandler(this.textBoxSurname1_Enter);
            this.textBoxSurname1.Leave += new System.EventHandler(this.textBoxSurname1_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
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
            this.labelDepartmentTeacher.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelDepartmentTeacher.Location = new System.Drawing.Point(543, 315);
            this.labelDepartmentTeacher.Name = "labelDepartmentTeacher";
            this.labelDepartmentTeacher.Size = new System.Drawing.Size(221, 23);
            this.labelDepartmentTeacher.TabIndex = 11;
            this.labelDepartmentTeacher.Text = "Departaments del professor";
            // 
            // listBoxAllDepartments
            // 
            this.listBoxAllDepartments.DataSource = this.bindingSourceDepartments;
            this.listBoxAllDepartments.DisplayMember = "name";
            this.listBoxAllDepartments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxAllDepartments.FormattingEnabled = true;
            this.listBoxAllDepartments.ItemHeight = 21;
            this.listBoxAllDepartments.Location = new System.Drawing.Point(99, 346);
            this.listBoxAllDepartments.Name = "listBoxAllDepartments";
            this.listBoxAllDepartments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAllDepartments.Size = new System.Drawing.Size(366, 151);
            this.listBoxAllDepartments.TabIndex = 12;
            this.listBoxAllDepartments.ValueMember = "id";
            // 
            // bindingSourceDepartments
            // 
            this.bindingSourceDepartments.DataSource = typeof(Libe_Escriptori.Models.departments);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonAfegir.FlatAppearance.BorderSize = 0;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.buttonAfegir.ForeColor = System.Drawing.Color.White;
            this.buttonAfegir.Location = new System.Drawing.Point(519, 540);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(145, 45);
            this.buttonAfegir.TabIndex = 14;
            this.buttonAfegir.Text = "Guardar";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.buttonCancel.Location = new System.Drawing.Point(341, 540);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(145, 45);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxteacherDespartments
            // 
            this.listBoxteacherDespartments.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            this.labelAllDepartments.Font = new System.Drawing.Font("Segoe UI", 12.75F);
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
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(21, 20);
            this.buttonDeleteDepartment.TabIndex = 18;
            this.buttonDeleteDepartment.UseVisualStyleBackColor = false;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // textBoxSurname2
            // 
            this.textBoxSurname2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSurname2.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurname2.Location = new System.Drawing.Point(662, 79);
            this.textBoxSurname2.Name = "textBoxSurname2";
            this.textBoxSurname2.Size = new System.Drawing.Size(247, 29);
            this.textBoxSurname2.TabIndex = 19;
            this.textBoxSurname2.Text = " 2n Cognom";
            this.textBoxSurname2.Enter += new System.EventHandler(this.textBoxSurname2_Enter);
            this.textBoxSurname2.Leave += new System.EventHandler(this.textBoxSurname2_Leave);
            // 
            // GestionarUsuarisProfessorsAfegint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.textBoxSurname2);
            this.Controls.Add(this.buttonDeleteDepartment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAllDepartments);
            this.Controls.Add(this.listBoxteacherDespartments);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listBoxAllDepartments);
            this.Controls.Add(this.labelDepartmentTeacher);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurname1);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisProfessorsAfegint";
            this.Text = "GestionarUsuarisProfessorsAfegint";
            this.Load += new System.EventHandler(this.GestionarUsuarisProfessorsAfegint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname1;
        private TextBox textBoxName;
        private Label labelDepartmentTeacher;
        private ListBox listBoxAllDepartments;
        private Button buttonAfegir;
        private Button buttonCancel;
        private ListBox listBoxteacherDespartments;
        private Label labelAllDepartments;
        private Button buttonAdd;
        private Button buttonDeleteDepartment;
        private BindingSource bindingSourceDepartments;
        private TextBox textBoxSurname2;
    }
}