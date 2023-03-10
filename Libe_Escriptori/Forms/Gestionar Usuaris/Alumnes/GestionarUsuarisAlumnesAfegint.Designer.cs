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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelAddictionalInfo = new System.Windows.Forms.Label();
            this.checkBoxAutoregister = new System.Windows.Forms.CheckBox();
            this.checkBoxRepeater = new System.Windows.Forms.CheckBox();
            this.labelGroupStudent = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
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
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSurname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurname.Location = new System.Drawing.Point(364, 64);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(533, 29);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.Text = "Cognoms";
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(87, 141);
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
            this.textBoxPhone.Location = new System.Drawing.Point(87, 222);
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
            this.labelAddictionalInfo.Location = new System.Drawing.Point(90, 303);
            this.labelAddictionalInfo.Name = "labelAddictionalInfo";
            this.labelAddictionalInfo.Size = new System.Drawing.Size(299, 25);
            this.labelAddictionalInfo.TabIndex = 5;
            this.labelAddictionalInfo.Text = "Informació addicional de l\'alumne";
            // 
            // checkBoxAutoregister
            // 
            this.checkBoxAutoregister.AutoSize = true;
            this.checkBoxAutoregister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxAutoregister.Location = new System.Drawing.Point(117, 362);
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
            this.checkBoxRepeater.Location = new System.Drawing.Point(117, 411);
            this.checkBoxRepeater.Name = "checkBoxRepeater";
            this.checkBoxRepeater.Size = new System.Drawing.Size(97, 25);
            this.checkBoxRepeater.TabIndex = 7;
            this.checkBoxRepeater.Text = "Repetidor";
            this.checkBoxRepeater.UseVisualStyleBackColor = true;
            // 
            // labelGroupStudent
            // 
            this.labelGroupStudent.AutoSize = true;
            this.labelGroupStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelGroupStudent.Location = new System.Drawing.Point(531, 303);
            this.labelGroupStudent.Name = "labelGroupStudent";
            this.labelGroupStudent.Size = new System.Drawing.Size(157, 25);
            this.labelGroupStudent.TabIndex = 8;
            this.labelGroupStudent.Text = "Grup de l\'alumne";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DataSource = this.bindingSourceGroups;
            this.comboBoxGroups.DisplayMember = "id";
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(531, 358);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(223, 29);
            this.comboBoxGroups.TabIndex = 9;
            this.comboBoxGroups.ValueMember = "id";
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(Libe_Escriptori.Models.groups);
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
            this.buttonAfegir.Text = "Afegir";
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
            // 
            // textBoxDni
            // 
            this.textBoxDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxDni.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDni.Location = new System.Drawing.Point(531, 222);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(366, 29);
            this.textBoxDni.TabIndex = 4;
            this.textBoxDni.Text = "DNI";
            this.textBoxDni.Enter += new System.EventHandler(this.textBoxDni_Enter);
            this.textBoxDni.Leave += new System.EventHandler(this.textBoxDni_Leave);
            // 
            // GestionarUsuarisAlumnesAfegint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.labelGroupStudent);
            this.Controls.Add(this.checkBoxRepeater);
            this.Controls.Add(this.checkBoxAutoregister);
            this.Controls.Add(this.labelAddictionalInfo);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarisAlumnesAfegint";
            this.Text = "GestionarUsuarisAlumnesAfegint";
            this.Load += new System.EventHandler(this.GestionarUsuarisAlumnesAfegint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label labelAddictionalInfo;
        private CheckBox checkBoxAutoregister;
        private CheckBox checkBoxRepeater;
        private Label labelGroupStudent;
        private ComboBox comboBoxGroups;
        private Button buttonAfegir;
        private Button buttonCancelar;
        private BindingSource bindingSourceGroups;
        private TextBox textBoxDni;
    }
}