﻿using Libe_Escriptori.Forms.Gestionar_Usuaris.Professors;
using Libe_Escriptori.Models.Usuaris.Alumnes;
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

namespace Libe_Escriptori.Forms.Gestionar_Usuaris
{
    public partial class GestionarUsuarisProfessors : Form
    {
        private String textBoxHint = " Introdueix dades clau del professor ex. DNI, Cognom...";
        Form activeForm;
        Label labeld;
        public delegate void DoEvent();
        public event DoEvent addPoint;
        public GestionarUsuarisProfessors(Label label)
        {
            InitializeComponent();
            labeld = label;
        }
        private void GestionarUsuarisProfessors_Load(object sender, EventArgs e)
        {
            bindingSourceProfesors.DataSource = ProfesorsOrm.Select(true);
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
            panelGestionarUsuarisProfessors.Controls.Add(childForm);
            panelGestionarUsuarisProfessors.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dataGridViewTeachers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionarUsuarisProfessorsAfegint(labeld));
        }

        private void dataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                OpenChildForm(new GestionarUsuarisProfessorsAfegint(labeld, (profesors)dataGridViewTeachers.SelectedRows[0].DataBoundItem));
            }
            else if (e.ColumnIndex == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Estas segur que vols borrar el professor?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    dataGridViewTeachers.CurrentRow.Selected = true;
                    ProfesorsOrm.Delete((profesors)dataGridViewTeachers.SelectedRows[0].DataBoundItem);
                    refreshDGV();
                    addPoint();
                }
            }
        }

        private void refreshDGV()
        {
            bindingSourceProfesors.DataSource = ProfesorsOrm.Select(true);
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
