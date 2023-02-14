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
    public partial class FormCentreZonesAfegirAules : Form
    {
        private String textBoxHintNameDepartment = " Nom de l'aula";
        private bool mouseDown;
        private Point lastLocation;
        public FormCentreZonesAfegirAules()
        {
            InitializeComponent();
        }
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxName, textBoxHintNameDepartment);
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxName, textBoxHintNameDepartment);
        }
    }
}
