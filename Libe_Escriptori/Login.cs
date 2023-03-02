using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //String usuariDb = "";
            //String contraEncriptada = "";
            //if (textBoxUsername.Text.Equals(usuariDb))
            //{
            //    if (Blowfish.verificarContra(contraEncriptada, textBoxPassword.Text))
            //    {
            //        MainForm mf = new MainForm();
            //        mf.Show();
            //        this.Hide();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Els camps 'username' i / o 'password' són icorrectes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
