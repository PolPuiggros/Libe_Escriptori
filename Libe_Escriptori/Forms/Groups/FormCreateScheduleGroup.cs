using Libe_Escriptori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Groups
{
    
    public partial class FormCreateScheduleGroup : Form
    {
        string previousSelectedModul;
        string actualSelectedModul;
        int indexItem = -1;
        List<string> moduls = new List<string>();
        List<Color> colors = new List<Color>();
        schedules _schedule;
        List<TimeSpan> hours = new List<TimeSpan>();




        public FormCreateScheduleGroup(Label ruta)
        {
            InitializeComponent();
            hours = LessonsOrm.SelectHours();
            dataGridViewSchedule.RowCount = hours.Count;
            initializeDataGrid();
            AdjustRowHeight();
            ruta.Text = "Gestionar Grups/Afegint Grup/Creant Horari";
            fillColors();
            fillModuls();
        }

        private void initializeDataGrid()
        {
            _schedule = SchedulesOrm.Select().First();
            
            List<lessons> hourLessonsList = new List<lessons>();
            foreach (DataGridViewRow row in dataGridViewSchedule.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // 8:40
                    if (row.Index == 0)
                    {
                        TimeSpan eightFourty = new TimeSpan(8, 40, 0);
                        hourLessonsList = LessonsOrm.SelectLessonsAtHour(eightFourty);

                        if (cell.ColumnIndex == 0)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex].starting_hour;
                        }
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                    }


                    //9:40
                    if (row.Index == 1)
                    {
                        TimeSpan nineFourty = new TimeSpan(9, 40, 0);
                        hourLessonsList = LessonsOrm.SelectLessonsAtHour(nineFourty);

                        if (cell.ColumnIndex == 0)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex].starting_hour;
                        }
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                    }


                    //10:40
                    if (row.Index == 2)
                    {
                        TimeSpan tenFourty = new TimeSpan(10, 40, 0);
                        hourLessonsList = LessonsOrm.SelectLessonsAtHour(tenFourty);

                        if (cell.ColumnIndex == 0)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex].starting_hour;
                        }
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                    }



                    //12:00
                    if (row.Index == 3)
                    {
                        TimeSpan twelve = new TimeSpan(12, 0, 0);
                        hourLessonsList = LessonsOrm.SelectLessonsAtHour(twelve);

                        if (cell.ColumnIndex == 0)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex].starting_hour;
                        }
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                    }



                    //13:00
                    if (row.Index == 4)
                    {
                        TimeSpan one = new TimeSpan(13, 0, 0);
                        hourLessonsList = LessonsOrm.SelectLessonsAtHour(one);

                        if (cell.ColumnIndex == 0)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex].starting_hour;
                        }
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Value = hourLessonsList[cell.ColumnIndex - 1].modules.code;
                        }
                    }

                }
            }
            

        }


        
        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void listViewModuls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewModuls.SelectedItems.Count > 0)
            {
                String modulSeleccionat = listViewModuls.SelectedItems[0].Text;
                indexItem = listViewModuls.SelectedItems[0].Index;
                previousSelectedModul = actualSelectedModul;
                actualSelectedModul = modulSeleccionat;
            }
            

        }

        private void AdjustRowHeight()
        {
            
            int rowHeight = (this.dataGridViewSchedule.Size.Height - this.dataGridViewSchedule.ColumnHeadersHeight) / hours.Count;
            if (rowHeight > 0)
            {
                this.dataGridViewSchedule.RowTemplate.Height = rowHeight;
            }
        }

        private void dataGridViewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSchedule.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("No pots modificar les hores");
            }
            else
            {
                dataGridViewSchedule.CurrentCell.Value = actualSelectedModul;

                int column = dataGridViewSchedule.CurrentCell.ColumnIndex;
                int row = dataGridViewSchedule.CurrentCell.RowIndex;
                if (!dataGridViewSchedule[column, row].Value.Equals(""))
                {
                    String day = dataGridViewSchedule.Columns[column].HeaderText.ToString();
                    String hour = dataGridViewSchedule[0, row].Value.ToString();
                    String module = dataGridViewSchedule[column, row].Value.ToString();
                    // classroom


                    Form formDetailClass = new FormScheduleCellInfo(day,hour,module,"1.01");
                    formDetailClass.Show();
                }
                

                
            }
        }

        private void dataGridViewSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void fillColors()
        {
            colors.Add(Color.FromArgb(171, 222, 230));
            colors.Add(Color.FromArgb(203, 170, 203));
            colors.Add(Color.FromArgb(255, 255, 181));
            colors.Add(Color.FromArgb(255, 204, 182));
            colors.Add(Color.FromArgb(243, 176, 195));
            colors.Add(Color.FromArgb(198, 219, 218));
            colors.Add(Color.FromArgb(254, 225, 232));
            colors.Add(Color.FromArgb(254, 215, 195));
            colors.Add(Color.FromArgb(246, 234, 194));
            colors.Add(Color.FromArgb(236, 213, 227));
            colors.Add(Color.FromArgb(255, 150, 138));
            colors.Add(Color.FromArgb(255, 174, 165));
            colors.Add(Color.FromArgb(255, 197, 191));
            colors.Add(Color.FromArgb(255, 216, 190));
            colors.Add(Color.FromArgb(255, 200, 162));
            colors.Add(Color.FromArgb(212, 240, 240));
            colors.Add(Color.FromArgb(143, 202, 202));
            colors.Add(Color.FromArgb(204, 226, 203));
            colors.Add(Color.FromArgb(182, 207, 182));
            colors.Add(Color.FromArgb(151, 193, 169));
        }
        private void fillModuls()
        {
            moduls.Add("M01");
            moduls.Add("M02");
            moduls.Add("M03");
            moduls.Add("M04");
            moduls.Add("M05");
            moduls.Add("M06");
            moduls.Add("M07");
            moduls.Add("M08");
            moduls.Add("M09");
            moduls.Add("M10");
            moduls.Add("M11");
            moduls.Add("M12");
            moduls.Add("M13");
            moduls.Add("M14");
            moduls.Add("M15");
            moduls.Add("M16");
            moduls.Add("M17");
            moduls.Add("M18");
            moduls.Add("M19");
            moduls.Add("M20");



            foreach (string modul in moduls)
            {
                listViewModuls.Items.Add(modul);
            }
            
        }

        private void dataGridViewSchedule_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewSchedule.Rows[e.RowIndex].Selected = true;
                dataGridViewSchedule.CurrentCell = dataGridViewSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (dataGridViewSchedule.CurrentCell.ColumnIndex == 0)
                {
                    MessageBox.Show("No pots modificar les hores");
                }
                else
                {
                    int column = dataGridViewSchedule.CurrentCell.ColumnIndex;
                    int row = dataGridViewSchedule.CurrentCell.RowIndex;
                    if (dataGridViewSchedule[column, row].Value != null)
                    {
                        String day = dataGridViewSchedule.Columns[column].HeaderText.ToString();
                        String hour = dataGridViewSchedule[0, row].Value.ToString();
                        String module = dataGridViewSchedule[column, row].Value.ToString();
                        // classroom


                        Form formDetailClass = new FormScheduleCellInfo(day, hour, module, "1.01");
                        formDetailClass.Show();
                    }
                }
            }


            else if (e.Button == MouseButtons.Left)
            {
                if (dataGridViewSchedule.CurrentCell.ColumnIndex == 0)
                {
                    MessageBox.Show("No pots modificar les hores");
                }
                else
                {
                    if (indexItem != -1)
                    {
                        dataGridViewSchedule.CurrentCell.Value = actualSelectedModul;
                        dataGridViewSchedule.CurrentCell.Style.BackColor = colors[indexItem];
                    }

                }
            }
            
        }

        private void dataGridViewSchedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void FormCreateScheduleGroup_Load(object sender, EventArgs e)
        {
            
            bindingSourceLessons.DataSource = LessonsOrm.Select(_schedule.id);
            
        }
    }

    
}
