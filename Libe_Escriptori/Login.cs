using BCrypt.Net;
using Libe_Escriptori.Models.Login;
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
        //USERNAME --> politecnics
        //PASSWORD --> politecnics
        public Login()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password;
            password = LoginOrm.Select(true, textBoxUsername.Text);
            if (password != null && Blowfish.verificarContra(password, textBoxPassword.Text))
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No has introduit bé el correu o la contrasenya", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
