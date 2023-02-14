using Libe_Escriptori.Forms.Gestionar_Usuaris.Professors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    public partial class GestionarUsuarisProfessors : Form
    {
        Form activeForm;
        public GestionarUsuarisProfessors()
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
            panelGestionarUsuarisProfessors.Controls.Add(childForm);
            panelGestionarUsuarisProfessors.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new GestionarUsuarisProfessorsAfegint());
        }
    }
}
