using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using Libe_Escriptori.Models.Usuaris.Profesors;
using Libe_Escriptori.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
            TextBoxDesign.textBoxSearch_Enter(textBoxAbbreviation, textBoxHintAbreviation);
        }

        private void textBoxAbbreviation_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxAbbreviation, textBoxHintAbreviation);
        }

        private void textBoxFullName_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxFullName, textBoxHintName);
        }

        private void textBoxFullName_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxFullName, textBoxHintName);
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
            OpenChildForm(new FormAddNewModule(labeld));
        }

        private void dataGridViewModules_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Edit button column
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;
                var h = 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.bin, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            // Delete button column
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;
                var h = 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.bin, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void FormCoursesAdd_Load(object sender, EventArgs e)
        {
            if (!addingNew)
            {
                bindingSourceModules.DataSource = ModulesORM.Select(_course.id);
            }
            listDepartments = DepartmentsOrm.Select(true);
            bindingSourceDepartments.DataSource = DepartmentsOrm.Select(true);
            



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
                OpenChildForm(new FormAddNewModule(labeld, selectedModule));
            }
            else if (e.ColumnIndex == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Estas segur que vols esborrar aquest modul?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    dataGridViewModules.CurrentRow.Selected = true;
                    ModulesORM.Delete((modules)dataGridViewModules.SelectedRows[0].DataBoundItem);
                    dataGridViewModules.DataSource = CoursesORM.Select();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

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
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
