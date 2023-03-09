using Libe_Escriptori.Models;
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
            bindingSourceDepartments.DataSource = DepartmentsOrm.Select(true);
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

        private void dataGridViewDepartments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Edit button column
            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;
                var h = 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.bin, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            // Delete button column
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;
                var h = 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.bin, new Rectangle(x, y, w, h));
                e.Handled = true;
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
        }
    }
}
