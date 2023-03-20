using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Usuaris.Alumnes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        List<groups> _groups = new List<groups>();
        students _student = new students();
        bool adding;
        public GestionarUsuarisAlumnesAfegint(Label ruta)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Usuaris/Gestionar Alumnes/Afegint";
            adding = true;
        }
        public GestionarUsuarisAlumnesAfegint(Label ruta, students _student)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Usuaris/Gestionar Alumnes/Editant";
            this._student = _student;
            adding = false;
        }
        private void GestionarUsuarisAlumnesAfegint_Load(object sender, EventArgs e)
        {
            _groups = GroupsOrm.Select();
            List<string> _groupsAbreviation = new List<string>();
            string courseAbbr, grade, letter;
            int count = 0;
            foreach (groups group in _groups)
            {
                courseAbbr = group.courses.abreviation;
                grade = group.grade.ToString();
                letter = group.group_letter;
                _groupsAbreviation.Add(courseAbbr + grade + letter);
            }
            bindingSourceGroups.DataSource = _groupsAbreviation;
            if (!adding)
            {
                textBoxName.Text = _student.name;
                textBoxSurname.Text = _student.surname + " " + _student.surname2;
                textBoxEmail.Text = _student.email;
                textBoxPhone.Text = _student.phone_number;
                textBoxDni.Text = _student.dni;
                checkBoxAutoregister.Checked = _student.autoregister;
                checkBoxRepeater.Checked = _student.has_repeated;
                foreach (groups group in _groups)
                {
                    if (!adding)
                    {
                        if (_groupsAbreviation[count].Equals(_student.groups.courses.abreviation + _student.groups.grade + _student.groups.group_letter))
                        {
                            comboBoxGroups.SelectedIndex = count;
                        }
                    }
                    count++;
                }
            } else
            {
                comboBoxGroups.SelectedIndex = -1;
            }
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
            string[] surnames = textBoxSurname.Text.Split(' ', (char)2);
            if (adding) 
            {
                users _users = new users();
                _users.username = textBoxName.Text.Substring(0, 1).ToLower() + surnames[0].ToLower() + surnames[1].Substring(0, 1).ToLower();
                _users.password = Blowfish.encriptarContrasenya(textBoxName.Text + textBoxPhone.Text);
                _users.type = 2;
                _users.active = true;
                UsersOrm.Insert(_users);

                students _students = new students();
                _students.id = UsersOrm.Select(_users.username);
                _students.name = textBoxName.Text;
                _students.surname = surnames[0];
                _students.surname2 = surnames[1];
                _students.email = textBoxEmail.Text;
                _students.dni = textBoxDni.Text;
                _students.phone_number = textBoxPhone.Text;
                _students.autoregister = checkBoxAutoregister.Checked;
                _students.has_repeated = checkBoxRepeater.Checked;
                _students.groups = _groups.ElementAt(comboBoxGroups.SelectedIndex);
                _students.active = true;
                _students.created_timestamp = DateTime.Now;
                AlumnesOrm.Insert(_students);
            } else
            {
                AlumnesOrm.Update(_student, textBoxName.Text, surnames[0], surnames[1], textBoxEmail.Text, textBoxDni.Text, textBoxPhone.Text, checkBoxAutoregister.Checked, checkBoxRepeater.Checked, _groups.ElementAt(comboBoxGroups.SelectedIndex));
            }
        }
    }
}
