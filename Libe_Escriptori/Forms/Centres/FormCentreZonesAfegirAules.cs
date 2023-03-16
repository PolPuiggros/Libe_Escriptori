using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
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
        Label ruta;
        validable_zones selectedZone;
        List<classrooms> aules;
        public FormCentreZonesAfegirAules(Label ruta, validable_zones vz)
        {
            InitializeComponent();
            ruta.Text = "Centre/Zones Validables/Afegint Aules";
            this.ruta = ruta;
            selectedZone = vz;
            refreshGDV();
            
            
        }

        private void refreshGDV()
        {
            aules = AulesOrm.Select(selectedZone.id);
            bindingSource1.DataSource = aules;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ruta.Text = "Centre/Zones Validables";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGuardarZona_Click(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxName, textBoxHintNameDepartment);
            users user = new users();
            user.username = textBoxName.Text;
            user.password = Blowfish.encriptarContrasenya("12345");
            user.type = 3;
            user.active = true;
            UsersOrm.Insert(user);

            classrooms aula = new classrooms();
            aula.id = UsersOrm.Select(user.username);
            aula.name = textBoxName.Text;
            aula.validable_zone_id = selectedZone.id;
            aula.active = true;
            AulesOrm.Insert(aula);
            refreshGDV();
        }
    }
}
