using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using Libe_Escriptori.Models.Usuaris.Alumnes;
using Libe_Escriptori.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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
        private String textBoxHintSurnname1 = "1r Cognom";
        private String textBoxHintSurnname2 = "2n Cognom";
        private String textBoxHintEmail = "Email";
        private String textBoxHintPhone = "Tel";
        private String textBoxHintDni = "DNI";
        Label ruta;
        List<units> listUnits = new List<units>();
        students _student = new students();
        bool adding;
        public GestionarUsuarisAlumnesAfegint(Label ruta)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Usuaris/Gestionar Alumnes/Afegint";
            this.ruta = ruta;
            adding = true;
        }
        public GestionarUsuarisAlumnesAfegint(Label ruta, students _student)
        {
            InitializeComponent();
            ruta.Text = "Gestionar Usuaris/Gestionar Alumnes/Editant";
            this.ruta = ruta;
            this._student = _student;
            adding = false;
        }
        private void GestionarUsuarisAlumnesAfegint_Load(object sender, EventArgs e)
        {
            bindingSourceCourses.DataSource = CoursesORM.Select();
            if (!adding)
            {
                textBoxName.Text = _student.name;
                textBoxName.ForeColor = Color.Black;
                textBoxSurname1.Text = _student.surname;
                textBoxSurname1.ForeColor = Color.Black;
                textBoxSurname2.Text = _student.surname2;
                textBoxSurname2.ForeColor = Color.Black;
                textBoxEmail.Text = _student.email;
                textBoxEmail.ForeColor = Color.Black;
                textBoxPhone.Text = _student.phone_number;
                textBoxPhone.ForeColor = Color.Black;
                textBoxDni.Text = _student.dni;
                textBoxDni.ForeColor = Color.Black;
                checkBoxAutoregister.Checked = _student.autoregister;
                checkBoxRepeater.Checked = _student.has_repeated;
            } else
            {
                comboBoxCourse.SelectedIndex = -1;
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
            TextBoxDesign.textBoxSearch_Enter(textBoxSurname1, textBoxHintSurnname1);
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxSurname1, textBoxHintSurnname1);
        }
        private void textBoxSurname2_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxSurname2, textBoxHintSurnname2);
        }

        private void textBoxSurname2_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxSurname2, textBoxHintSurnname2);
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
            if (Validations.CheckDNI(textBoxDni.Text))
            {
                if(Validations.CheckPhone(textBoxPhone.Text))
                {
                    if(Validations.CheckEmail(textBoxEmail.Text))
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

                            students _students = new students();
                            _students.id = UsersOrm.Select(_users.username);
                            _students.name = textBoxName.Text;
                            _students.surname = textBoxSurname1.Text;
                            _students.surname2 = textBoxSurname2.Text;
                            _students.email = textBoxEmail.Text;
                            _students.dni = textBoxDni.Text;
                            _students.phone_number = textBoxPhone.Text;
                            _students.autoregister = checkBoxAutoregister.Checked;
                            _students.has_repeated = checkBoxRepeater.Checked;
                            _students.units = listUnits;
                            _students.active = true;
                            _students.created_timestamp = DateTime.Now;
                            AlumnesOrm.Insert(_students);
                        }
                        else
                        {
                            _student.name = textBoxName.Text;
                            _student.surname = textBoxSurname1.Text;
                            _student.surname2 = textBoxSurname2.Text;
                            _student.email = textBoxEmail.Text;
                            _student.dni = textBoxDni.Text;
                            _student.phone_number = textBoxPhone.Text;
                            _student.autoregister = checkBoxAutoregister.Checked;
                            _student.has_repeated = checkBoxRepeater.Checked;
                            _student.units = listUnits;
                            _student.active = true;
                            AlumnesOrm.Update(_student);
                        }
                        this.Close();
                    } else 
                    {
                        MessageBox.Show("Format de l'Email incorrecte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Format del Telefon incorrecte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
               MessageBox.Show("Format del DNI incorrecte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ruta.Text = "Gestionar Usuaris/Gestionar Alumnes";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> unitsSplited = new List<string>();
            foreach (string selectedItem in listBoxAllUnits.SelectedItems)
            {
                string[] unitSplited = selectedItem.Split(new[] { ": " }, StringSplitOptions.None);
               
                if (listUnits.FirstOrDefault(d => d.name == unitSplited[1]) == null)
                {
                    units _unit = UnitsORM.Select(unitSplited[1]);
                    listUnits.Add(_unit);
                }
            }
            List<string> _formatedUnitName = formatUnitName(listUnits);
            listBoxStudentUnits.DataSource = _formatedUnitName;

            listBoxAllUnits.ClearSelected();
        }

        private void buttonDeleteUnit_Click(object sender, EventArgs e)
        {
            int count = listBoxStudentUnits.SelectedItems.Count;
            while (count > 0)
            {
                listUnits.RemoveAt(listBoxStudentUnits.SelectedIndex);
                List<string> _formatedUnitName = formatUnitName(listUnits);
                listBoxStudentUnits.DataSource = _formatedUnitName;
                count--;
            }
            listBoxStudentUnits.ClearSelected();
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudentUnits.DataSource = null;
            listUnits.Clear();
            if (comboBoxCourse.SelectedValue != null)
            {
                int _course_id = Int32.Parse(comboBoxCourse.SelectedValue.ToString());
                List<modules> _modules = ModulesORM.Select(_course_id);
                List<units> _units = new List<units>();
                foreach (modules _module in _modules)
                {
                    _units.AddRange(UnitsORM.Select(_module.id));
                }
                List<string> _formatedUnitName = formatUnitName(_units);
                listBoxAllUnits.DataSource = _formatedUnitName;
            }
        }
        private List<string> formatUnitName(List<units> _units)
        {
            string unitAbbr, unitName, moduleCode;
            List<string> _formatedUnitName = new List<string>();
            foreach (units _unit in _units)
            {
                unitAbbr = _unit.abreviation;
                unitName = _unit.name;
                moduleCode = _unit.modules.code;
                _formatedUnitName.Add(moduleCode + " -> " + unitAbbr + ": " + unitName);
            }
            return _formatedUnitName;
        }
    }
}
