namespace Libe_Escriptori
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonInici = new System.Windows.Forms.Button();
            this.buttonGestionarUsuaris = new System.Windows.Forms.Button();
            this.panelUsuaris = new System.Windows.Forms.Panel();
            this.buttonGestionarAlumnes = new System.Windows.Forms.Button();
            this.buttonGestionarProfessors = new System.Windows.Forms.Button();
            this.buttonGestionarCursos = new System.Windows.Forms.Button();
            this.buttonGestionarGrups = new System.Windows.Forms.Button();
            this.buttonCentre = new System.Windows.Forms.Button();
            this.panelCentreSubmenu = new System.Windows.Forms.Panel();
            this.buttonInformacioCentre = new System.Windows.Forms.Button();
            this.buttonDepartamentsCentre = new System.Windows.Forms.Button();
            this.buttonCalendariCentre = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelUsuaris.SuspendLayout();
            this.panelCentreSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panelCentreSubmenu);
            this.panelMenu.Controls.Add(this.buttonCentre);
            this.panelMenu.Controls.Add(this.buttonGestionarGrups);
            this.panelMenu.Controls.Add(this.buttonGestionarCursos);
            this.panelMenu.Controls.Add(this.panelUsuaris);
            this.panelMenu.Controls.Add(this.buttonGestionarUsuaris);
            this.panelMenu.Controls.Add(this.buttonInici);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(275, 720);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(275, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonInici
            // 
            this.buttonInici.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInici.FlatAppearance.BorderSize = 0;
            this.buttonInici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInici.Location = new System.Drawing.Point(0, 92);
            this.buttonInici.Name = "buttonInici";
            this.buttonInici.Size = new System.Drawing.Size(275, 48);
            this.buttonInici.TabIndex = 1;
            this.buttonInici.Text = "Inici";
            this.buttonInici.UseVisualStyleBackColor = true;
            // 
            // buttonGestionarUsuaris
            // 
            this.buttonGestionarUsuaris.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarUsuaris.FlatAppearance.BorderSize = 0;
            this.buttonGestionarUsuaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarUsuaris.Location = new System.Drawing.Point(0, 140);
            this.buttonGestionarUsuaris.Name = "buttonGestionarUsuaris";
            this.buttonGestionarUsuaris.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarUsuaris.TabIndex = 2;
            this.buttonGestionarUsuaris.Text = "Gestionar usuaris";
            this.buttonGestionarUsuaris.UseVisualStyleBackColor = true;
            // 
            // panelUsuaris
            // 
            this.panelUsuaris.Controls.Add(this.buttonGestionarProfessors);
            this.panelUsuaris.Controls.Add(this.buttonGestionarAlumnes);
            this.panelUsuaris.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuaris.Location = new System.Drawing.Point(0, 188);
            this.panelUsuaris.Name = "panelUsuaris";
            this.panelUsuaris.Size = new System.Drawing.Size(275, 97);
            this.panelUsuaris.TabIndex = 3;
            // 
            // buttonGestionarAlumnes
            // 
            this.buttonGestionarAlumnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonGestionarAlumnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarAlumnes.FlatAppearance.BorderSize = 0;
            this.buttonGestionarAlumnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarAlumnes.Location = new System.Drawing.Point(0, 0);
            this.buttonGestionarAlumnes.Name = "buttonGestionarAlumnes";
            this.buttonGestionarAlumnes.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarAlumnes.TabIndex = 3;
            this.buttonGestionarAlumnes.Text = "Alumnes";
            this.buttonGestionarAlumnes.UseVisualStyleBackColor = false;
            // 
            // buttonGestionarProfessors
            // 
            this.buttonGestionarProfessors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonGestionarProfessors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarProfessors.FlatAppearance.BorderSize = 0;
            this.buttonGestionarProfessors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarProfessors.Location = new System.Drawing.Point(0, 48);
            this.buttonGestionarProfessors.Name = "buttonGestionarProfessors";
            this.buttonGestionarProfessors.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarProfessors.TabIndex = 4;
            this.buttonGestionarProfessors.Text = "Professors";
            this.buttonGestionarProfessors.UseVisualStyleBackColor = false;
            // 
            // buttonGestionarCursos
            // 
            this.buttonGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarCursos.FlatAppearance.BorderSize = 0;
            this.buttonGestionarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarCursos.Location = new System.Drawing.Point(0, 285);
            this.buttonGestionarCursos.Name = "buttonGestionarCursos";
            this.buttonGestionarCursos.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarCursos.TabIndex = 4;
            this.buttonGestionarCursos.Text = "Gestionar cursos";
            this.buttonGestionarCursos.UseVisualStyleBackColor = true;
            // 
            // buttonGestionarGrups
            // 
            this.buttonGestionarGrups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarGrups.FlatAppearance.BorderSize = 0;
            this.buttonGestionarGrups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarGrups.Location = new System.Drawing.Point(0, 333);
            this.buttonGestionarGrups.Name = "buttonGestionarGrups";
            this.buttonGestionarGrups.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarGrups.TabIndex = 5;
            this.buttonGestionarGrups.Text = "Gestionar grups";
            this.buttonGestionarGrups.UseVisualStyleBackColor = true;
            // 
            // buttonCentre
            // 
            this.buttonCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCentre.FlatAppearance.BorderSize = 0;
            this.buttonCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCentre.Location = new System.Drawing.Point(0, 381);
            this.buttonCentre.Name = "buttonCentre";
            this.buttonCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonCentre.TabIndex = 6;
            this.buttonCentre.Text = "Centre";
            this.buttonCentre.UseVisualStyleBackColor = true;
            // 
            // panelCentreSubmenu
            // 
            this.panelCentreSubmenu.Controls.Add(this.buttonCalendariCentre);
            this.panelCentreSubmenu.Controls.Add(this.buttonDepartamentsCentre);
            this.panelCentreSubmenu.Controls.Add(this.buttonInformacioCentre);
            this.panelCentreSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCentreSubmenu.Location = new System.Drawing.Point(0, 429);
            this.panelCentreSubmenu.Name = "panelCentreSubmenu";
            this.panelCentreSubmenu.Size = new System.Drawing.Size(275, 147);
            this.panelCentreSubmenu.TabIndex = 7;
            // 
            // buttonInformacioCentre
            // 
            this.buttonInformacioCentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInformacioCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInformacioCentre.FlatAppearance.BorderSize = 0;
            this.buttonInformacioCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacioCentre.Location = new System.Drawing.Point(0, 0);
            this.buttonInformacioCentre.Name = "buttonInformacioCentre";
            this.buttonInformacioCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonInformacioCentre.TabIndex = 7;
            this.buttonInformacioCentre.Text = "Informació";
            this.buttonInformacioCentre.UseVisualStyleBackColor = false;
            // 
            // buttonDepartamentsCentre
            // 
            this.buttonDepartamentsCentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDepartamentsCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDepartamentsCentre.FlatAppearance.BorderSize = 0;
            this.buttonDepartamentsCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartamentsCentre.Location = new System.Drawing.Point(0, 48);
            this.buttonDepartamentsCentre.Name = "buttonDepartamentsCentre";
            this.buttonDepartamentsCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonDepartamentsCentre.TabIndex = 8;
            this.buttonDepartamentsCentre.Text = "Departaments";
            this.buttonDepartamentsCentre.UseVisualStyleBackColor = false;
            // 
            // buttonCalendariCentre
            // 
            this.buttonCalendariCentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCalendariCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCalendariCentre.FlatAppearance.BorderSize = 0;
            this.buttonCalendariCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendariCentre.Location = new System.Drawing.Point(0, 96);
            this.buttonCalendariCentre.Name = "buttonCalendariCentre";
            this.buttonCalendariCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonCalendariCentre.TabIndex = 9;
            this.buttonCalendariCentre.Text = "Calendari";
            this.buttonCalendariCentre.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelUsuaris.ResumeLayout(false);
            this.panelCentreSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelCentreSubmenu;
        private Button buttonCalendariCentre;
        private Button buttonDepartamentsCentre;
        private Button buttonInformacioCentre;
        private Button buttonCentre;
        private Button buttonGestionarGrups;
        private Button buttonGestionarCursos;
        private Panel panelUsuaris;
        private Button buttonGestionarProfessors;
        private Button buttonGestionarAlumnes;
        private Button buttonGestionarUsuaris;
        private Button buttonInici;
    }
}