using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Gestionar_Usuaris.Professors
{
    public partial class GestionarUsuarisProfessorsAfegint : Form
    {
        public GestionarUsuarisProfessorsAfegint()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBoxAllDepartments.SelectedItems)
            {
                if (!listBoxteacherDespartments.Items.Contains(selectedItem))
                {
                    listBoxteacherDespartments.Items.Add(selectedItem);
                }
            }
            listBoxAllDepartments.ClearSelected();
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            while (listBoxteacherDespartments.SelectedItems.Count > 0) {
                listBoxteacherDespartments.Items.Remove(listBoxteacherDespartments.SelectedItems[0]);
            }
        }
    }
}
