using System.Windows.Forms;

namespace Libe_Escriptori
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNomCentre = new System.Windows.Forms.Label();
            this.panelUsuaris = new System.Windows.Forms.Panel();
            this.buttonGestionarProfessors = new System.Windows.Forms.Button();
            this.buttonGestionarAlumnes = new System.Windows.Forms.Button();
            this.panelCentreSubmenu = new System.Windows.Forms.Panel();
            this.buttonCalendariCentre = new System.Windows.Forms.Button();
            this.buttonDepartamentsCentre = new System.Windows.Forms.Button();
            this.buttonZonesValidables = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonCentre = new System.Windows.Forms.Button();
            this.buttonGestionarGrups = new System.Windows.Forms.Button();
            this.buttonGestionarCursos = new System.Windows.Forms.Button();
            this.buttonGestionarUsuaris = new System.Windows.Forms.Button();
            this.buttonInici = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRuta = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonInbox = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTot.SuspendLayout();
            this.panelUsuaris.SuspendLayout();
            this.panelCentreSubmenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(275, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 650);
            this.panel1.TabIndex = 2;
            // 
            // panelTot
            // 
            this.panelTot.Controls.Add(this.label3);
            this.panelTot.Controls.Add(this.label2);
            this.panelTot.Controls.Add(this.labelNomCentre);
            this.panelTot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTot.Location = new System.Drawing.Point(0, 0);
            this.panelTot.Name = "panelTot";
            this.panelTot.Size = new System.Drawing.Size(1005, 650);
            this.panelTot.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(405, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "848645321";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(363, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "cep@politecnics.barcelona";
            // 
            // labelNomCentre
            // 
            this.labelNomCentre.AutoSize = true;
            this.labelNomCentre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNomCentre.Location = new System.Drawing.Point(342, 419);
            this.labelNomCentre.Name = "labelNomCentre";
            this.labelNomCentre.Size = new System.Drawing.Size(241, 25);
            this.labelNomCentre.TabIndex = 3;
            this.labelNomCentre.Text = "Centre d\'estudis Politècnics";
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
            // buttonGestionarProfessors
            // 
            this.buttonGestionarProfessors.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonGestionarProfessors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarProfessors.FlatAppearance.BorderSize = 0;
            this.buttonGestionarProfessors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarProfessors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGestionarProfessors.Location = new System.Drawing.Point(0, 48);
            this.buttonGestionarProfessors.Name = "buttonGestionarProfessors";
            this.buttonGestionarProfessors.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonGestionarProfessors.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarProfessors.TabIndex = 4;
            this.buttonGestionarProfessors.Text = "Professors";
            this.buttonGestionarProfessors.UseVisualStyleBackColor = false;
            this.buttonGestionarProfessors.Click += new System.EventHandler(this.buttonGestionarProfessors_Click);
            // 
            // buttonGestionarAlumnes
            // 
            this.buttonGestionarAlumnes.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonGestionarAlumnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarAlumnes.FlatAppearance.BorderSize = 0;
            this.buttonGestionarAlumnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarAlumnes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGestionarAlumnes.Location = new System.Drawing.Point(0, 0);
            this.buttonGestionarAlumnes.Name = "buttonGestionarAlumnes";
            this.buttonGestionarAlumnes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonGestionarAlumnes.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarAlumnes.TabIndex = 3;
            this.buttonGestionarAlumnes.Text = "Alumnes";
            this.buttonGestionarAlumnes.UseVisualStyleBackColor = false;
            this.buttonGestionarAlumnes.Click += new System.EventHandler(this.buttonGestionarAlumnes_Click);
            // 
            // panelCentreSubmenu
            // 
            this.panelCentreSubmenu.Controls.Add(this.buttonCalendariCentre);
            this.panelCentreSubmenu.Controls.Add(this.buttonDepartamentsCentre);
            this.panelCentreSubmenu.Controls.Add(this.buttonZonesValidables);
            this.panelCentreSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCentreSubmenu.Location = new System.Drawing.Point(0, 429);
            this.panelCentreSubmenu.Name = "panelCentreSubmenu";
            this.panelCentreSubmenu.Size = new System.Drawing.Size(275, 147);
            this.panelCentreSubmenu.TabIndex = 7;
            // 
            // buttonCalendariCentre
            // 
            this.buttonCalendariCentre.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCalendariCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCalendariCentre.FlatAppearance.BorderSize = 0;
            this.buttonCalendariCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendariCentre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCalendariCentre.Location = new System.Drawing.Point(0, 96);
            this.buttonCalendariCentre.Name = "buttonCalendariCentre";
            this.buttonCalendariCentre.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonCalendariCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonCalendariCentre.TabIndex = 9;
            this.buttonCalendariCentre.Text = "Calendari";
            this.buttonCalendariCentre.UseVisualStyleBackColor = false;
            this.buttonCalendariCentre.Click += new System.EventHandler(this.buttonCalendariCentre_Click);
            // 
            // buttonDepartamentsCentre
            // 
            this.buttonDepartamentsCentre.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDepartamentsCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDepartamentsCentre.FlatAppearance.BorderSize = 0;
            this.buttonDepartamentsCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartamentsCentre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDepartamentsCentre.Location = new System.Drawing.Point(0, 48);
            this.buttonDepartamentsCentre.Name = "buttonDepartamentsCentre";
            this.buttonDepartamentsCentre.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonDepartamentsCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonDepartamentsCentre.TabIndex = 8;
            this.buttonDepartamentsCentre.Text = "Departaments";
            this.buttonDepartamentsCentre.UseVisualStyleBackColor = false;
            this.buttonDepartamentsCentre.Click += new System.EventHandler(this.buttonDepartamentsCentre_Click);
            // 
            // buttonZonesValidables
            // 
            this.buttonZonesValidables.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonZonesValidables.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonZonesValidables.FlatAppearance.BorderSize = 0;
            this.buttonZonesValidables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZonesValidables.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonZonesValidables.Location = new System.Drawing.Point(0, 0);
            this.buttonZonesValidables.Name = "buttonZonesValidables";
            this.buttonZonesValidables.Padding = new System.Windows.Forms.Padding(57, 0, 0, 0);
            this.buttonZonesValidables.Size = new System.Drawing.Size(275, 48);
            this.buttonZonesValidables.TabIndex = 7;
            this.buttonZonesValidables.Text = "Zones Validables";
            this.buttonZonesValidables.UseVisualStyleBackColor = false;
            this.buttonZonesValidables.Click += new System.EventHandler(this.buttonZonesValidables_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panel2);
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(275, 720);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 72);
            this.panel2.TabIndex = 8;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.BackgroundImage = global::Libe_Escriptori.Properties.Resources.exit;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(41, 26);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(28, 28);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelUserName.Location = new System.Drawing.Point(90, 28);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(126, 25);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Administrador";
            // 
            // buttonCentre
            // 
            this.buttonCentre.AccessibleName = "Centre";
            this.buttonCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCentre.FlatAppearance.BorderSize = 0;
            this.buttonCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCentre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCentre.Image = global::Libe_Escriptori.Properties.Resources.schoolicon;
            this.buttonCentre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCentre.Location = new System.Drawing.Point(0, 381);
            this.buttonCentre.Name = "buttonCentre";
            this.buttonCentre.Padding = new System.Windows.Forms.Padding(27, 0, 22, 0);
            this.buttonCentre.Size = new System.Drawing.Size(275, 48);
            this.buttonCentre.TabIndex = 6;
            this.buttonCentre.Text = "    Centre";
            this.buttonCentre.UseVisualStyleBackColor = true;
            this.buttonCentre.Click += new System.EventHandler(this.buttonCentre_Click);
            // 
            // buttonGestionarGrups
            // 
            this.buttonGestionarGrups.AccessibleName = "GestionarGrups";
            this.buttonGestionarGrups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarGrups.FlatAppearance.BorderSize = 0;
            this.buttonGestionarGrups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarGrups.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGestionarGrups.Image = global::Libe_Escriptori.Properties.Resources.users_group;
            this.buttonGestionarGrups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionarGrups.Location = new System.Drawing.Point(0, 333);
            this.buttonGestionarGrups.Name = "buttonGestionarGrups";
            this.buttonGestionarGrups.Padding = new System.Windows.Forms.Padding(27, 0, 22, 0);
            this.buttonGestionarGrups.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarGrups.TabIndex = 5;
            this.buttonGestionarGrups.Text = "    Gestionar grups";
            this.buttonGestionarGrups.UseVisualStyleBackColor = true;
            this.buttonGestionarGrups.Click += new System.EventHandler(this.buttonGestionarGrups_Click);
            // 
            // buttonGestionarCursos
            // 
            this.buttonGestionarCursos.AccessibleName = "GestionarCursos";
            this.buttonGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarCursos.FlatAppearance.BorderSize = 0;
            this.buttonGestionarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGestionarCursos.Image = global::Libe_Escriptori.Properties.Resources.books;
            this.buttonGestionarCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionarCursos.Location = new System.Drawing.Point(0, 285);
            this.buttonGestionarCursos.Name = "buttonGestionarCursos";
            this.buttonGestionarCursos.Padding = new System.Windows.Forms.Padding(27, 0, 22, 0);
            this.buttonGestionarCursos.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarCursos.TabIndex = 4;
            this.buttonGestionarCursos.Text = "    Gestionar cursos";
            this.buttonGestionarCursos.UseVisualStyleBackColor = true;
            this.buttonGestionarCursos.Click += new System.EventHandler(this.buttonGestionarCursos_Click);
            // 
            // buttonGestionarUsuaris
            // 
            this.buttonGestionarUsuaris.AccessibleName = "GestionarUsuaris";
            this.buttonGestionarUsuaris.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionarUsuaris.FlatAppearance.BorderSize = 0;
            this.buttonGestionarUsuaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarUsuaris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGestionarUsuaris.Image = global::Libe_Escriptori.Properties.Resources.user__3_;
            this.buttonGestionarUsuaris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionarUsuaris.Location = new System.Drawing.Point(0, 140);
            this.buttonGestionarUsuaris.Name = "buttonGestionarUsuaris";
            this.buttonGestionarUsuaris.Padding = new System.Windows.Forms.Padding(27, 0, 22, 0);
            this.buttonGestionarUsuaris.Size = new System.Drawing.Size(275, 48);
            this.buttonGestionarUsuaris.TabIndex = 2;
            this.buttonGestionarUsuaris.Text = "Gestionar usuaris";
            this.buttonGestionarUsuaris.UseVisualStyleBackColor = true;
            this.buttonGestionarUsuaris.Click += new System.EventHandler(this.buttonGestionarUsuaris_Click);
            // 
            // buttonInici
            // 
            this.buttonInici.AccessibleName = "Inici";
            this.buttonInici.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInici.FlatAppearance.BorderSize = 0;
            this.buttonInici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonInici.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInici.Image = global::Libe_Escriptori.Properties.Resources.home2;
            this.buttonInici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInici.Location = new System.Drawing.Point(0, 92);
            this.buttonInici.Name = "buttonInici";
            this.buttonInici.Padding = new System.Windows.Forms.Padding(27, 0, 22, 0);
            this.buttonInici.Size = new System.Drawing.Size(275, 48);
            this.buttonInici.TabIndex = 1;
            this.buttonInici.Text = "Inici";
            this.buttonInici.UseVisualStyleBackColor = true;
            this.buttonInici.Click += new System.EventHandler(this.buttonInici_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(275, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::Libe_Escriptori.Properties.Resources.gradient;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.labelRuta);
            this.panelTop.Controls.Add(this.panelMove);
            this.panelTop.Controls.Add(this.panelAll);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(275, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1005, 70);
            this.panelTop.TabIndex = 1;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.BackColor = System.Drawing.Color.Transparent;
            this.labelRuta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.ForeColor = System.Drawing.Color.White;
            this.labelRuta.Location = new System.Drawing.Point(25, 36);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(47, 25);
            this.labelRuta.TabIndex = 2;
            this.labelRuta.Text = "Inici";
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(831, 30);
            this.panelMove.TabIndex = 1;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // panelAll
            // 
            this.panelAll.BackColor = System.Drawing.Color.Transparent;
            this.panelAll.Controls.Add(this.buttonMinimize);
            this.panelAll.Controls.Add(this.buttonProfile);
            this.panelAll.Controls.Add(this.buttonInbox);
            this.panelAll.Controls.Add(this.buttonClose);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAll.Location = new System.Drawing.Point(831, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(174, 70);
            this.panelAll.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = global::Libe_Escriptori.Properties.Resources.minus;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(116, 6);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(26, 29);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.BackgroundImage = global::Libe_Escriptori.Properties.Resources.profile_pic_big;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Location = new System.Drawing.Point(63, 18);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(42, 42);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.TabStop = false;
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // buttonInbox
            // 
            this.buttonInbox.BackColor = System.Drawing.Color.Transparent;
            this.buttonInbox.BackgroundImage = global::Libe_Escriptori.Properties.Resources.inbox;
            this.buttonInbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInbox.FlatAppearance.BorderSize = 0;
            this.buttonInbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonInbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInbox.Location = new System.Drawing.Point(10, 24);
            this.buttonInbox.Name = "buttonInbox";
            this.buttonInbox.Size = new System.Drawing.Size(36, 36);
            this.buttonInbox.TabIndex = 1;
            this.buttonInbox.TabStop = false;
            this.buttonInbox.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::Libe_Escriptori.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(151, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(18, 18);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelTot.ResumeLayout(false);
            this.panelTot.PerformLayout();
            this.panelUsuaris.ResumeLayout(false);
            this.panelCentreSubmenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelUsuaris;
        private Button buttonGestionarProfessors;
        private Button buttonGestionarAlumnes;
        private Panel panelCentreSubmenu;
        private Button buttonCalendariCentre;
        private Button buttonDepartamentsCentre;
        private Button buttonZonesValidables;
        private Panel panelMenu;
        private Button buttonCentre;
        private Button buttonGestionarGrups;
        private Button buttonGestionarCursos;
        private Button buttonGestionarUsuaris;
        private Button buttonInici;
        private Panel panelLogo;
        private Panel panelTop;
        private Button buttonProfile;
        private Button buttonInbox;
        private Button buttonMinimize;
        private Panel panelAll;
        private Panel panelMove;
        private Panel panel2;
        private Label labelUserName;
        private Button buttonLogout;
        private Panel panelTot;
        public Panel panel1;
        private Label label3;
        private Label label2;
        private Label labelNomCentre;
        private Label labelRuta;
        private Button buttonClose;
    }
}