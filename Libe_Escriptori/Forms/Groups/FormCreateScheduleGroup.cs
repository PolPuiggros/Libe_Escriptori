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
    public partial class FormCreateScheduleGroup : Form
    {
        int previousSelectedButton;
        int actualSelectedButton;


        public FormCreateScheduleGroup()
        {
            InitializeComponent();
            initializeDataGrid();
        }

        private void initializeDataGrid()
        {
            dataGridViewSchedule.Rows.Add(6);

            dataGridViewSchedule[0, 0].Value = "8:40";
            dataGridViewSchedule[0, 1].Value = "9:40";
            dataGridViewSchedule[0, 2].Value = "10:40";
            dataGridViewSchedule[0, 3].Value = "11:40";
            dataGridViewSchedule[0, 4].Value = "12:00";
            dataGridViewSchedule[0, 5].Value = "13:00";


        }

        public void selectedButton(int index)
        {
           
           
        }

        
        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dataGridViewSchedule.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("No pots modificar les hores");
            }
            else
            {
                dataGridViewSchedule.CurrentCell.Value = actualSelectedButton.Text;
            }
        }
    }

    
}
