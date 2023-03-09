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
            refreshDGV();   
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
                    TextBoxDesign.textBoxSearch_Leave(textBoxZoneName, textBoxHintZoneName);
                    TextBoxDesign.textBoxSearch_Leave(textBoxZoneCoordinates, textBoxHintZoneCoordinates);
                    TextBoxDesign.textBoxSearch_Leave(textBoxRange, textBoxHintRange);
                    refreshDGV();
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
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

            }
            if (e.ColumnIndex == 5)
            {
                validable_zones vz = (validable_zones)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (vz != null)
                {
                    DialogResult dia = MessageBox.Show("Estàs segur/a que vols esborrar la zona validable?", "Esborrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dia == DialogResult.OK)
                    {
                        ZonesValidablesOrm.Delete(vz);
                        refreshDGV();
                    }
                }
            }
        }
    }
}
