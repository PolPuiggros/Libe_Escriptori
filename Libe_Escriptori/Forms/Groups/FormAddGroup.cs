using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using Libe_Escriptori.Models.Usuaris.Profesors;
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
    public partial class FormAddGroup : Form
    {
        private Form activeForm;
        Label ruta;
        groups group;
        bool edit = false;
        public FormAddGroup(Label ruta)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Grups/Afegint Grup";
            this.ruta = ruta;
            this.edit = false;
        }
        public FormAddGroup(Label ruta,groups group)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Grups/Afegint Grup";
            this.ruta = ruta;
            this.group = group;
            this.edit = true;
            InitializeGroup();
        }

        private void buttonManageStudents_Click_1(object sender, EventArgs e)
        {
            FormAddExistingStudentsToGroup faetg = new FormAddExistingStudentsToGroup(ruta);
            faetg.ShowDialog();
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
            panelAddGroup.Controls.Add(childForm);
            panelAddGroup.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonGestionarHorari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCreateScheduleGroup(ruta));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ruta.Text = "Gestionar Grups";
        }

        private void InitializeGroup()
        {
            
        }

        private void FormAddGroup_Load(object sender, EventArgs e)
        {
            groupsBindingSource.DataSource = GroupsOrm.Select();
            coursesBindingSource.DataSource = CoursesORM.Select();
            profesorsBindingSource.DataSource = ProfesorsOrm.Select(true);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panelAddGroup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
