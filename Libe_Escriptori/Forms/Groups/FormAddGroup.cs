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
        profesors tutor;
        bool createdSchedule = false;
       
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
                createdSchedule = true;
            }
            else
            {
                ruta.Text = "Gestionar Grups/Afegint Grup";
                
            }
        }

        private void buttonManageStudents_Click_1(object sender, EventArgs e)
        {
            if (SelectedsComboBox() && createdSchedule)
            {
                FormAddExistingStudentsToGroup faetg = new FormAddExistingStudentsToGroup(ruta,group);
                faetg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Has de seleccionar tots els comboBox i afegir un horari abans d'afegir alumnes al grup");
            }
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
                if (SelectedsComboBox())
                {
                    
                    schedules schedule = new schedules();
                    schedule.name = "Horari de ";
                    SchedulesOrm.Insert(schedule);
                    tutor = (profesors)comboBoxTutorGroup.SelectedItem;
                    groups newGroup = new groups();
                    newGroup.grade = Int32.Parse(comboBoxYearGroup.SelectedItem.ToString());
                    newGroup.group_letter = comboBoxClassGroup.SelectedItem.ToString();
                    courses _course = (courses)comboBoxCicleGroup.SelectedItem;
                    newGroup.course_id = _course.id;
                    profesors _tutor = (profesors)comboBoxTutorGroup.SelectedItem;
                    newGroup.tutor_id = _tutor.id;
                    newGroup.schedule_id = schedule.id;
                    newGroup.active = true;
                    newGroup.classroom_id = 2;
                    GroupsOrm.Insert(newGroup);
                    OpenChildForm(new FormCreateScheduleGroup(ruta, adding, newGroup));
                    adding = false;
                    group = newGroup;
                    createdSchedule = true;
                }
                else
                {
                    MessageBox.Show("Has de seleccionar tots els comboBox abans de crear l'horari");
                }
                
            }
            else
            {
                OpenChildForm(new FormCreateScheduleGroup(ruta, adding, group));
            }
            
        }

        private bool SelectedsComboBox()
        {
            bool allComboBoxSelecteds = false;

            if (comboBoxCicleGroup.SelectedItem != null && comboBoxClassGroup.SelectedItem != null && comboBoxYearGroup.SelectedItem != null)
            {
                allComboBoxSelecteds = true;
            }

            return allComboBoxSelecteds;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (adding && group != null )
            {
                GroupsOrm.Delete(group);
            }
            ruta.Text = "Gestionar Grups";
        }

        private void InitializeGroup()
        {
            //comboBoxCicleGroup.SelectedItem = comboBoxCicleGroup.FindString(group.courses.abreviation.ToString());
            comboBoxCicleGroup.SelectedValue = group.courses.id;
            comboBoxClassGroup.SelectedIndex = comboBoxClassGroup.FindStringExact(group.group_letter.ToString());
            comboBoxYearGroup.SelectedIndex = comboBoxYearGroup.FindStringExact(group.grade.ToString());
            comboBoxTutorGroup.SelectedValue = group.profesors.id;
            //comboBoxMainClassGroup.SelectedItem = group.
        }

        private void InitializeComboBoxesNull()
        {
            comboBoxCicleGroup.SelectedItem = null;
            comboBoxClassGroup.SelectedItem = null;
            comboBoxYearGroup.SelectedItem = null;
            comboBoxTutorGroup.SelectedItem = null;
            comboBoxMainClassGroup.SelectedItem = null;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
