using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori.Forms.Centres
{
    public partial class FormCalendari : Form
    {
        CultureInfo ci = new CultureInfo("ca-ES");
        int month, year;
        public static Color colorPicked = Color.White;

        //Arrays de dies "especials"
        public static List<holidays> allHolidays = new List<holidays>();
        public static DateTime fiCurs;
        public static DateTime iniciCurs;
        calendars calendari;
        public delegate void DoEvent();
        public event DoEvent addPoint;
        public static List<holidays> holiDaysOftheMonth;

        public FormCalendari()
        {
            InitializeComponent();
        }

        private void FormCalendari_Load(object sender, EventArgs e)
        {
            getData();
            displayDays();
        }

        private void getData()
        {
            allHolidays = CalendariOrm.Select();
            calendari = CalendariOrm.SelectCalendari();
            iniciCurs = calendari.starting_date;
            fiCurs = calendari.ending_date;
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthName = ci.DateTimeFormat.GetMonthName(month);
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            int iteratorHoliday = 0;
            labelDate.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            String dayOfWeek = startOfTheMonth.DayOfWeek.ToString("d");
            int daysOftheWeek = Convert.ToInt32(dayOfWeek);
            if (daysOftheWeek <= 0) daysOftheWeek = 1;
            int sunday = 5 - daysOftheWeek;
            int saturday = 6 - daysOftheWeek;
            holiDaysOftheMonth = getHolidaysOfTheMonth(startOfTheMonth, allHolidays);

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank(Color.FromKnownColor(KnownColor.Control));
                flowLayoutPanelDaysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                DateTime dia = new DateTime(year, month, i);
                if ((i + daysOftheWeek) % 7 == 0 || (i + daysOftheWeek - 1) % 7 == 0)
                {
                    UserControlDays ucdays = new UserControlDays(Color.FromArgb(255, 128, 128), labelDate);
                    ucdays.days(i);
                    flowLayoutPanelDaysContainer.Controls.Add(ucdays);
                }
                else
                {
                    int index = holiDaysOftheMonth.FindIndex(h => h.festive_day == dia);

                    if (index != -1)
                    {
                        if (holiDaysOftheMonth[iteratorHoliday].type == 1)
                        {
                            UserControlDays ucdaysLliureDispo = new UserControlDays(Color.FromArgb(192, 192, 255), labelDate);
                            ucdaysLliureDispo.days(i);
                            flowLayoutPanelDaysContainer.Controls.Add(ucdaysLliureDispo);
                        }
                        else if (holiDaysOftheMonth[iteratorHoliday].type == 2)
                        {
                            UserControlDays ucdaysFestius = new UserControlDays(Color.FromArgb(255, 255, 128), labelDate);
                            ucdaysFestius.days(i);
                            flowLayoutPanelDaysContainer.Controls.Add(ucdaysFestius);
                        }
                        iteratorHoliday++;

                    }
                    else if (dia == iniciCurs) //green
                    {
                        UserControlDays ucdaysIniciCurs = new UserControlDays(Color.FromArgb(128, 255, 128), labelDate);
                        ucdaysIniciCurs.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdaysIniciCurs);
                    }
                    else if (dia == fiCurs)
                    {
                        UserControlDays ucdaysFiCurs = new UserControlDays(Color.FromArgb(255, 128, 255), labelDate);
                        ucdaysFiCurs.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdaysFiCurs);
                    }
                    else
                    {
                        UserControlDays ucdays = new UserControlDays(Color.FromKnownColor(KnownColor.White), labelDate);
                        ucdays.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdays);
                    }

                }
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
            getData();
            month++;
            String monthName = ci.DateTimeFormat.GetMonthName(month);
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            labelDate.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOftheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            if (daysOftheWeek <= 0) daysOftheWeek = 1;
            int sunday = 5 - daysOftheWeek;
            int saturday = 6 - daysOftheWeek;
            int iteratorHoliday = 0;

            holiDaysOftheMonth = getHolidaysOfTheMonth(startOfTheMonth, allHolidays);

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank(Color.FromKnownColor(KnownColor.Control));
                flowLayoutPanelDaysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                DateTime dia = new DateTime(year, month, i);
                if ((i + daysOftheWeek) % 7 == 0 || (i + daysOftheWeek - 1) % 7 == 0)
                {
                    UserControlDays ucdays = new UserControlDays(Color.FromArgb(255, 128, 128), labelDate);
                    ucdays.days(i);
                    flowLayoutPanelDaysContainer.Controls.Add(ucdays);
                }
                else
                {
                    int index = holiDaysOftheMonth.FindIndex(h => h.festive_day == dia);

                    if (index != -1)
                    {
                        if (holiDaysOftheMonth[iteratorHoliday].type == 1)
                        {
                            UserControlDays ucdaysLliureDispo = new UserControlDays(Color.FromArgb(192, 192, 255), labelDate);
                            ucdaysLliureDispo.days(i);
                            flowLayoutPanelDaysContainer.Controls.Add(ucdaysLliureDispo);
                        }
                        else if (holiDaysOftheMonth[iteratorHoliday].type == 2)
                        {
                            UserControlDays ucdaysFestius = new UserControlDays(Color.FromArgb(255, 255, 128), labelDate);
                            ucdaysFestius.days(i);
                            flowLayoutPanelDaysContainer.Controls.Add(ucdaysFestius);
                        }
                        iteratorHoliday++;

                    }
                    else if (dia == iniciCurs) //green
                    {
                        UserControlDays ucdaysIniciCurs = new UserControlDays(Color.FromArgb(128, 255, 128), labelDate);
                        ucdaysIniciCurs.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdaysIniciCurs);
                    }
                    else if (dia == fiCurs)
                    {
                        UserControlDays ucdaysFiCurs = new UserControlDays(Color.FromArgb(255, 128, 255), labelDate);
                        ucdaysFiCurs.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdaysFiCurs);
                    }
                    else
                    {
                        UserControlDays ucdays = new UserControlDays(Color.FromKnownColor(KnownColor.White), labelDate);
                        ucdays.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdays);
                    }

                }
            }
        }
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDaysContainer.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            getData();
            String monthName = ci.DateTimeFormat.GetMonthName(month);
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            labelDate.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOftheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            if (daysOftheWeek <= 0) daysOftheWeek = 1;
            int sunday = 5 - daysOftheWeek;
            int saturday = 6 - daysOftheWeek;
            int iteratorHoliday = 0;
            holiDaysOftheMonth = getHolidaysOfTheMonth(startOfTheMonth, allHolidays);

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank(Color.FromKnownColor(KnownColor.Control));
                flowLayoutPanelDaysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                DateTime dia = new DateTime(year, month, i);
                if ((i + daysOftheWeek) % 7 == 0 || (i + daysOftheWeek - 1) % 7 == 0)
                {
                    UserControlDays ucdays = new UserControlDays(Color.FromArgb(255, 128, 128), labelDate);
                    ucdays.days(i);
                    flowLayoutPanelDaysContainer.Controls.Add(ucdays);
                }
                else
                {
                    int index = holiDaysOftheMonth.FindIndex(h => h.festive_day == dia);

                    if (index != -1)
                    {
                        if (holiDaysOftheMonth[iteratorHoliday].type == 1)
                        {
                            UserControlDays ucdaysLliureDispo = new UserControlDays(Color.FromArgb(192, 192, 255), labelDate);
                            ucdaysLliureDispo.days(i);
                            flowLayoutPanelDaysContainer.Controls.Add(ucdaysLliureDispo);
                        }
                        else if (holiDaysOftheMonth[iteratorHoliday].type == 2)
                        {
                            UserControlDays ucdaysFestius = new UserControlDays(Color.FromArgb(255, 255, 128), labelDate);
                            ucdaysFestius.days(i);
                            flowLayoutPanelDaysContainer.Controls.Add(ucdaysFestius);
                        }
                        iteratorHoliday++;

                    }
                    else if (dia == iniciCurs) //green
                    {
                        UserControlDays ucdaysIniciCurs = new UserControlDays(Color.FromArgb(128, 255, 128), labelDate);
                        ucdaysIniciCurs.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdaysIniciCurs);
                    }
                    else if (dia == fiCurs)
                    {
                        UserControlDays ucdaysFiCurs = new UserControlDays(Color.FromArgb(255, 128, 255), labelDate);
                        ucdaysFiCurs.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdaysFiCurs);
                    }
                    else
                    {
                        UserControlDays ucdays = new UserControlDays(Color.FromKnownColor(KnownColor.White), labelDate);
                        ucdays.days(i);
                        flowLayoutPanelDaysContainer.Controls.Add(ucdays);
                    }

                }

            }
        }

        private void panelLliureEleccio_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(192, 192, 255);
        }
        private void panel16_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(192, 192, 255);
        }

        private void panelVacances_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(255, 255, 128);
        }
        private void panel19_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(255, 255, 128);
        }

        private void panelPrimerDiaDeCurs_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(128, 255, 128);
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(128, 255, 128);
        }
        private void panelUltimDiaDelCurs_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(255, 128, 255);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromKnownColor(KnownColor.White);
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            colorPicked = Color.FromArgb(255, 128, 255);
        }

        private List<holidays> getHolidaysOfTheMonth(DateTime data, List<holidays> allHolidays)
        {
            List<holidays> result = new List<holidays>();
            foreach (holidays holiday in allHolidays)
            {
                if(holiday.festive_day.Month == data.Month && holiday.festive_day.Year == data.Year)
                {
                    result.Add(holiday);
                }
            }
            return result;
        }
    }
}
