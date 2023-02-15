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
        private String textBoxHint = "  Búsqueda...";
        Form activeForm;
        public GestionarUsuarisProfessors()
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxSearch, textBoxHint);
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxSearch, textBoxHint);
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
