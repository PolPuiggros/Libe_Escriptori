namespace Libe_Escriptori
{
    partial class popupLog
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
            this.panelAllLogs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelAllLogs
            // 
            this.panelAllLogs.BackColor = System.Drawing.Color.Transparent;
            this.panelAllLogs.Location = new System.Drawing.Point(3, 19);
            this.panelAllLogs.Name = "panelAllLogs";
            this.panelAllLogs.Size = new System.Drawing.Size(194, 197);
            this.panelAllLogs.TabIndex = 0;
            // 
            // popupLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Libe_Escriptori.Properties.Resources.popupdef;
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.panelAllLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupLog";
            this.Text = "popupLog";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelAllLogs;
    }
}