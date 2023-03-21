using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Usuaris.Profesors;
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
    public partial class PopupDept : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        departments department;
        public PopupDept(departments dept)
        {
            InitializeComponent();
            department = dept;
        }
        private void PopupDept_Load(object sender, EventArgs e)
        {
            bindingSourceProfes.DataSource = ProfesorsOrm.Select(true);
            textBox1.Text = department.name;
            comboBox1.SelectedValue = department.profesor_in_charge_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonGuardarCanvis_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                departments newDept = new departments();
                newDept.name = textBox1.Text;
                newDept.profesor_in_charge_id = (int)comboBox1.SelectedValue;
                DepartmentsOrm.Update(department.id, newDept);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El nom del departament no pot estar buit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
