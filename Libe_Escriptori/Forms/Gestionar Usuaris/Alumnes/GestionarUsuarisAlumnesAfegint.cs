using Libe_Escriptori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    public partial class GestionarUsuarisAlumnesAfegint : Form
    {
        private String textBoxHintName = "Nom";
        private String textBoxHintSurnname = "Cognoms";
        private String textBoxHintEmail = "Email";
        private String textBoxHintPhone = "Tel";
        private String textBoxHintDni = "DNI";
        public GestionarUsuarisAlumnesAfegint(Label ruta)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Usuaris/Gestionar Alumnes/Afegint";
        }
        private void GestionarUsuarisAlumnesAfegint_Load(object sender, EventArgs e)
        {
           
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxName, textBoxHintName);
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxName, textBoxHintName);
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxSurname, textBoxHintSurnname);
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxSurname, textBoxHintSurnname);
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxEmail, textBoxHintEmail);
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxEmail, textBoxHintEmail);
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxPhone, textBoxHintPhone);
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxPhone, textBoxHintPhone);
        }

        private void textBoxDni_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxDni, textBoxHintDni);
        }

        private void textBoxDni_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxDni, textBoxHintDni);
        }
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            students _students = new students();

            string[] surnames = textBoxSurname.Text.Split(' ', (char)2);

            _students.name = textBoxName.Text;
            _students.surname = surnames[0];
            _students.surname2 = surnames[1];
            _students.email = textBoxEmail.Text;
            _students.dni = textBoxDni.Text;
            _students.phone_number = textBoxPhone.Text;
            _students.autoregister = checkBoxAutoregister.Checked;
            _students.has_repeated = checkBoxRepeater.Checked;
            _students.groups = (groups)comboBoxGroups.SelectedItem;
            _students.active = true;
            _students.created_timestamp = DateTime.Now;
        }
    }
}
