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
    public partial class FormFotosPerfil : Form
    {
        List<string> fotos = new List<string>();
        public static string imageSelected;
        public delegate void DoEvent();
        public event DoEvent updateProfile;
        public FormFotosPerfil()
        {
            InitializeComponent();
            fillList();

        }

        private void display()
        {
            foreach (string foto in fotos)
            {
                if (flowLayoutPanel1.Controls.Count > 300)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    ProfilePic pp = new ProfilePic(foto);
                    pp.updateProfile += new ProfilePic.DoEvent(updateProfile);
                    pp.closeParent += new ProfilePic.DoEvent(close);
                    flowLayoutPanel1.Controls.Add(pp);
                }
            }
        }

        private void fillList()
        {
            for (int i = 1; i <= 9; i++)
            {
                fotos.Add("profile_pic" + i + ".png");
            }
        }

        private void FormFotosPerfil_Load(object sender, EventArgs e)
        {
            display();
        }
        void close() {
            this.Close();
        }
    }
}
