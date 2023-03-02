using Libe_Escriptori.Forms.Gestionar_Usuaris;
using Libe_Escriptori.Models;
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

namespace Libe_Escriptori.Forms.Groups
{
    public partial class FormGroups : Form
    {
        Form activeForm;
        Label ruta;
        public FormGroups(Label ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGroups.Controls.Add(childForm);
            panelGroups.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNewGroup_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddGroup(ruta));
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Edit button column
            if (e.ColumnIndex == 5)
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
            if (e.ColumnIndex == 6)
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

        private void FormGroups_Load(object sender, EventArgs e)
        {
            bindingSourceGroups.DataSource = GroupsOrm.Select();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            groups _groups = (groups)dataGridViewGroups.Rows[e.RowIndex].DataBoundItem;
            //Columna de l'abreviació
            if (e.ColumnIndex == 0)
            {
                e.Value = _groups.courses.abreviation;
            }
            if (e.ColumnIndex == 3)
            {
                e.Value = _groups.profesors.name;
            }
            if (e.ColumnIndex == 4)
            {
                e.Value = _groups.students.Count.ToString();
            }
        }
    }
}
