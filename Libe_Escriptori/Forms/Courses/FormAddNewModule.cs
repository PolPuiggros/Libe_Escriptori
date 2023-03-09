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
        private modules _module;
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
                bindingSourceUnits.DataSource = UnitsORM.Select(_module.id);
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Orm.db.SaveChanges();
        }
    }
}
