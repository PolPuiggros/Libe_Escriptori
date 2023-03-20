using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Usuaris.Alumnes;
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

namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    public partial class GestionarUsuarisAlumnes : Form
    {
        private String textBoxHint = "  Búsqueda...";
        Form activeForm;
        Label label;
        public GestionarUsuarisAlumnes(Label labelRuta)
        {
            InitializeComponent();
            label = labelRuta;
            
        }

        private void GestionarUsuarisAlumnes_Load(object sender, EventArgs e)
        {
            bindingSourceStudents.DataSource = AlumnesOrm.Select(true);
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
            panelGestionarUsuaris.Controls.Add(childForm);
            panelGestionarUsuaris.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Edit button column
            if (e.ColumnIndex == 8)
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
            if (e.ColumnIndex == 9)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.ColumnIndex == 8)
                {
                    OpenChildForm(new GestionarUsuarisAlumnesAfegint(label, (students)dataGridView1.SelectedRows[0].DataBoundItem));
                } else if(e.ColumnIndex == 9)
                {
                    DialogResult dialogResult = MessageBox.Show("Estas segur que vols borrar l'alumne?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.OK)
                    {
                        dataGridView1.CurrentRow.Selected = true;
                        AlumnesOrm.Delete((students)dataGridView1.SelectedRows[0].DataBoundItem);
                    //Recargar
                    }
                }
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionarUsuarisAlumnesAfegint(label));
        }
    }
}
