using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    public partial class FormCalendari : Form
    {
        int month, year;
        CultureInfo ci = new CultureInfo("ca-ES");
        public FormCalendari()
        {
            InitializeComponent();
        }

        private void FormCalendari_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthName = ci.DateTimeFormat.GetMonthName(month);
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            
            labelDate.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOftheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) +1;

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDaysContainer.Controls.Add(ucblank);
            }

            for( int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanelDaysContainer.Controls.Add(ucdays);
            }
        }


        private void buttonSeguent_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDaysContainer.Controls.Clear();
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;

            String monthName = ci.DateTimeFormat.GetMonthName(month);
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            labelDate.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOftheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) +1;

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDaysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanelDaysContainer.Controls.Add(ucdays);
            }
        }
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDaysContainer.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year --;
            }
            month--;
            String monthName = ci.DateTimeFormat.GetMonthName(month);
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            labelDate.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOftheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) +1;

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDaysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanelDaysContainer.Controls.Add(ucdays);
            }
        }
    }
}
