using Libe_Escriptori.Forms.Gestionar_Usuaris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Groups
{
    public partial class FormGroups : Form
    {
        Form activeForm;
        Label ruta;
        public FormGroups(Label ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
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
            panelGroups.Controls.Add(childForm);
            panelGroups.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNewGroup_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddGroup(ruta));
        }
    }
}
