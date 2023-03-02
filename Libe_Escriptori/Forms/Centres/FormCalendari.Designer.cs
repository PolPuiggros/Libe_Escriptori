using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    partial class FormCalendari
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
            this.flowLayoutPanelDaysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSeguent = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.labelDilluns = new System.Windows.Forms.Label();
            this.labelDimarts = new System.Windows.Forms.Label();
            this.labelDimecres = new System.Windows.Forms.Label();
            this.labelDijous = new System.Windows.Forms.Label();
            this.labelDiumenge = new System.Windows.Forms.Label();
            this.labelDivendres = new System.Windows.Forms.Label();
            this.labelDissabte = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelLlegenda = new System.Windows.Forms.Panel();
            this.panelUltimDiaDelCurs = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panelPrimerDiaDeCurs = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panelVacances = new System.Windows.Forms.Panel();
            this.labelVacances = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panelLliureEleccio = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panelCapdeSetmana = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panelLlegenda.SuspendLayout();
            this.panelUltimDiaDelCurs.SuspendLayout();
            this.panelPrimerDiaDeCurs.SuspendLayout();
            this.panelVacances.SuspendLayout();
            this.panelLliureEleccio.SuspendLayout();
            this.panelCapdeSetmana.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelDaysContainer
            // 
            this.flowLayoutPanelDaysContainer.Location = new System.Drawing.Point(36, 98);
            this.flowLayoutPanelDaysContainer.Name = "flowLayoutPanelDaysContainer";
            this.flowLayoutPanelDaysContainer.Size = new System.Drawing.Size(933, 444);
            this.flowLayoutPanelDaysContainer.TabIndex = 3;
            // 
            // buttonSeguent
            // 
            this.buttonSeguent.Location = new System.Drawing.Point(515, 558);
            this.buttonSeguent.Name = "buttonSeguent";
            this.buttonSeguent.Size = new System.Drawing.Size(75, 26);
            this.buttonSeguent.TabIndex = 4;
            this.buttonSeguent.Text = ">>";
            this.buttonSeguent.UseVisualStyleBackColor = true;
            this.buttonSeguent.Click += new System.EventHandler(this.buttonSeguent_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(414, 558);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 26);
            this.buttonAnterior.TabIndex = 5;
            this.buttonAnterior.Text = "<<";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // labelDilluns
            // 
            this.labelDilluns.AutoSize = true;
            this.labelDilluns.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDilluns.Location = new System.Drawing.Point(71, 66);
            this.labelDilluns.Name = "labelDilluns";
            this.labelDilluns.Size = new System.Drawing.Size(57, 21);
            this.labelDilluns.TabIndex = 6;
            this.labelDilluns.Text = "Dilluns";
            // 
            // labelDimarts
            // 
            this.labelDimarts.AutoSize = true;
            this.labelDimarts.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDimarts.Location = new System.Drawing.Point(195, 66);
            this.labelDimarts.Name = "labelDimarts";
            this.labelDimarts.Size = new System.Drawing.Size(69, 21);
            this.labelDimarts.TabIndex = 7;
            this.labelDimarts.Text = "Dimarts";
            // 
            // labelDimecres
            // 
            this.labelDimecres.AutoSize = true;
            this.labelDimecres.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDimecres.Location = new System.Drawing.Point(325, 66);
            this.labelDimecres.Name = "labelDimecres";
            this.labelDimecres.Size = new System.Drawing.Size(81, 21);
            this.labelDimecres.TabIndex = 8;
            this.labelDimecres.Text = "Dimecres";
            // 
            // labelDijous
            // 
            this.labelDijous.AutoSize = true;
            this.labelDijous.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDijous.Location = new System.Drawing.Point(469, 66);
            this.labelDijous.Name = "labelDijous";
            this.labelDijous.Size = new System.Drawing.Size(54, 21);
            this.labelDijous.TabIndex = 9;
            this.labelDijous.Text = "Dijous";
            // 
            // labelDiumenge
            // 
            this.labelDiumenge.AutoSize = true;
            this.labelDiumenge.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDiumenge.Location = new System.Drawing.Point(854, 66);
            this.labelDiumenge.Name = "labelDiumenge";
            this.labelDiumenge.Size = new System.Drawing.Size(91, 21);
            this.labelDiumenge.TabIndex = 12;
            this.labelDiumenge.Text = "Diumenge";
            // 
            // labelDivendres
            // 
            this.labelDivendres.AutoSize = true;
            this.labelDivendres.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDivendres.Location = new System.Drawing.Point(585, 66);
            this.labelDivendres.Name = "labelDivendres";
            this.labelDivendres.Size = new System.Drawing.Size(87, 21);
            this.labelDivendres.TabIndex = 10;
            this.labelDivendres.Text = "Divendres";
            // 
            // labelDissabte
            // 
            this.labelDissabte.AutoSize = true;
            this.labelDissabte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelDissabte.Location = new System.Drawing.Point(728, 66);
            this.labelDissabte.Name = "labelDissabte";
            this.labelDissabte.Size = new System.Drawing.Size(76, 21);
            this.labelDissabte.TabIndex = 11;
            this.labelDissabte.Text = "Dissabte";
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F);
            this.labelDate.Location = new System.Drawing.Point(298, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(400, 30);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "MONTH YEAR";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLlegenda
            // 
            this.panelLlegenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLlegenda.Controls.Add(this.panelUltimDiaDelCurs);
            this.panelLlegenda.Controls.Add(this.panelPrimerDiaDeCurs);
            this.panelLlegenda.Controls.Add(this.panelVacances);
            this.panelLlegenda.Controls.Add(this.panelLliureEleccio);
            this.panelLlegenda.Controls.Add(this.panelCapdeSetmana);
            this.panelLlegenda.Location = new System.Drawing.Point(763, 486);
            this.panelLlegenda.Name = "panelLlegenda";
            this.panelLlegenda.Size = new System.Drawing.Size(206, 147);
            this.panelLlegenda.TabIndex = 14;
            // 
            // panelUltimDiaDelCurs
            // 
            this.panelUltimDiaDelCurs.Controls.Add(this.label15);
            this.panelUltimDiaDelCurs.Controls.Add(this.panel20);
            this.panelUltimDiaDelCurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUltimDiaDelCurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUltimDiaDelCurs.Location = new System.Drawing.Point(0, 100);
            this.panelUltimDiaDelCurs.Name = "panelUltimDiaDelCurs";
            this.panelUltimDiaDelCurs.Size = new System.Drawing.Size(204, 25);
            this.panelUltimDiaDelCurs.TabIndex = 10;
            this.panelUltimDiaDelCurs.Click += new System.EventHandler(this.panelUltimDiaDelCurs_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label15.Location = new System.Drawing.Point(42, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Últim dia del curs";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Location = new System.Drawing.Point(10, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(27, 17);
            this.panel20.TabIndex = 26;
            this.panel20.Click += new System.EventHandler(this.panel20_Click);
            // 
            // panelPrimerDiaDeCurs
            // 
            this.panelPrimerDiaDeCurs.Controls.Add(this.label13);
            this.panelPrimerDiaDeCurs.Controls.Add(this.panel18);
            this.panelPrimerDiaDeCurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPrimerDiaDeCurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrimerDiaDeCurs.Location = new System.Drawing.Point(0, 75);
            this.panelPrimerDiaDeCurs.Name = "panelPrimerDiaDeCurs";
            this.panelPrimerDiaDeCurs.Size = new System.Drawing.Size(204, 25);
            this.panelPrimerDiaDeCurs.TabIndex = 9;
            this.panelPrimerDiaDeCurs.Click += new System.EventHandler(this.panelPrimerDiaDeCurs_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.Location = new System.Drawing.Point(40, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Primer dia del curs";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Location = new System.Drawing.Point(10, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(27, 17);
            this.panel18.TabIndex = 26;
            this.panel18.Click += new System.EventHandler(this.panel18_Click);
            // 
            // panelVacances
            // 
            this.panelVacances.Controls.Add(this.labelVacances);
            this.panelVacances.Controls.Add(this.panel19);
            this.panelVacances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelVacances.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVacances.Location = new System.Drawing.Point(0, 50);
            this.panelVacances.Name = "panelVacances";
            this.panelVacances.Size = new System.Drawing.Size(204, 25);
            this.panelVacances.TabIndex = 3;
            this.panelVacances.Click += new System.EventHandler(this.panelVacances_Click);
            // 
            // labelVacances
            // 
            this.labelVacances.AutoSize = true;
            this.labelVacances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVacances.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelVacances.Location = new System.Drawing.Point(42, 3);
            this.labelVacances.Name = "labelVacances";
            this.labelVacances.Size = new System.Drawing.Size(144, 20);
            this.labelVacances.TabIndex = 23;
            this.labelVacances.Text = "Vacances / festius";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Location = new System.Drawing.Point(10, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(27, 17);
            this.panel19.TabIndex = 22;
            this.panel19.Click += new System.EventHandler(this.panel19_Click);
            // 
            // panelLliureEleccio
            // 
            this.panelLliureEleccio.Controls.Add(this.label12);
            this.panelLliureEleccio.Controls.Add(this.panel16);
            this.panelLliureEleccio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLliureEleccio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLliureEleccio.Location = new System.Drawing.Point(0, 25);
            this.panelLliureEleccio.Name = "panelLliureEleccio";
            this.panelLliureEleccio.Size = new System.Drawing.Size(204, 25);
            this.panelLliureEleccio.TabIndex = 2;
            this.panelLliureEleccio.Click += new System.EventHandler(this.panelLliureEleccio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.Location = new System.Drawing.Point(43, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Lliure elecció";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Location = new System.Drawing.Point(11, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(27, 17);
            this.panel16.TabIndex = 20;
            this.panel16.Click += new System.EventHandler(this.panel16_Click);
            // 
            // panelCapdeSetmana
            // 
            this.panelCapdeSetmana.Controls.Add(this.label11);
            this.panelCapdeSetmana.Controls.Add(this.panel14);
            this.panelCapdeSetmana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCapdeSetmana.Location = new System.Drawing.Point(0, 0);
            this.panelCapdeSetmana.Name = "panelCapdeSetmana";
            this.panelCapdeSetmana.Size = new System.Drawing.Size(204, 25);
            this.panelCapdeSetmana.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label11.Location = new System.Drawing.Point(39, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Caps de setmana";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(10, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(27, 17);
            this.panel14.TabIndex = 18;
            // 
            // FormCalendari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.panelLlegenda);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDiumenge);
            this.Controls.Add(this.labelDivendres);
            this.Controls.Add(this.labelDissabte);
            this.Controls.Add(this.labelDimecres);
            this.Controls.Add(this.labelDijous);
            this.Controls.Add(this.labelDilluns);
            this.Controls.Add(this.labelDimarts);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonSeguent);
            this.Controls.Add(this.flowLayoutPanelDaysContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalendari";
            this.Text = "FormCalendari";
            this.Load += new System.EventHandler(this.FormCalendari_Load);
            this.panelLlegenda.ResumeLayout(false);
            this.panelUltimDiaDelCurs.ResumeLayout(false);
            this.panelUltimDiaDelCurs.PerformLayout();
            this.panelPrimerDiaDeCurs.ResumeLayout(false);
            this.panelPrimerDiaDeCurs.PerformLayout();
            this.panelVacances.ResumeLayout(false);
            this.panelVacances.PerformLayout();
            this.panelLliureEleccio.ResumeLayout(false);
            this.panelLliureEleccio.PerformLayout();
            this.panelCapdeSetmana.ResumeLayout(false);
            this.panelCapdeSetmana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelDaysContainer;
        private Button buttonSeguent;
        private Button buttonAnterior;
        private Label labelDilluns;
        private Label labelDimarts;
        private Label labelDimecres;
        private Label labelDijous;
        private Label labelDiumenge;
        private Label labelDivendres;
        private Label labelDissabte;
        private Label labelDate;
        private Panel panelLlegenda;
        private Panel panelCapdeSetmana;
        private Label label11;
        private Panel panel14;
        private Panel panelLliureEleccio;
        private Panel panelUltimDiaDelCurs;
        private Label label15;
        private Panel panel20;
        private Panel panelPrimerDiaDeCurs;
        private Label label13;
        private Panel panel18;
        private Panel panelVacances;
        private Label labelVacances;
        private Panel panel19;
        private Label label12;
        private Panel panel16;
    }
}