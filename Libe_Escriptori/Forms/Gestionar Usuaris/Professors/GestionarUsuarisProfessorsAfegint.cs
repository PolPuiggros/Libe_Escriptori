using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Usuaris.Profesors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Gestionar_Usuaris.Professors
{
    public partial class GestionarUsuarisProfessorsAfegint : Form
    {
        private String textBoxHintName = " Nom";
        private String textBoxHintSurnname = " Cognoms";
        private String textBoxHintEmail = " Email";
        private String textBoxHintPhone = " Tel";

        BindingList<departments> listDepartaments = new BindingList<departments>();

        public GestionarUsuarisProfessorsAfegint(Label labelRuta)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Usuaris/Gestionar Professors/Afegint";
        }

        private void GestionarUsuarisProfessorsAfegint_Load(object sender, EventArgs e)
        {
            bindingSourceDepartments.DataSource = DepartmentsOrm.Select(true);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (departments selectedItem in listBoxAllDepartments.SelectedItems)
            {
                if (listDepartaments.FirstOrDefault(d => d.id == selectedItem.id) == null)
                {
                    listDepartaments.Add(selectedItem);
                }
            }
            listBoxteacherDespartments.ValueMember = "id";
            listBoxteacherDespartments.DisplayMember = "name";
            listBoxteacherDespartments.DataSource = listDepartaments;

            listBoxAllDepartments.ClearSelected();
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            int count = listBoxteacherDespartments.SelectedItems.Count;
            while (count > 0) {
                listDepartaments.RemoveAt(listBoxteacherDespartments.SelectedIndex);
                listBoxteacherDespartments.DataSource = listDepartaments;
                count--;
            }
            listBoxteacherDespartments.ClearSelected();
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

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            string[] surnames = textBoxSurname.Text.Split(' ', (char)2);

            users _users = new users();
            _users.username = textBoxName.Text.Substring(0,1).ToLower() + surnames[0].ToLower() + surnames[1].Substring(0,1).ToLower();
            _users.password = Blowfish.encriptarContrasenya(textBoxName.Text + textBoxPhone.Text);
            _users.type = 2;
            _users.active = true;
            UsersOrm.Insert(_users);

            profesors _profesors = new profesors();

            _profesors.id = UsersOrm.Select(_users.username);
            _profesors.name = textBoxName.Text;
            _profesors.surname1 = surnames[0];
            _profesors.surname2 = surnames[1];
            _profesors.email = textBoxEmail.Text;
            _profesors.phone_number = textBoxPhone.Text;
            _profesors.departments = listBoxteacherDespartments.Items.Cast<departments>().ToList();
            _profesors.active = true;
            _profesors.created_timestamp = DateTime.Now;
            ProfesorsOrm.Insert(_profesors);
        }
    }
}
