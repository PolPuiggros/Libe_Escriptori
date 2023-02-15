
﻿using Libe_Escriptori.Forms.Gestionar_Usuaris.Professors;

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

namespace Libe_Escriptori.Forms.Courses
{
    public partial class FormCourses : Form
    {
        Form activeForm;
        public FormCourses()
        {
            InitializeComponent();
        }


        private void InitGrid()
        {
            Image editImage = Properties.Resources.user__3_;
            Image deleteImage = Properties.Resources.home1;

            dataGridViewCourses.Columns.Add(new DataGridViewImageColumn()
            {
                Image = editImage,
                Name = "edit",
                HeaderText = "Edit"
            });

            dataGridViewCourses.Columns.Add(new DataGridViewImageColumn()
            {
                Image = deleteImage,
                Name = "Delete",
                HeaderText = "Delete"
            });

            var myList = new List<CoursesDTO>();
            myList.Add(new CoursesDTO());
            myList.Add(new CoursesDTO());
            myList.Add(new CoursesDTO());
           
            dataGridViewCourses.DataSource = myList;


        }
        private void OpenChildForm(Form childForm)

       

        private void button1_Click(object sender, EventArgs e)

        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCourses.Controls.Add(childForm);
            panelCourses.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCoursesAdd());
        }

        private void dataGridViewCourses_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int i = dataGridViewCourses.Columns.Count;
            // Edit button column
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;
                var h = 15;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.lapiz, new Rectangle(x,y,w,h));
                e.Handled = true;
            }

            // Delete button column
            if (e.ColumnIndex == 4)
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

