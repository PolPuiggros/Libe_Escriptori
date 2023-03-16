using System;
using System.Drawing;
using System.Windows.Forms;

namespace Libe_Escriptori
{
    public partial class MainForm : Form
    {
        Button previousButton;
        private bool mouseDown;
        private Point lastLocation;
        private Form activeForm;
        private Button currentButton;
        //MID PANEL SIZE: 1005; 650
        //POPUP SIZE!!!! 664; 495

        public MainForm()
        {
            InitializeComponent();
            customDesign();
            previousButton = buttonInici;
            panelLogs.Visible = false;
        }
        private void customDesign()
        {
            selectedEntry(buttonInici);
            panelUsuaris.Visible = false;
            panelCentreSubmenu.Visible = false;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTot.Controls.Add(childForm);
            panelTot.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

            if (activeForm != null)
            {
                activeForm.Close();
                currentButton = null;
            }
            labelRuta.Text = "Inici";
        }

        private void buttonGestionarUsuaris_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarUsuaris, previousButton, false);
            selectedEntry(buttonGestionarUsuaris);
            previousButton = buttonGestionarUsuaris;
            showSubMenu(panelUsuaris);
            labelRuta.Text = "Gestionar Usuaris";
        }
        private void buttonGestionarAlumnes_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarAlumnes, previousButton, true);
            selectedEntry(buttonGestionarAlumnes);
            previousButton = buttonGestionarAlumnes;
            OpenChildForm(new Forms.Gestionar_Usuaris.GestionarUsuarisAlumnes(labelRuta), sender);
            labelRuta.Text = "Gestionar Usuaris/Gestionar Alumnes";
        }

        private void buttonGestionarProfessors_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarProfessors, previousButton, true);
            selectedEntry(buttonGestionarProfessors);
            previousButton = buttonGestionarProfessors;
            OpenChildForm(new Forms.Gestionar_Usuaris.GestionarUsuarisProfessors(labelRuta), sender);
            labelRuta.Text = "Gestionar Usuaris/Gestionar Professors";
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarCursos, previousButton, false);
            selectedEntry(buttonGestionarCursos);
            previousButton = buttonGestionarCursos;
            hideSubMenu();
            OpenChildForm(new Forms.Courses.FormCourses(labelRuta), sender);
            labelRuta.Text = "Gestionar Cursos";
        }

        private void buttonGestionarGrups_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonGestionarGrups, previousButton, false);
            selectedEntry(buttonGestionarGrups);
            previousButton = buttonGestionarGrups;
            hideSubMenu();
            OpenChildForm(new Forms.Groups.FormGroups(labelRuta), sender);
            labelRuta.Text = "Gestionar Grups";
        }

        private void buttonCentre_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonCentre, previousButton, false);
            selectedEntry(buttonCentre);
            previousButton = buttonCentre;
            showSubMenu(panelCentreSubmenu);
            labelRuta.Text = "Centre";
        }
        private void buttonZonesValidables_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonZonesValidables, previousButton, true);
            selectedEntry(buttonZonesValidables);
            previousButton = buttonZonesValidables;
            OpenChildForm(new Forms.Centres.FormCentreZonesValidables(labelRuta), sender);
            labelRuta.Text = "Centre/Zones Validables";
        }
        private void buttonDepartamentsCentre_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonDepartamentsCentre, previousButton, true);
            selectedEntry(buttonDepartamentsCentre);
            previousButton = buttonDepartamentsCentre;
            OpenChildForm(new Forms.Centres.FormCentreDepartaments(), sender);
            labelRuta.Text = "Centre/Departaments";
        }

        private void buttonCalendariCentre_Click(object sender, EventArgs e)
        {
            DefaultButton(buttonCalendariCentre, previousButton, true);
            selectedEntry(buttonCalendariCentre);
            previousButton = buttonCalendariCentre;
            OpenChildForm(new Forms.Centres.FormCalendari(), sender);
            labelRuta.Text = "Centre/Calendari";
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estàs Segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void buttonInbox_Click(object sender, EventArgs e)
        {
            if(panelLogs.Visible == true)
            {
                panelLogs.Visible = false;
            }
            else
            {
                OpenLogsForm(new popupLog(), sender);
            }
            
        }

        private void OpenLogsForm(popupLog popupLog, object sender)
        {
            if (activeForm != null)
            {
                activeForm.SendToBack();
            }
            panelLogs.Visible = true;
            popupLog.TopLevel = false;
            popupLog.Dock = DockStyle.Fill;
            panelLogs.Controls.Add(popupLog);
            panelLogs.Tag = popupLog;
            popupLog.BringToFront();
            popupLog.Show();
        }
    }
}