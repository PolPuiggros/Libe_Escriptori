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
    public partial class FormAddExistingStudentsToGroup : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        Label ruta;
        public FormAddExistingStudentsToGroup(Label ruta)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Grups/Afegint Grup/Afegint Estudiants Existents";
            this.ruta = ruta;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ruta.Text = "Gestionar Grups/Afegint Grup";
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
