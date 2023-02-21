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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays(Color color)
        {
            InitializeComponent();
            BackGroundColor(color);
        }

        private void BackGroundColor(Color color)
        {
            this.BackColor = color;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            labelDay.Text = numday + "";
        }    
    }
}
