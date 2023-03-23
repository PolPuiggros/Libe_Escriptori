using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
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

namespace Libe_Escriptori.Forms.Groups
{
    public partial class FormScheduleCellInfo : Form
    {
        lessons lesson;
        List<profesors> profesors;
        public FormScheduleCellInfo(String day, String hour, String module, int scheduleId)
        {
            InitializeComponent();
            // Buscar la lesson con el dia, hora y modulo
            lesson = LessonsOrm.SelectFromAttributes(day, hour, module, scheduleId);
            labelDay.Text = day;
            labelHour.Text = hour;  
            labelModul.Text = module;
            populateComboBox(lesson.classroom_id);
            populateListViews();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (profesors.Count > 0)
            {
                lesson.classroom_id = (int)comboBoxClass.SelectedValue;
                lesson.profesors.Clear();
                lesson.profesors = profesors;
                LessonsOrm.Update(lesson);
                this.Close();
            }
            else
            {
                MessageBox.Show("No pots guardar una classe sense cap professor");
            }
           
        }

        private void populateComboBox(int classroomId)
        {
            comboBoxClass.DataSource = AulesOrm.Select(true);
            comboBoxClass.DisplayMember = "name";
            comboBoxClass.ValueMember = "id";
            comboBoxClass.SelectedValue = classroomId;
        }

        private void populateListViews()
        {
            bindingSourceProfesors.DataSource = ProfesorsOrm.Select(true);
            profesors = lesson.profesors.ToList();
            listBoxLessonProfesors.DataSource = profesors;
            listBoxLessonProfesors.DisplayMember = "name";
            listBoxLessonProfesors.ValueMember = "id";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (profesors selectedItem in listBoxAllProfessors.SelectedItems)
            {
                if (profesors.FirstOrDefault(d => d.id == selectedItem.id) == null)
                {
                    profesors.Add(selectedItem);
                }
            }
            listBoxLessonProfesors.DataSource = null;
            listBoxLessonProfesors.DataSource = profesors;
            listBoxLessonProfesors.DisplayMember = "name";
            listBoxLessonProfesors.ValueMember = "id";

            listBoxAllProfessors.ClearSelected();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteDepartment_Click(object sender, EventArgs e)
        {
            profesors.Clear();
            listBoxLessonProfesors.DataSource = null;
            listBoxLessonProfesors.DataSource = profesors;
        }
    }
}
