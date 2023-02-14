using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms
{
    public partial class FormCentreZonesValidables : Form
    {
        private String textBoxHintZoneName = " Nom de la zona validable";
        private String textBoxHintZoneCoordinates = " Coordenades de la zona";
        private String textBoxHintRange = " Radi";
        public FormCentreZonesValidables()
        {
            InitializeComponent();
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
    }
}
