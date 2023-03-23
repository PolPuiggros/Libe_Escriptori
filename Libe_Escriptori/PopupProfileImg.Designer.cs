namespace Libe_Escriptori
{
    partial class PopupProfileImg
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
            this.flowLayoutPanelPictrues = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPictrues
            // 
            this.flowLayoutPanelPictrues.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelPictrues.Location = new System.Drawing.Point(4, 18);
            this.flowLayoutPanelPictrues.Name = "flowLayoutPanelPictrues";
            this.flowLayoutPanelPictrues.Size = new System.Drawing.Size(180, 208);
            this.flowLayoutPanelPictrues.TabIndex = 0;
            // 
            // PopupProfileImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Libe_Escriptori.Properties.Resources.popupdef2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(189, 230);
            this.Controls.Add(this.flowLayoutPanelPictrues);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupProfileImg";
            this.Text = "PopupProfileImg";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPictrues;
    }
}