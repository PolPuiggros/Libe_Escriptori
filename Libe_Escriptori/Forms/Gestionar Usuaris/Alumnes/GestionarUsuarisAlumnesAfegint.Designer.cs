using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    partial class GestionarUsuarisAlumnesAfegint
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname1 = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelAddictionalInfo = new System.Windows.Forms.Label();
            this.checkBoxAutoregister = new System.Windows.Forms.CheckBox();
            this.checkBoxRepeater = new System.Windows.Forms.CheckBox();
            this.labelCourseStudent = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.bindingSourceCourses = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxSurname2 = new System.Windows.Forms.TextBox();
            this.listBoxAllUnits = new System.Windows.Forms.ListBox();
            this.bindingSourceUnits = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxStudentUnits = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteUnit = new System.Windows.Forms.Button();
            this.labelAllUnits = new System.Windows.Forms.Label();
            this.labelUnitsStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxName.Location = new System.Drawing.Point(87, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 29);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Nom";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxSurname1
            // 
            this.textBoxSurname1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSurname1.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurname1.Location = new System.Drawing.Point(364, 64);
            this.textBoxSurname1.Name = "textBoxSurname1";
            this.textBoxSurname1.Size = new System.Drawing.Size(255, 29);
            this.textBoxSurname1.TabIndex = 1;
            this.textBoxSurname1.Text = "1r Cognom";
            this.textBoxSurname1.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname1.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(87, 121);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(810, 29);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPhone.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPhone.Location = new System.Drawing.Point(87, 183);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(366, 29);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.Text = "Tel";
            this.textBoxPhone.Enter += new System.EventHandler(this.textBoxPhone_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_Leave);
            // 
            // labelAddictionalInfo
            // 
            this.labelAddictionalInfo.AutoSize = true;
            this.labelAddictionalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelAddictionalInfo.Location = new System.Drawing.Point(83, 252);
            this.labelAddictionalInfo.Name = "labelAddictionalInfo";
            this.labelAddictionalInfo.Size = new System.Drawing.Size(299, 25);
            this.labelAddictionalInfo.TabIndex = 5;
            this.labelAddictionalInfo.Text = "Informació addicional de l\'alumne";
            // 
            // checkBoxAutoregister
            // 
            this.checkBoxAutoregister.AutoSize = true;
            this.checkBoxAutoregister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxAutoregister.Location = new System.Drawing.Point(444, 252);
            this.checkBoxAutoregister.Name = "checkBoxAutoregister";
            this.checkBoxAutoregister.Size = new System.Drawing.Size(115, 25);
            this.checkBoxAutoregister.TabIndex = 6;
            this.checkBoxAutoregister.Text = "Autoregister";
            this.checkBoxAutoregister.UseVisualStyleBackColor = true;
            // 
            // checkBoxRepeater
            // 
            this.checkBoxRepeater.AutoSize = true;
            this.checkBoxRepeater.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxRepeater.Location = new System.Drawing.Point(643, 252);
            this.checkBoxRepeater.Name = "checkBoxRepeater";
            this.checkBoxRepeater.Size = new System.Drawing.Size(97, 25);
            this.checkBoxRepeater.TabIndex = 7;
            this.checkBoxRepeater.Text = "Repetidor";
            this.checkBoxRepeater.UseVisualStyleBackColor = true;
            // 
            // labelCourseStudent
            // 
            this.labelCourseStudent.AutoSize = true;
            this.labelCourseStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelCourseStudent.Location = new System.Drawing.Point(87, 313);
            this.labelCourseStudent.Name = "labelCourseStudent";
            this.labelCourseStudent.Size = new System.Drawing.Size(153, 25);
            this.labelCourseStudent.TabIndex = 8;
            this.labelCourseStudent.Text = "Curs de l\'alumne";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DataSource = this.bindingSourceCourses;
            this.comboBoxCourse.DisplayMember = "abreviation";
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(246, 309);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(223, 29);
            this.comboBoxCourse.TabIndex = 9;
            this.comboBoxCourse.ValueMember = "id";
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // bindingSourceCourses
            // 
            this.bindingSourceCourses.DataSource = typeof(Libe_Escriptori.Models.courses);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.buttonAfegir.FlatAppearance.BorderSize = 0;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.buttonAfegir.ForeColor = System.Drawing.Color.White;
            this.buttonAfegir.Location = new System.Drawing.Point(513, 527);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(145, 45);
            this.buttonAfegir.TabIndex = 16;
            this.buttonAfegir.Text = "Guardar";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.buttonCancelar.Location = new System.Drawing.Point(335, 527);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(145, 45);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxDni
            // 
            this.textBoxDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxDni.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDni.Location = new System.Drawing.Point(531, 183);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(366, 29);
            this.textBoxDni.TabIndex = 4;
            this.textBoxDni.Text = "DNI";
            this.textBoxDni.Enter += new System.EventHandler(this.textBoxDni_Enter);
            this.textBoxDni.Leave += new System.EventHandler(this.textBoxDni_Leave);
            // 
            // textBoxSurname2
            // 
            this.textBoxSurname2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSurname2.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurname2.Location = new System.Drawing.Point(642, 64);
            this.textBoxSurname2.Name = "textBoxSurname2";
            this.textBoxSurname2.Size = new System.Drawing.Size(255, 29);
            this.textBoxSurname2.TabIndex = 17;
            this.textBoxSurname2.Text = "2n Cognom";
            this.textBoxSurname2.Enter += new System.EventHandler(this.textBoxSurname2_Enter);
            this.textBoxSurname2.Leave += new System.EventHandler(this.textBoxSurname2_Leave);
            // 
            // listBoxAllUnits
            // 
            this.listBoxAllUnits.DataSource = this.bindingSourceUnits;
            this.listBoxAllUnits.DisplayMember = "id";
            this.listBoxAllUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAllUnits.FormattingEnabled = true;
            this.listBoxAllUnits.ItemHeight = 21;
            this.listBoxAllUnits.Location = new System.Drawing.Point(92, 381);
            this.listBoxAllUnits.Name = "listBoxAllUnits";
            this.listBoxAllUnits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAllUnits.Size = new System.Drawing.Size(377, 109);
            this.listBoxAllUnits.TabIndex = 18;
            this.listBoxAllUnits.ValueMember = "id";
            // 
            // bindingSourceUnits
            // 
            this.bindingSourceUnits.DataSource = typeof(Libe_Escriptori.Models.units);
            // 
            // listBoxStudentUnits
            // 
            this.listBoxStudentUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStudentUnits.FormattingEnabled = true;
            this.listBoxStudentUnits.ItemHeight = 21;
            this.listBoxStudentUnits.Location = new System.Drawing.Point(531, 381);
            this.listBoxStudentUnits.Name = "listBoxStudentUnits";
            this.listBoxStudentUnits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStudentUnits.Size = new System.Drawing.Size(366, 109);
            this.listBoxStudentUnits.TabIndex = 19;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(480, 423);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDeleteUnit
            // 
            this.buttonDeleteUnit.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteUnit.BackgroundImage = global::Libe_Escriptori.Properties.Resources.bin;
            this.buttonDeleteUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUnit.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUnit.Location = new System.Drawing.Point(866, 355);
            this.buttonDeleteUnit.Name = "buttonDeleteUnit";
            this.buttonDeleteUnit.Size = new System.Drawing.Size(21, 20);
            this.buttonDeleteUnit.TabIndex = 21;
            this.buttonDeleteUnit.UseVisualStyleBackColor = false;
            this.buttonDeleteUnit.Click += new System.EventHandler(this.buttonDeleteUnit_Click);
            // 
            // labelAllUnits
            // 
            this.labelAllUnits.AutoSize = true;
            this.labelAllUnits.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelAllUnits.Location = new System.Drawing.Point(88, 355);
            this.labelAllUnits.Name = "labelAllUnits";
            this.labelAllUnits.Size = new System.Drawing.Size(108, 23);
            this.labelAllUnits.TabIndex = 23;
            this.labelAllUnits.Text = "Totes les UFS";
            // 
            // labelUnitsStudent
            // 
            this.labelUnitsStudent.AutoSize = true;
            this.labelUnitsStudent.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelUnitsStudent.Location = new System.Drawing.Point(532, 354);
            this.labelUnitsStudent.Name = "labelUnitsStudent";
            this.labelUnitsStudent.Size = new System.Drawing.Size(133, 23);
            this.labelUnitsStudent.TabIndex = 22;
            this.labelUnitsStudent.Text = "UFS de l\'alumne";
            // 
            // GestionarUsuarisAlumnesAfegint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.labelAllUnits);
            this.Controls.Add(this.labelUnitsStudent);
            this.Controls.Add(this.buttonDeleteUnit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxStudentUnits);
            this.Controls.Add(this.listBoxAllUnits);
            this.Controls.Add(this.textBoxSurname2);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelCourseStudent);
            this.Controls.Add(this.checkBoxRepeater);
            this.Controls.Add(this.checkBoxAutoregister);
            this.Controls.Add(this.labelAddictionalInfo);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurname1);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisAlumnesAfegint";
            this.Text = "GestionarUsuarisAlumnesAfegint";
            this.Load += new System.EventHandler(this.GestionarUsuarisAlumnesAfegint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname1;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label labelAddictionalInfo;
        private CheckBox checkBoxAutoregister;
        private CheckBox checkBoxRepeater;
        private Label labelCourseStudent;
        private ComboBox comboBoxCourse;
        private Button buttonAfegir;
        private Button buttonCancelar;
        private BindingSource bindingSourceCourses;
        private TextBox textBoxDni;
        private TextBox textBoxSurname2;
        private ListBox listBoxAllUnits;
        private ListBox listBoxStudentUnits;
        private BindingSource bindingSourceUnits;
        private Button buttonAdd;
        private Button buttonDeleteUnit;
        private Label labelAllUnits;
        private Label labelUnitsStudent;
    }
}