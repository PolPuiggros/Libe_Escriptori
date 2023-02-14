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
    public partial class GestionarUsuarisAlumnes : Form
    {
        private String textBoxHint = "  Búsqueda...";
        public GestionarUsuarisAlumnes()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            GestionarUsuarisAlumnesAfegint gestionarUsuarisAlumnesAfegint = new GestionarUsuarisAlumnesAfegint() { TopLevel = false, TopMost = true };
            MainForm mainForm = new MainForm();
            mainForm.panel1.Controls.Add(gestionarUsuarisAlumnesAfegint);
            gestionarUsuarisAlumnesAfegint.BringToFront();
            gestionarUsuarisAlumnesAfegint.Show();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxSearch, textBoxHint);
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxSearch, textBoxHint);
        }

        private void textBoxFilterCourse_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxFilterCourse, textBoxHint);
        }

        private void textBoxFilterCourse_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxFilterCourse, textBoxHint);
        }
    }
}
