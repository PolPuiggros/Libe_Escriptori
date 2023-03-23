using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
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

namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    public partial class GestionarUsuarisAlumnes : Form
    {
        private String textBoxHint = " Introdueix dades clau de l'usuari ex. DNI, Cognom...";
        Form activeForm;
        Label label;
        public delegate void DoEvent();
        public event DoEvent addPoint;
        private groups filterGroup;

        public GestionarUsuarisAlumnes(Label labelRuta)
        {
            InitializeComponent();
            label = labelRuta;
            
        }

        private void GestionarUsuarisAlumnes_Load(object sender, EventArgs e)
        {
            bindingSourceStudents.DataSource = AlumnesOrm.Select(true);

            List<groups> listG = GroupsOrm.Select();
            List<groupComboBox> listCombo = new List<groupComboBox>();

            foreach(groups g in listG)
            {
                courses c = CoursesORM.Select(g.course_id);
                listCombo.Add(new groupComboBox(g.id, c.abreviation + g.grade + g.group_letter));
            }

            comboBoxFilter.DataSource = listCombo;
            comboBoxFilter.DisplayMember = "group";
            comboBoxFilter.ValueMember = "id";

            
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
            panelGestionarUsuaris.Controls.Add(childForm);
            panelGestionarUsuaris.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                OpenChildForm(new GestionarUsuarisAlumnesAfegint(label, (students)dataGridView1.SelectedRows[0].DataBoundItem));
            } else if(e.ColumnIndex == 9)
            {
                DialogResult dialogResult = MessageBox.Show("Estas segur que vols borrar l'alumne?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    AlumnesOrm.Delete((students)dataGridView1.SelectedRows[0].DataBoundItem);
                    refreshDGV();
                }
            }
        }

        private void refreshDGV()
        {
            textBoxFiltres.Text = textBoxHint;
            bindingSourceStudents.DataSource = AlumnesOrm.Select(true);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionarUsuarisAlumnesAfegint(label));
        }   

        private void textBoxFiltres_TextChanged(object sender, EventArgs e)
        {
            
            string value = textBoxFiltres.Text.Trim();
            List<students> filteredList;
            if (value.Contains(','))
            {
                var values = textBoxFiltres.Text.Split(',').Select(p => p.Trim()).ToList();
                
                List<List<students>> partFilteredList = new List<List<students>>();
                foreach (string v in values)
                {
                    
                    if (v.Any(char.IsDigit))
                    {
                        partFilteredList.Add(Orm.db.students
                                                  .Where(c => c.active == true && c.dni.ToString().Contains(v))
                                                  .ToList());
                    }
                    else
                    {
                        partFilteredList.Add(Orm.db.students
                                               .Where(c => c.active == true && (c.name.Contains(v) || c.surname.Contains(v)))
                                               .ToList());
                    }

                }

                filteredList = partFilteredList[0];
                for (int i = 1; i < partFilteredList.Count; i++)
                {
                    filteredList = filteredList.Intersect(partFilteredList[i]).ToList();
                }


            }
            else
            {
                if (value.Any(char.IsDigit))
                {
                    filteredList = Orm.db.students
                                        .Where(c => c.active == true && c.dni.ToString().Contains(value))
                                        .ToList();
                }
                else
                {
                    filteredList = Orm.db.students
                       .Where(c => c.active == true && (c.name.Contains(value) || c.surname.Contains(value)))
                       .ToList();
                }
            }
            
            bindingSourceStudents.DataSource = filteredList;
            
           
            
        }

        private void textBoxFiltres_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxFiltres, textBoxHint);
        }

        private void textBoxFiltres_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxFiltres, textBoxHint);
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            bindingSourceStudents.DataSource = AlumnesOrm.SelectStudentsGroup((int)comboBoxFilter.SelectedValue);
        }
    }

    public class groupComboBox
    {
        public string group { get; set; }
        public int id { get; set; }

        public groupComboBox(int id, string group)
        {
            this.id = id;
            this.group = group;
        }
    }
}
