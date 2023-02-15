using Libe_Escriptori.Forms.Gestionar_Usuaris.Professors;
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
        public FormCourses(Label labelRuta)
        {
            InitializeComponent();
            labeld = labelRuta;
            InitGrid();
        }

        private void InitGrid()
        {
            Image editImage = Properties.Resources.user__3_;
            Image deleteImage = Properties.Resources.home1;

            dataGridViewCourses.Columns.Add(new DataGridViewImageColumn()
            {
                Image = editImage,
                Name = "edit",
                HeaderText = "Edit"
            });

            dataGridViewCourses.Columns.Add(new DataGridViewImageColumn()
            {
                Image = deleteImage,
                Name = "Delete",
                HeaderText = "Delete"
            });

            var myList = new List<CoursesDTO>();
            myList.Add(new CoursesDTO());
            myList.Add(new CoursesDTO());
            myList.Add(new CoursesDTO());
           
            dataGridViewCourses.DataSource = myList;


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
        }
    }
    
}

public class CoursesDTO{

    public string abreviacio { get; set; }
    public string nom { get; set; }
    public string departament { get; set; }
    public Image edit { get; set; }
    public Image delete { get; set; }

    public CoursesDTO()
    {
        abreviacio = "DAM";
        nom = "Desenvolupament Aplicacions multiplataforma";
        departament = "Informatica";

        
        
    }

}
