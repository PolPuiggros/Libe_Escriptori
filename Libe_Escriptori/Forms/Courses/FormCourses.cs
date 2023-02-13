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
        public FormCourses()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
