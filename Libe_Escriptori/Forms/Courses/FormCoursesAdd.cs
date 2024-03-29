﻿using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using Libe_Escriptori.Models.Usuaris.Profesors;
using Libe_Escriptori.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Courses
{
    public partial class FormCoursesAdd : Form
    {
        Label labeld;
        private String textBoxHintAbreviation = " Abreviació";
        private String textBoxHintName = " Nom Complert del curs";
        private Form activeForm;
        private courses _course;
        private bool addingNew = false;
        private List<departments> listDepartments;
        public FormCoursesAdd(Label labelRuta, courses _course)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Cursos/Editar Curs";
            labeld = labelRuta;
            this._course = _course;
            
        }

        public FormCoursesAdd(Label labelRuta)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Cursos/Afegir Curs";
            labeld = labelRuta;
            addingNew = true;
            this._course = new courses();
        }

       

        private void buttonExistent_Click(object sender, EventArgs e)
        {
            using (FormAddExistingModuleDialog f = new FormAddExistingModuleDialog(labeld, _course))
            {
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    List<modules> listModules = f.listModules;
                    
                    foreach (modules module in listModules)
                    {
                        _course.modules.Add(module);
                    }
                    if (addingNew)
                    {
                        bindingSourceModules.DataSource = _course.modules;
                    }                 
                }
            }
        }

        private void textBoxAbbreviation_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxAbbreviation, textBoxHintAbreviation);
        }

        private void textBoxAbbreviation_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxAbbreviation, textBoxHintAbreviation);
        }

        private void textBoxFullName_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxFullName, textBoxHintName);
        }

        private void textBoxFullName_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxFullName, textBoxHintName);
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
            panelCoursesAdd.Controls.Add(childForm);
            panelCoursesAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (addingNew)
            {
                
                if (textBoxAbbreviation.Text != textBoxHintAbreviation && !String.IsNullOrEmpty(textBoxAbbreviation.Text) &&
                    textBoxFullName.Text != textBoxHintName && !String.IsNullOrEmpty(textBoxFullName.Text) && addNewCourse())
                {
                    addingNew = false;
                    OpenChildForm(new FormAddNewModule(labeld, _course));
                }
                else
                {
                    MessageBox.Show("Abans d'afegir moduls, omple els texts d'Abreviació i de Nom del curs");
                }
            }
            else
            {
                OpenChildForm(new FormAddNewModule(labeld, _course));
            }
        }

        private void FormCoursesAdd_Load(object sender, EventArgs e)
        {
            listDepartments = DepartmentsOrm.Select(true);
            bindingSourceDepartments.DataSource = DepartmentsOrm.Select(true);

            if (!addingNew)
            {
                bindingSourceModules.DataSource = ModulesORM.Select(_course.id);
                textBoxFullName.Text = _course.name;
                textBoxAbbreviation.Text = _course.abreviation;
                comboBoxDepartment.SelectedValue = _course.department_id;
            }

        }

        private void dataGridViewModules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                modules m = (modules)dataGridViewModules.Rows[e.RowIndex].DataBoundItem;
                if (m != null)
                {
                    e.Value = m.units.Count.ToString();
                }
                
            }
        }

        private void dataGridViewModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var selectedModule = (modules)dataGridViewModules.SelectedRows[0].DataBoundItem;
                FormAddNewModule add = new FormAddNewModule(labeld, _course, selectedModule);
                OpenChildForm(add);
            }
            else if (e.ColumnIndex == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Estas segur que vols esborrar aquest modul?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    dataGridViewModules.CurrentRow.Selected = true;
                    _course.modules.Remove((modules)dataGridViewModules.SelectedRows[0].DataBoundItem);
                    CoursesORM.Update(_course);

                    bindingSourceModules.DataSource = null;
                    bindingSourceModules.DataSource = ModulesORM.Select(_course.id);
                    
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBoxAbbreviation.Text) && textBoxAbbreviation.Text != textBoxHintAbreviation && !String.IsNullOrEmpty(textBoxFullName.Text) && textBoxFullName.Text != textBoxHintName && comboBoxDepartment.SelectedIndex >= 0)
            {
                addNewCourse();
                this.Close();
            }
            else
            {
                MessageBox.Show("Omple tots els camps");
            }
            
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedValue != null)
            {
                int professorId = listDepartments.Find(c => c.id == (int)comboBoxDepartment.SelectedValue).profesor_in_charge_id;
                
                textBoxCoordinator.Text = ProfesorsOrm.SelectFromId(professorId).name;
            }
        
        }

        private bool addNewCourse()
        {

            //TODO: Validations
            //TODO: If inserted return true, else false

            int hours = 0;

            _course.abreviation = textBoxAbbreviation.Text;
            _course.name = textBoxFullName.Text;
            _course.department_id = (int)comboBoxDepartment.SelectedValue;
            _course.active = true;


            foreach (modules m in _course.modules)
            {
                hours += m.total_hours;
            }

            _course.total_hours = hours;

            if (addingNew)
            {
                CoursesORM.Insert(_course);
            }
            else
            {
                CoursesORM.Update(_course);
            }

            return true;
            
        }

        private void panelCoursesAdd_Paint(object sender, PaintEventArgs e)
        {

        }
     
    }
}
