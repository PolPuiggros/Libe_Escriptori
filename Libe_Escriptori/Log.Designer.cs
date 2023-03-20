namespace Libe_Escriptori
{
    partial class Log
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeUuser = new System.Windows.Forms.Label();
            this.labelAccio = new System.Windows.Forms.Label();
            this.labelSouce = new System.Windows.Forms.Label();
            this.labelSubjecte = new System.Windows.Forms.Label();
            this.labelTimeStamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeUuser
            // 
            this.labeUuser.AutoSize = true;
            this.labeUuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeUuser.Location = new System.Drawing.Point(1, 9);
            this.labeUuser.Name = "labeUuser";
            this.labeUuser.Size = new System.Drawing.Size(76, 12);
            this.labeUuser.TabIndex = 0;
            this.labeUuser.Text = "Administrador";
            this.labeUuser.Click += new System.EventHandler(this.labeUuser_Click);
            // 
            // labelAccio
            // 
            this.labelAccio.AutoSize = true;
            this.labelAccio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccio.Location = new System.Drawing.Point(76, 9);
            this.labelAccio.Name = "labelAccio";
            this.labelAccio.Size = new System.Drawing.Size(60, 12);
            this.labelAccio.TabIndex = 1;
            this.labelAccio.Text = "ha actualitzat";
            // 
            // labelSouce
            // 
            this.labelSouce.AutoSize = true;
            this.labelSouce.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouce.Location = new System.Drawing.Point(2, 21);
            this.labelSouce.Name = "labelSouce";
            this.labelSouce.Size = new System.Drawing.Size(66, 12);
            this.labelSouce.TabIndex = 2;
            this.labelSouce.Text = "el departament";
            // 
            // labelSubjecte
            // 
            this.labelSubjecte.AutoSize = true;
            this.labelSubjecte.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjecte.Location = new System.Drawing.Point(67, 21);
            this.labelSubjecte.Name = "labelSubjecte";
            this.labelSubjecte.Size = new System.Drawing.Size(63, 12);
            this.labelSubjecte.TabIndex = 3;
            this.labelSubjecte.Text = "Informàtica";
            this.labelSubjecte.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTimeStamp
            // 
            this.labelTimeStamp.AutoSize = true;
            this.labelTimeStamp.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeStamp.Location = new System.Drawing.Point(138, 14);
            this.labelTimeStamp.Name = "labelTimeStamp";
            this.labelTimeStamp.Size = new System.Drawing.Size(27, 12);
            this.labelTimeStamp.TabIndex = 4;
            this.labelTimeStamp.Text = "14:03";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelTimeStamp);
            this.Controls.Add(this.labelSubjecte);
            this.Controls.Add(this.labelSouce);
            this.Controls.Add(this.labelAccio);
            this.Controls.Add(this.labeUuser);
            this.Name = "Log";
            this.Size = new System.Drawing.Size(168, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeUuser;
        private System.Windows.Forms.Label labelAccio;
        private System.Windows.Forms.Label labelSouce;
        private System.Windows.Forms.Label labelSubjecte;
        private System.Windows.Forms.Label labelTimeStamp;
    }
}
