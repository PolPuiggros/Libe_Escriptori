using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
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
        private String textBoxHint = " Introdueix dades clau de l'usuari ex. DNI, Cognom...";
        Form activeForm;
        Label label;
        public delegate void DoEvent();
        public event DoEvent addPoint;
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
                    refreshDGV();
                }
            }
        }

        private void refreshDGV()
        {
            bindingSourceStudents.DataSource = AlumnesOrm.Select(true);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionarUsuarisAlumnesAfegint(label));
        }   

        private void textBoxFiltres_TextChanged(object sender, EventArgs e)
        {
            string dni = "";
            //string value = "%" + textBoxFiltres.Text + "%";
            string value = textBoxFiltres.Text;
            string filter = "name LIKE '%" + value + "%'"; //+ " OR surname LIKE " + value + " OR dni LIKE " + dni;
            if (textBoxFiltres.Text.Contains(","))
            {
                var values = textBoxFiltres.Text.Split(',');
                foreach(string v in values)
                {
                    if (v.Contains("1"))
                    {
                        dni = v;
                    }
                    filter += "OR name LIKE %" + v + "% OR surname LIKE %" + v + "%";
                }
            }
            
            bindingSourceStudents.Filter = filter;
           
            bindingSourceStudents.ResetBindings(false);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSourceStudents;
            
        }

        private void textBoxFiltres_Enter(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Enter(textBoxFiltres, textBoxHint);
        }

        private void textBoxFiltres_Leave(object sender, EventArgs e)
        {
            UtilitiesDesign.textBoxSearch_Leave(textBoxFiltres, textBoxHint);
        }
    }
}
