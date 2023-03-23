﻿using Libe_Escriptori.Forms.Gestionar_Usuaris;
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
        bool add = false;
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
                e.Value = _groups.students.Count(student => student.active).ToString();
            }
        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groups _groups = (groups)dataGridViewGroups.Rows[e.RowIndex].DataBoundItem;
            if (dataGridViewGroups.Columns[e.ColumnIndex].Name == "headerEdit")
            {
                OpenChildForm(new FormAddGroup(ruta,_groups,false));
            }
            else if (dataGridViewGroups.Columns[e.ColumnIndex].Name == "headerDelete")
            {
                GroupsOrm.Delete(_groups);
            }
        }
    }
}
