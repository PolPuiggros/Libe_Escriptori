using Libe_Escriptori.Forms.Groups;
using Libe_Escriptori.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
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
            FormCentreZonesAfegirAules f = new FormCentreZonesAfegirAules();
            f.ShowDialog();
        }

        private void buttonGuardarZona_Click(object sender, EventArgs e)
        {
            POSTValidateZone();
        }

        private async Task POSTValidateZone()
        {
            //Variable global Baseurl
            var BASEURL = "https://localhost:44385";
            //Variable url concreta
            var url = "/api/validable_zones";

            var coordinates = textBoxZoneCoordinates.Text.Split(",");
            var latitude = Double.Parse(coordinates[0]);
            var longitude = Double.Parse(coordinates[1]);

            ValidateZonesDTO validateZonesDTO = new ValidateZonesDTO();
            validateZonesDTO.name = textBoxZoneName.Text;
            validateZonesDTO.radius = int.Parse(textBoxRange.Text);
            validateZonesDTO.latitude = 4.3;
            validateZonesDTO.longitude = 5.5;

            var json = JsonConvert.SerializeObject(validateZonesDTO);
            //var data = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BASEURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(true);
                if (response.IsSuccessStatusCode)
                {
                    //ValidateZonesDTO validateZone = await response.Content.ReadAsAsync<ValidateZonesDTO>().ConfigureAwait(false);
                    MessageBox.Show("Success");
                    
                }
                else
                {
                    MessageBox.Show("Internal server Error");
                }


                /*
                HttpResponseMessage response = await client.PostAsJsonAsync(url, validateZonesDTO);

                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    MessageBox.Show("S'ha afegit correctament");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
               
                */




            }


            
        }
    }
}
