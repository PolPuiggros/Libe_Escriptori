using Libe_Escriptori.Forms.Gestionar_Usuaris;
using Libe_Escriptori.Forms.Gestionar_Usuaris.Professors;
using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using Libe_Escriptori.Models.Usuaris.Alumnes;
using Libe_Escriptori.Properties;
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
    public partial class FormCourses : Form
    {
        Form activeForm;
        Label labeld;
        public delegate void DoEvent();
        public event DoEvent addPoint;
        public FormCourses(Label labelRuta)
        {
            InitializeComponent();
            labeld = labelRuta;
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
            panelCourses.Controls.Add(childForm);
            panelCourses.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCoursesAdd(labeld));
            bindingSourceCourses.DataSource = CoursesORM.Select();
        }


        private void FormCourses_Load(object sender, EventArgs e)
        {
            //load
            bindingSourceCourses.DataSource = CoursesORM.Select();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var selectedCourse = (courses)dataGridViewCourses.SelectedRows[0].DataBoundItem;
                FormCoursesAdd form = new FormCoursesAdd(labeld, selectedCourse);
                OpenChildForm(form);
            }
            else if (e.ColumnIndex == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Estas segur que vols esborrar aquest curs?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    dataGridViewCourses.CurrentRow.Selected = true;
                    CoursesORM.Delete((courses)dataGridViewCourses.SelectedRows[0].DataBoundItem);
                    bindingSourceCourses.DataSource = CoursesORM.Select();
                    addPoint();
                }
            }
        }
    }
    
}


