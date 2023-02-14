using Libe_Escriptori.Forms.Groups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    public partial class FormCentreZonesValidables : Form
    {
        private Form activeForm;
        public FormCentreZonesValidables()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelZonesValidables.Controls.Add(childForm);
            panelZonesValidables.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
     
        private void buttonAfegirAules_Click_1(object sender, EventArgs e)
        {
            FormCentreZonesAfegirAules f = new FormCentreZonesAfegirAules();
            f.ShowDialog();
        }
    }
}
