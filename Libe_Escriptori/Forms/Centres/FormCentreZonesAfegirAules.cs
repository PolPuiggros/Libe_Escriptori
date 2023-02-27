using Libe_Escriptori.Models;
using Newtonsoft.Json;
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

        private void buttonGuardarZona_Click(object sender, EventArgs e)
        {


            MessageBox.Show(POSTClassroom().Result);


        }


        private async Task<string> POSTClassroom()
        {
            //Variable global Baseurl
            var BASEURL = "https://localhost:44387";
            //Variable url concreta
            var url = BASEURL + "/api/classrooms";

            ClassroomDTO classroomDTO = new ClassroomDTO();
            classroomDTO.id = 2;
            classroomDTO.name = textBoxName.Text;
            classroomDTO.validable_zone_id = 1;
            classroomDTO.user_id = 8;

            var json = JsonConvert.SerializeObject(classroomDTO);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {

                var response = await client.PostAsync(url, data);

                var result = await response.Content.ReadAsStringAsync();

                return result;

            }

            return "";
        }

    }


}
