﻿using Libe_Escriptori.Properties;
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
        public GestionarUsuarisAlumnes()
        {
            InitializeComponent();
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

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new GestionarUsuarisAlumnesAfegint());
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxSearch, textBoxHint);
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxSearch, textBoxHint);
        }

        private void textBoxFilterCourse_Enter(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Enter(textBoxFilterCourse, textBoxHint);
        }

        private void textBoxFilterCourse_Leave(object sender, EventArgs e)
        {
            TextBoxDesign.textBoxSearch_Leave(textBoxFilterCourse, textBoxHint);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Edit button column
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;
                var h = 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.lapiz, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            // Delete button column
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
        }
    }
}
