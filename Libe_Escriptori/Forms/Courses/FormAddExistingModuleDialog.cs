using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Courses
{
    public partial class FormAddExistingModuleDialog : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public string test;
        public List<modules> listModules = new List<modules>();
        Label labeld;
        courses _course;
        public FormAddExistingModuleDialog(Label ruta, courses _course)
        {
            //664; 495;
            InitializeComponent();
            ruta.Text = "Gestionar Cursos/Afegint Curs/Mòduls Existents";
            labeld = ruta;
            this._course = _course;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            foreach(DataGridViewRow row in dataGridViewModules.SelectedRows)
            {
                listModules.Add((modules)row.DataBoundItem);
            }
            
            this.Dispose();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            labeld.Text = "Gestionar Cursos/Afegint Curs";
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void FormAddExistingModuleDialog_Load(object sender, EventArgs e)
        {
            bindingSourceAllModules.DataSource = ModulesORM.SelectAll(_course);
        }

        private void dataGridViewModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
