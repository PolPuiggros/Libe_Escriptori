using Libe_Escriptori.Forms.Gestionar_Usuaris;
using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
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

namespace Libe_Escriptori.Forms.Groups
{
    public partial class FormGroups : Form
    {
        Form activeForm;
        Label ruta;
        bool add = false;
        List<groups> listGroups;
        public FormGroups(Label ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
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
            panelGroups.Controls.Add(childForm);
            panelGroups.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNewGroup_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddGroup(ruta));
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {
            courses emptyCourse = new courses();
            emptyCourse.abreviation = "Tots";
            List<courses> listCourses = new List<courses>();
            listCourses.Add(emptyCourse);
            listCourses.AddRange(CoursesORM.Select());

            bindingSourceGroups.DataSource = GroupsOrm.Select();
            bindingSourceCourses.DataSource = listCourses;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            groups _groups = (groups)dataGridViewGroups.Rows[e.RowIndex].DataBoundItem;
            //Columna de l'abreviació
            if (e.ColumnIndex == 0)
            {
                e.Value = _groups.courses.abreviation;
            }
            if (e.ColumnIndex == 3)
            {
                e.Value = _groups.profesors.name;
            }
            if (e.ColumnIndex == 4)
            {
                e.Value = _groups.students.Count(student => student.active).ToString();
            }
        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groups _groups = (groups)dataGridViewGroups.Rows[e.RowIndex].DataBoundItem;
            if (dataGridViewGroups.Columns[e.ColumnIndex].Name == "headerEdit")
            {
                OpenChildForm(new FormAddGroup(ruta,_groups,false));
            }
            else if (dataGridViewGroups.Columns[e.ColumnIndex].Name == "headerDelete")
            {
                GroupsOrm.Delete(_groups);
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedValue != null)
            {
                if (comboBoxFilter.SelectedIndex == 0)
                {
                    bindingSourceGroups.DataSource = GroupsOrm.Select();
                    comboBoxFilterGrade.DataSource = null;
                    comboBoxFilterLetter.DataSource = null;
                } else
                {
                    listGroups = GroupsOrm.SelectFromCourse((int)comboBoxFilter.SelectedValue);
                    List<string> grades = new List<string>();
                    List<string> group_letter = new List<string>();
                    grades.Add("Tots");
                    group_letter.Add("Tots");
                    foreach (groups g in listGroups)
                    {
                        if (!grades.Contains(g.grade.ToString()))
                        {
                            grades.Add(g.grade.ToString());
                        }
                        if (!group_letter.Contains(g.group_letter))
                        {
                            group_letter.Add(g.group_letter);
                        }

                    }
                    bindingSourceGroups.DataSource = null;
                    bindingSourceGroups.DataSource = listGroups;
                    comboBoxFilterGrade.DataSource = grades;
                    comboBoxFilterLetter.DataSource = group_letter;
                }
                
            }
           
        }

        private void comboBoxFilterGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterGrade.SelectedIndex == 0)
            {
                if (comboBoxFilter.SelectedValue != null)
                {
                    listGroups = GroupsOrm.SelectFromCourse((int)comboBoxFilter.SelectedValue);
                }
                else
                {
                    listGroups = GroupsOrm.Select();
                }

            } else
            {
                listGroups = listGroups.Where(g => g.grade.ToString() == (string)comboBoxFilterGrade.SelectedValue).ToList();
                
            }
            bindingSourceGroups.DataSource = listGroups;
        }

        private void comboBoxFilterLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterGrade.SelectedIndex == 0)
            {
                if (comboBoxFilter.SelectedValue != null)
                {
                    listGroups = GroupsOrm.SelectFromCourse((int)comboBoxFilter.SelectedValue);
                }
                else
                {
                    listGroups = GroupsOrm.Select();
                }

            }
            else
            {
                listGroups = listGroups.Where(g => g.group_letter == (string)comboBoxFilterLetter.SelectedValue).ToList();

            }
            bindingSourceGroups.DataSource = listGroups;
        }
    }
}
