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
    public partial class FormAddGroup : Form
    {
        private Form activeForm;
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void buttonManageStudents_Click_1(object sender, EventArgs e)
        {
            FormAddExistingStudentsToGroup faetg = new FormAddExistingStudentsToGroup();
            faetg.Show();
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
            panelAddGroup.Controls.Add(childForm);
            panelAddGroup.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonGestionarHorari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCreateScheduleGroup());
        }
    }
}
