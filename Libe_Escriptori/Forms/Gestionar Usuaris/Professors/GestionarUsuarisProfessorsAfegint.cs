using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Usuaris.Profesors;
using Libe_Escriptori.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Libe_Escriptori.Forms.Gestionar_Usuaris.Professors
{
    public partial class GestionarUsuarisProfessorsAfegint : Form
    {
        private String textBoxHintName = " Nom";
        private String textBoxHintSurnname1 = " 1r Cognom";
        private String textBoxHintSurnname2 = " 2n Cognom";
        private String textBoxHintEmail = " Email";
        private String textBoxHintPhone = " Tel";
        Label ruta;
        BindingList<departments> listDepartaments = new BindingList<departments>();
        private profesors _profesor;
        bool adding;

        public GestionarUsuarisProfessorsAfegint(Label labelRuta)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Usuaris/Gestionar Professors/Afegint";
            this.ruta = labelRuta;
            adding = true;
        }

        public GestionarUsuarisProfessorsAfegint(Label labelRuta, profesors _profesor)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Usuaris/Gestionar Professors/Editant";
            this.ruta = labelRuta;
            this._profesor = _profesor;
            adding = false;
        }

        private void GestionarUsuarisProfessorsAfegint_Load(object sender, EventArgs e)
        {
            bindingSourceDepartments.DataSource = DepartmentsOrm.Select(true);
            if (!adding)
            {
                textBoxName.Text = _profesor.name;
                textBoxName.ForeColor = Color.Black;
                textBoxSurname1.Text = _profesor.surname1;
                textBoxSurname1.ForeColor = Color.Black;
                textBoxSurname2.Text = _profesor.surname2;
                textBoxSurname2.ForeColor = Color.Black;
                textBoxEmail.Text = _profesor.email;
                textBoxEmail.ForeColor = Color.Black;
                textBoxPhone.Text = _profesor.phone_number;
                textBoxPhone.ForeColor = Color.Black;
                foreach (departments department in _profesor.departments)
                {
                    if (listDepartaments.FirstOrDefault(d => d.id == department.id) == null)
                    {
                        listDepartaments.Add(department);
                    }
                }
                listBoxteacherDespartments.ValueMember = "id";
                listBoxteacherDespartments.DisplayMember = "name";
                listBoxteacherDespartments.DataSource = listDepartaments;
            }
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
            Utilities.textBoxSearch_Enter(textBoxName, textBoxHintName);
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Leave(textBoxName, textBoxHintName);
        }

        private void textBoxSurname1_Enter(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Enter(textBoxSurname, textBoxHintSurnname);
        }

        private void textBoxSurname1_Leave(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Leave(textBoxSurname1, textBoxHintSurnname1);
        }

        private void textBoxSurname2_Enter(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Enter(textBoxSurname2, textBoxHintSurnname2);
        }

        private void textBoxSurname2_Leave(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Leave(textBoxSurname2, textBoxHintSurnname2);
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Enter(textBoxEmail, textBoxHintEmail);
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Leave(textBoxEmail, textBoxHintEmail);
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Enter(textBoxPhone, textBoxHintPhone);
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            Utilities.textBoxSearch_Leave(textBoxPhone, textBoxHintPhone);
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            if (Validations.CheckEmail(textBoxEmail.Text))
            {
                if (Validations.CheckPhone(textBoxPhone.Text))
                {
                    if (adding)
                    {
                        users _users = new users();
                        _users.username = textBoxName.Text.Substring(0, 1).ToLower() + textBoxSurname1.Text.ToLower() + textBoxSurname2.Text.Substring(0, 1).ToLower();
                        int id_user;
                        int autoincrement = 1;
                        do
                        {
                            id_user = UsersOrm.Select(_users.username);
                            if (id_user != 0)
                            {
                                _users.username = textBoxName.Text.Substring(0, 1).ToLower() + textBoxSurname1.Text.ToLower() + textBoxSurname2.Text.Substring(0, 1).ToLower() + autoincrement;
                            }
                            autoincrement++;
                        } while (id_user != 0);
                        _users.password = Blowfish.encriptarContrasenya(textBoxName.Text + textBoxPhone.Text);
                        _users.type = 2;
                        _users.active = true;
                        UsersOrm.Insert(_users);

                        profesors _profesors = new profesors();

                        _profesors.id = UsersOrm.Select(_users.username);
                        _profesors.name = textBoxName.Text;
                        _profesors.surname1 = textBoxSurname1.Text;
                        _profesors.surname2 = textBoxSurname2.Text;
                        _profesors.email = textBoxEmail.Text;
                        _profesors.phone_number = textBoxPhone.Text;
                        _profesors.departments = listBoxteacherDespartments.Items.Cast<departments>().ToList();
                        _profesors.active = true;
                        _profesors.created_timestamp = DateTime.Now;
                        ProfesorsOrm.Insert(_profesors);
                    }
                    else
                    {
                        ProfesorsOrm.Update(_profesor, textBoxName.Text, textBoxSurname1.Text, textBoxSurname2.Text, textBoxEmail.Text, textBoxPhone.Text, listBoxteacherDespartments.Items.Cast<departments>().ToList());
                    }
                    this.Close();
                } else
                {
                    MessageBox.Show("Format del Telefon incorrecte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            } else
            {
                MessageBox.Show("Format de l'Email incorrecte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ruta.Text = "Gestionar Usuaris/Gestionar Professors";
        }
    }
}
