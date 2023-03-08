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
        private int moduleId;
        private bool addingNew = false;
        public FormAddNewModule(Label label, int id)
        {
            InitializeComponent();
            label.Text = "Gestionar Cursos/Afegint Curs/Nou Mòdul";
            moduleId = id;
            if (id < 0)
            {
                addingNew = true;
            }
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
                modules _module = ModulesORM.SelectModule(moduleId);
                textBoxAbbreviation.Text = _module.code;
                textBoxHours.Text = _module.total_hours.ToString();
                textBoxName.Text = _module.name.ToString();

                bindingSourceUnits.DataSource = UnitsORM.Select(moduleId);
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Orm.db.SaveChanges();
        }
    }
}
