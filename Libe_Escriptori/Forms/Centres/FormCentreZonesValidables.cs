using Libe_Escriptori.Forms.Groups;
using Libe_Escriptori.Models.Centre;
using Libe_Escriptori.Models.Usuaris.Alumnes;
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
        private String textBoxHintZoneName = " Nom de la zona validable";
        private String textBoxHintZoneCoordinates = " Coordenades de la zona";
        private String textBoxHintRange = " Radi";
        private Form activeForm;
        Label ruta;
        public FormCentreZonesValidables(Label ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
        }

        private void textBoxZoneName_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxZoneName, textBoxHintZoneName);
        }

        private void textBoxZoneName_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxZoneName, textBoxHintZoneName);
        }

        private void textBoxZoneCoordinates_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxZoneCoordinates, textBoxHintZoneCoordinates);
        }

        private void textBoxZoneCoordinates_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxZoneCoordinates, textBoxHintZoneCoordinates);
        }

        private void textBoxRange_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxRange, textBoxHintRange);
        }

        private void textBoxRange_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxRange, textBoxHintRange);
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
            FormCentreZonesAfegirAules f = new FormCentreZonesAfegirAules(ruta);
            f.ShowDialog();
        }

        private void FormCentreZonesValidables_Load(object sender, EventArgs e)
        {
            bindingSourceZonesValidables.DataSource = ZonesValidablesOrm.Select(true);
        }
    }
}
