using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Courses
{
    public partial class FormAddNewModule : Form
    {
        private String textBoxHintAbreviation = " Abreviació";
        private String textBoxHintHours = " Hores";
        private String textBoxHintName = " Nom complert";
        private String textBoxHintAbreviationUF = " Abreviació UF";
        private String textBoxHintHoursUF = " Hores UF";
        private String textBoxHintNameUF = " Nom complert UF";
        private modules _module;
        private courses _course;
        private List<units> listUnits;
        private bool addingNew = false;
        public FormAddNewModule(Label label, modules _module)
        {
            InitializeComponent();
            label.Text = label.Text + "/Editar Mòdul";
            this._module = _module;
            
        }

        public FormAddNewModule(Label label)
        {
            InitializeComponent();
            label.Text = label.Text + "/Nou Mòdul";
            addingNew = true;
            listUnits = new List<units>();
            
        }

        private void textBoxAbbreviation_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxAbbreviation, textBoxHintAbreviation);
        }

        private void textBoxAbbreviation_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxAbbreviation, textBoxHintAbreviation);
        }

        private void textBoxHours_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxHours, textBoxHintHours);
        }

        private void textBoxHours_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxHours, textBoxHintHours);
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxName, textBoxHintName);
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxName, textBoxHintName);
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddNewModule_Load(object sender, EventArgs e)
        {
            if (!addingNew)
            {
                listUnits = UnitsORM.Select(_module.id);
                bindingSourceUnits.DataSource = UnitsORM.Select(_module.id);
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (addingNew)
            {
                modules _newModule = new modules();
                _newModule.name = textBoxName.Text;
                _newModule.code = textBoxAbbreviation.Text;
                _newModule.total_hours = int.Parse(textBoxHours.Text);
                _newModule.active = true;
                ModulesORM.InsertWithUnits(_newModule, listUnits);
            }
            else
            {
                _module.name = textBoxName.Text;
                _module.code = textBoxAbbreviation.Text;
                _module.total_hours = int.Parse(textBoxHours.Text);
                _module.active = true;
                ModulesORM.Update(_module);
            }
        }

        private void textBoxAbbrebiationUF_Enter(object sender, EventArgs e)
        {
            
            TextBoxDesign.textBoxSearch_Enter(textBoxAbbrebiationUF, textBoxHintAbreviationUF);
        }

        private void textBoxAbbrebiationUF_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxAbbrebiationUF, textBoxHintAbreviationUF);
        }

        private void textBoxNameUF_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxNameUF, textBoxHintNameUF);
        }

        private void textBoxNameUF_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxNameUF, textBoxHintNameUF);
        }

        private void textBoxHoursUF_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxHoursUF, textBoxHintHoursUF);
        }

        private void textBoxHoursUF_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxHoursUF, textBoxHintHoursUF);
        }

        private void buttonSaveUf_Click(object sender, EventArgs e)
        {
            units u = new units();
            u.abreviation = textBoxAbbrebiationUF.Text;
            u.total_hours = int.Parse(textBoxHoursUF.Text);
            u.name = textBoxNameUF.Text;
            
            u.active = true;
            if (addingNew)
            {
                
                u.module_id = -1;
                listUnits.Add(u);
                bindingSourceUnits.DataSource = null;
                bindingSourceUnits.DataSource = listUnits;
            }
            else
            {
                u.module_id = _module.id;
                UnitsORM.Insert(u);
                
            }
            
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
