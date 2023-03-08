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

namespace Libe_Escriptori.Forms.Courses
{
    public partial class FormCoursesAdd : Form
    {
        Label labeld;
        private String textBoxHintAbreviation = " Abreviació";
        private String textBoxHintName = " Nom Complert del curs";
        private Form activeForm;
        private int courseId;
        private bool addingNew = false;
        public FormCoursesAdd(Label labelRuta, int courseId)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Cursos/Afegint Curs";
            labeld = labelRuta;
            this.courseId = courseId;
            if (courseId < 0)
            {
                addingNew = true;
            }
        }

       

        private void buttonExistent_Click(object sender, EventArgs e)
        {
            using (FormAddExistingModuleDialog f = new FormAddExistingModuleDialog(labeld))
            {
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string custName = f.test;
                    
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
            OpenChildForm(new FormAddNewModule(labeld, -1));
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
                bindingSourceModules.DataSource = ModulesORM.Select(courseId);
            }

            
        }

        private void bindingSourceModules_CurrentChanged(object sender, EventArgs e)
        {

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
                OpenChildForm(new FormAddNewModule(labeld, selectedModule.id));
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

        private void panelCoursesAdd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
