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
    }
}
