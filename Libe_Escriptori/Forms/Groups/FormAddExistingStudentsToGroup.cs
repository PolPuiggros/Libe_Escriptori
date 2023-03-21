using Libe_Escriptori.Models;
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

namespace Libe_Escriptori.Forms.Groups
{
    public partial class FormAddExistingStudentsToGroup : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        Label ruta;
        groups group;
        public FormAddExistingStudentsToGroup(Label ruta, groups group)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Grups/Afegint Grup/Afegint Estudiants Existents";
            this.ruta = ruta;
            this.group = group;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ruta.Text = "Gestionar Grups/Afegint Grup";
            this.Close();
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

        private void FormAddExistingStudentsToGroup_Load(object sender, EventArgs e)
        {
            studentsBindingSource.DataSource = AlumnesOrm.SelectStudentsCourses(true,group.course_id);
            students _student = new students();
            foreach (DataGridViewRow row in dataGridViewExistingStudents.Rows)
            {
                _student = (students)row.DataBoundItem;


                if (_student.group_id == group.id)
                {
                    row.Cells["headerGroup"].Value = true;
                }


            }

        }

        private void buttonSaveStudentsGroup_Click(object sender, EventArgs e)
        {
            students _student = new students();
            foreach (DataGridViewRow row in dataGridViewExistingStudents.Rows)
            {
                _student = (students)row.DataBoundItem;
                

                if (Convert.ToBoolean(row.Cells["headerGroup"].Value))
                {
                    _student.group_id = group.id;
                }
                

                AlumnesOrm.Update(_student);

            }
            this.Close();
        }

        private void dataGridViewExistingStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.dataGridViewExistingStudents.Rows[e.RowIndex].Cells["headerGroup"].Value = true;
        }
    }
}
