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
    public partial class ProfilePic : UserControl
    {
        string imageName;
        public ProfilePic(string imageName)
        {
            InitializeComponent();
            this.imageName = imageName;
            pictureBox1.BackgroundImage = Image.FromFile(@"..\..\ImagesProfile\" + imageName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserDesktopOrm.UpdateImage(imageName);
            FormFotosPerfil.imageSelected = imageName;
        }
    }
}
