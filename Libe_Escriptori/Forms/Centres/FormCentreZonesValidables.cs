using Libe_Escriptori.Forms.Groups;
using Libe_Escriptori.Models;
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
        public delegate void DoEvent();
        public event DoEvent addPoint;
        Label ruta;
        validable_zones vz;


        public FormCentreZonesValidables(Label ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
        }

        private void textBoxZoneName_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxZoneName, textBoxHintZoneName);
        }

        private void textBoxZoneName_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxZoneName, textBoxHintZoneName);
        }

        private void textBoxZoneCoordinates_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxZoneCoordinates, textBoxHintZoneCoordinates);
        }

        private void textBoxZoneCoordinates_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxZoneCoordinates, textBoxHintZoneCoordinates);
        }

        private void textBoxRange_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxRange, textBoxHintRange);
        }

        private void textBoxRange_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxRange, textBoxHintRange);
        }
     
        private void buttonAfegirAules_Click_1(object sender, EventArgs e)
        {
            FormCentreZonesAfegirAules f = new FormCentreZonesAfegirAules(ruta, vz);
            DialogResult dr = f.ShowDialog();
            if (dr == DialogResult.OK)
            {
                addPoint();
            }
            
        }

        private void FormCentreZonesValidables_Load(object sender, EventArgs e)
        {
            refreshDGV();
            dataGridView1.Rows[0].Selected = true;
            vz = (validable_zones)dataGridView1.SelectedRows[0].DataBoundItem;
        }

        private void buttonGuardarZona_Click(object sender, EventArgs e)
        {
            String missatge;
            if (fieldsNotNull() && correctCoordinates())
            {
                String coordinates = textBoxZoneCoordinates.Text;
                string latitude = coordinates.Split(',')[0];
                string longitude = coordinates.Split(',')[1];
                validable_zones vz = new validable_zones();
                vz.name = textBoxZoneName.Text;
                vz.latitude = Convert.ToDecimal(latitude);
                vz.longitude = Convert.ToDecimal(longitude);
                vz.radius = Convert.ToInt32(textBoxRange.Text);
                vz.active = true;
                missatge = ZonesValidablesOrm.Insert(vz);
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else{
                    MessageBox.Show("S'ha afegit la zona validable correctament", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxZoneName.Text = "";
                    textBoxRange.Text = "";
                    textBoxZoneCoordinates.Text = "";
                    UtilitiesDesign.textBoxSearch_Leave(textBoxZoneName, textBoxHintZoneName);
                    UtilitiesDesign.textBoxSearch_Leave(textBoxZoneCoordinates, textBoxHintZoneCoordinates);
                    UtilitiesDesign.textBoxSearch_Leave(textBoxRange, textBoxHintRange);
                    refreshDGV();
                    this.addPoint();
                    
                }

            }
        }

        private void refreshDGV()
        {
            bindingSourceZonesValidables.DataSource = ZonesValidablesOrm.Select(true);
        }

        private bool correctCoordinates()
        {
            bool correctFormat = true;
            String coordinades = textBoxZoneCoordinates.Text;
            if (!coordinades.Contains(","))
            {
                correctFormat = false;
                MessageBox.Show("El format de les coordenades és incorrecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return correctFormat;
        }

        private bool fieldsNotNull()
        {
            bool fieldsNotNull = true;
            if(textBoxZoneName.Text == "" || textBoxZoneName.Text == textBoxHintZoneName)
            {
                MessageBox.Show("El nom de la zona validable no pot estar buit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fieldsNotNull = false;
            }
            else if (textBoxZoneCoordinates.Text == "" || textBoxZoneCoordinates.Text == textBoxHintZoneCoordinates)
            {
                MessageBox.Show("Les cordenades de la zona validable no poden estar buides", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fieldsNotNull = false;
            }
            else if (textBoxRange.Text == "" || textBoxRange.Text == textBoxHintRange)
            {
                MessageBox.Show("El radi de la zona validable no pot estar buit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fieldsNotNull = false;
            }
            return fieldsNotNull;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                validable_zones valz = (validable_zones)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                int numAules = ZonesValidablesOrm.SelectClassrooms(valz.id, true);
                e.Value = numAules.ToString();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vz = (validable_zones)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == 5)
            {
                if (vz != null)
                {
                    DialogResult dia = MessageBox.Show("Estàs segur/a que vols esborrar la zona validable?", "Esborrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dia == DialogResult.OK)
                    {
                        ZonesValidablesOrm.Delete(vz);
                        refreshDGV();
                        addPoint();
                    }
                }
            }
        }
    }
}
