namespace Libe_Escriptori
{
    public partial class Form1 : Form
    {
        Button previousButton;

        public Form1()
        {
            InitializeComponent();
            customDesign();
            previousButton = buttonInici;
        }
        private void customDesign()
        {
            selectedEntry(buttonInici);
            panelUsuaris.Visible = false;
            panelCentreSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelUsuaris.Visible == true)
            {
                panelUsuaris.Visible = false;
            }     

            if (panelCentreSubmenu.Visible == true)
            {
                panelCentreSubmenu.Visible = false;
            }
               
        }
        private void showSubMenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void buttonInici_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonInici, previousButton, false);
            selectedEntry(buttonInici);
            previousButton = buttonInici;
            hideSubMenu();
        }

        private void buttonGestionarUsuaris_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarUsuaris, previousButton, false);
            selectedEntry(buttonGestionarUsuaris);
            previousButton = buttonGestionarUsuaris;
            showSubMenu(panelUsuaris);
        }
        private void buttonGestionarAlumnes_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarAlumnes, previousButton,true);
            selectedEntry(buttonGestionarAlumnes);
            previousButton = buttonGestionarAlumnes;
        }

        private void buttonGestionarProfessors_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarProfessors, previousButton, true);
            selectedEntry(buttonGestionarProfessors);
            previousButton = buttonGestionarProfessors;
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarCursos, previousButton, false);
            selectedEntry(buttonGestionarCursos);
            previousButton = buttonGestionarCursos;
            hideSubMenu();
        }

        private void buttonGestionarGrups_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarGrups, previousButton, false);
            selectedEntry(buttonGestionarGrups);
            previousButton = buttonGestionarGrups;
            hideSubMenu();
        }

        private void buttonCentre_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonCentre, previousButton, false);
            selectedEntry(buttonCentre);
            previousButton = buttonCentre;
            showSubMenu(panelCentreSubmenu);
        }
        private void buttonZonesValidables_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonZonesValidables, previousButton, true);
            selectedEntry(buttonZonesValidables);
            previousButton = buttonZonesValidables;
        }
        private void buttonDepartamentsCentre_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonDepartamentsCentre, previousButton, true);
            selectedEntry(buttonDepartamentsCentre);
            previousButton = buttonDepartamentsCentre;
        }

        private void buttonCalendariCentre_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonCalendariCentre, previousButton, true);
            selectedEntry(buttonCalendariCentre);
            previousButton = buttonCalendariCentre;
        }

        private void selectedEntry(Button btn)
        {
            btn.Font = new Font(btn.Font.FontFamily, 11);
            btn.BackColor = Color.FromArgb(164,168,241);
        }
        private void DefaultButton(Button btnActual, Button previousBtn, bool isChild)
        {
            if (btnActual.Text != previousBtn.Text)
            {
                if (!String.IsNullOrEmpty(previousBtn.AccessibleName))
                {
                    previousButton.Font = new Font(previousButton.Font.FontFamily, 10);
                    previousButton.BackColor = Color.White;
                }
                else
                {
                    previousButton.Font = new Font(previousButton.Font.FontFamily, 10);
                    previousBtn.BackColor = Color.Gainsboro;
                    
                }
            }
           
        }

        
    }
}