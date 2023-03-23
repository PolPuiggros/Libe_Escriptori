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

    public partial class PopupProfileImg : Form
    {
        List<string> pictures = new List<string>();
    
        public PopupProfileImg()
        {
            InitializeComponent();
            fillList();
        }

        private void fillList()
        {
           for (int i = 1; i <= 11; i++)
            {
                pictures.Add("profile_pic" + i+".png");
            }
        }
    }
}
