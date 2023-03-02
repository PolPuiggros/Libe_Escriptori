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
    public partial class FormCentreDepartaments : Form
    {
        private String textBoxHintNameDepartment = " Nom del departament";
        public FormCentreDepartaments()
        {
            InitializeComponent();
        }

        private void textBoxNomDepartament_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxNomDepartament, textBoxHintNameDepartment);
        }

        private void textBoxNomDepartament_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxNomDepartament, textBoxHintNameDepartment);
        }
    }
}
