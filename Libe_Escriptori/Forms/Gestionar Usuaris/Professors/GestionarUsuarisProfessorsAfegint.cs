﻿using System;
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
        private String textBoxHintDni = " DNI";
        public GestionarUsuarisProfessorsAfegint(Label labelRuta)
        {
            InitializeComponent();
            labelRuta.Text = "Gestionar Usuaris/Gestionar Professors/Afegint";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBoxAllDepartments.SelectedItems)
            {
                if (!listBoxteacherDespartments.Items.Contains(selectedItem))
                {
                    listBoxteacherDespartments.Items.Add(selectedItem);
                }
            }
            listBoxAllDepartments.ClearSelected();
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            while (listBoxteacherDespartments.SelectedItems.Count > 0) {
                listBoxteacherDespartments.Items.Remove(listBoxteacherDespartments.SelectedItems[0]);
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
    }
}
