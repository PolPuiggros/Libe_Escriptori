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
        public FormCoursesAdd(Label labelRuta)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Cursos/Afegint Curs";
            labeld = labelRuta;
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
            OpenChildForm(new FormAddNewModule(labeld));
        }
    }
}
