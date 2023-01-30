namespace Libe_Escriptori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
        {
            panelUsuaris.Visible = false;
            panelCentreSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelUsuaris.Visible == true)
                panelUsuaris.Visible = false;
            if (panelCentreSubmenu.Visible == true)
                panelCentreSubmenu.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //USUARIS
            showSubMenu(panelUsuaris);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //CENTRES
            showSubMenu(panelCentreSubmenu);
        }

        //BUTONS SUBMENU

        private void button3_Click(object sender, EventArgs e)
        {
            //TOT
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TOT
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //TOT
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //TOT
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //TOT
            hideSubMenu();
        }
    }
}