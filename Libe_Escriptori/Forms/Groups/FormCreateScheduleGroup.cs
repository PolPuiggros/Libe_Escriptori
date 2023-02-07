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
    public partial class FormCreateScheduleGroup : Form
    {
        Button previousSelectedButton;
        Button actualSelectedButton;
        public FormCreateScheduleGroup()
        {
            InitializeComponent();
            previousSelectedButton = buttonModul1;
        }

        public void selectedButton(Button button)
        {
            previousSelectedButton = actualSelectedButton;
            actualSelectedButton = button;

            changeButtonColor(previousSelectedButton, Color.White);
            changeButtonColor(actualSelectedButton, Color.Red);
        }

        public void changeButtonColor(Button button, Color color)
        {
            button.BackColor = color;
        }

        private void buttonModul1_Click(object sender, EventArgs e)
        {
            actualSelectedButton = buttonModul1;
            selectedButton(buttonModul1);
        }
    }

    
}
