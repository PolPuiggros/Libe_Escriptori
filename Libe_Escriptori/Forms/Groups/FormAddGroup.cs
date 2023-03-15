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
        schedules _schedule;
        bool adding = true;
       
        public FormAddGroup(Label ruta)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Grups/Afegint Grup";
            this.ruta = ruta;
        }
        public FormAddGroup(Label ruta,groups group, bool add)
        {
            InitializeComponent();
            
            this.ruta = ruta;
            this.group = group;
            this.adding = add;
            //Edit
            if (!adding)
            {
                ruta.Text = "Gestionar Grups/Editant Grup";
            }
            else
            {
                ruta.Text = "Gestionar Grups/Afegint Grup";
                
            }
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
            
            if (adding)
            {
                schedules schedule = new schedules();
            schedule.name = "Horari de ";
            SchedulesOrm.Insert(schedule);
                OpenChildForm(new FormCreateScheduleGroup(ruta, adding, schedule));
            }
            else
            {
                OpenChildForm(new FormCreateScheduleGroup(ruta, adding, group.schedules));
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ruta.Text = "Gestionar Grups";
        }

        private void InitializeGroup()
        {
            comboBoxCicleGroup.SelectedItem = comboBoxCicleGroup.FindString(group.courses.abreviation.ToString());
            comboBoxClassGroup.SelectedItem = group.group_letter;
            comboBoxYearGroup.SelectedItem = group.grade;
            comboBoxTutorGroup.SelectedItem = group.profesors.name;
        }

        private void InitializeComboBoxesNull()
        {
            comboBoxCicleGroup.SelectedItem = null;
            comboBoxClassGroup.SelectedItem = null;
            comboBoxYearGroup.SelectedItem = null;
            comboBoxTutorGroup.SelectedItem = null;
        }

        private void FormAddGroup_Load(object sender, EventArgs e)
        {
            groupsBindingSource.DataSource = GroupsOrm.Select();
            coursesBindingSource.DataSource = CoursesORM.Select();
            profesorsBindingSource.DataSource = ProfesorsOrm.Select(true);

            if (!adding)
            {
                InitializeGroup();
            }
            else
            {
                InitializeComboBoxesNull();
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panelAddGroup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
