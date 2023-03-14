using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
using Libe_Escriptori.Models.Usuaris.Profesors;
using Libe_Escriptori.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    public partial class FormCentreDepartaments : Form
    {
        private String textBoxHintNameDepartment = " Nom del departament";
        public FormCentreDepartaments()
        {
            InitializeComponent();
        }

        private void FormCentreDepartaments_Load(object sender, EventArgs e)
        {
            refreshDGV();
            bindingSourceCoordinator.DataSource = ProfesorsOrm.Select(true);
        }

        private void textBoxNomDepartament_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxNomDepartament, textBoxHintNameDepartment);
        }

        private void textBoxNomDepartament_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxNomDepartament, textBoxHintNameDepartment);
        }


        private void dataGridViewDepartments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                departments dep = (departments)dataGridViewDepartments.Rows[e.RowIndex].DataBoundItem;
                if (dep != null)
                {
                    e.Value = dep.profesors.name;
                }
                
            }
        }

        private void buttonGuardarDepartament_Click(object sender, EventArgs e)
        {
            departments _departments = new departments();

            _departments.name = textBoxNomDepartament.Text;
            _departments.profesors = (profesors)comboBoxCoordinador.SelectedItem;
            _departments.active = true;
            _departments.created_timestamp = DateTime.Now;

            DepartmentsOrm.Insert(_departments);
            refreshDGV();
        }

        private void refreshDGV()
        {
            bindingSourceDepartments.DataSource = DepartmentsOrm.Select(true);
        }

        private void dataGridViewDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                departments dept = (departments)dataGridViewDepartments.Rows[e.RowIndex].DataBoundItem;
                if (dept != null)
                {
                    DialogResult dia = MessageBox.Show("Estàs segur/a que vols esborrar el departament?", "Esborrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dia == DialogResult.OK)
                    {
                        DepartmentsOrm.Delete(dept);
                        refreshDGV();
                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                departments dept = (departments)dataGridViewDepartments.Rows[e.RowIndex].DataBoundItem;
                if (dept != null)
                {
                    PopupDept popup = new PopupDept(dept);
                    popup.ShowDialog();
                    
                }
            }
        }
    }
}
