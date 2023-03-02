using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank(Color color)
        {
            InitializeComponent();
            BackGroundColor(color);
        }

        private void BackGroundColor(Color color)
        {
            this.BackColor = color;
        }
    }
}
