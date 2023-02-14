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
    public partial class FormCoursesEdit : Form
    {
        private String textBoxHintAbreviation = " Abreviació";
        private String textBoxHintName = " Nom Complert del curs";
        public FormCoursesEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
