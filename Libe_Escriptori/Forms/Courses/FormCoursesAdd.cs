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
        private Form activeForm;
        public FormCoursesAdd()
        {
            InitializeComponent();
        }

       

        private void buttonExistent_Click(object sender, EventArgs e)
        {
            using (FormAddModuleDialog f = new FormAddModuleDialog())
            {
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string custName = f.test;
                    
                }
            }
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
            OpenChildForm(new FormAddExistingModule());
        }
    }
}
