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
    public partial class FormAddModuleDialog : Form
    {

        public string test;
        public FormAddModuleDialog()
        {
            //664; 495;
            InitializeComponent();
            test = "hola";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Your code that checks the form data and
            // eventually display an error message.
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
