using Libe_Escriptori.Models;
using Libe_Escriptori.Models.Centre;
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
    public partial class UserControlDays : UserControl
    {
        
        private string labelMonthYear;
        private Color blue = Color.FromArgb(192, 192, 255);
        private Color yellow = Color.FromArgb(255, 255, 128);
        private Color green = Color.FromArgb(128, 255, 128);
        private Color pink = Color.FromArgb(255, 128, 255);
        private Color weekendColor = Color.FromArgb(255, 128, 128);

        private DateTime defaultDateTime = new DateTime(1, 1, 1);
        public UserControlDays(Color color, Label date)
        {
            InitializeComponent();
            BackGroundColor(color);
            labelMonthYear = date.Text;
        }

        private void BackGroundColor(Color color)
        {
            BackColor = color;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            labelDay.Text = numday + "";
        }


        private int getMonthNum(string month)
        {
            int monthNum;
            month = month.ToLower();
            switch (month)
            {
                case "gener":
                    monthNum = 1;
                    break;
                case "febrer":
                    monthNum = 2;
                    break;
                case "març":
                    monthNum = 3;
                    break;
                case "abril":
                    monthNum = 4;
                    break;
                case "maig":
                    monthNum = 5;
                    break;
                case "juny":
                    monthNum = 6;
                    break;
                case "juliol":
                    monthNum = 7;
                    break;
                case "agost":
                    monthNum = 8;
                    break;
                case "setembre":
                    monthNum = 9;
                    break;
                case "octubre":
                    monthNum = 10;
                    break;
                case "novembre":
                    monthNum = 11;
                    break;
                case "desembre":
                    monthNum = 12;
                    break;
                default:
                    monthNum = 0;
                    break;
            }
            return monthNum;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            Color colorPicked = FormCalendari.colorPicked;
            string monthString = labelMonthYear.Split(' ')[0];
            int year = int.Parse(labelMonthYear.Split(' ')[1]); ;
            int month = getMonthNum(monthString);
            int day = int.Parse(labelDay.Text);

            DateTime daySelected = new DateTime(year, month, day);
            if(this.BackColor != weekendColor)
            {
                BackGroundColor(colorPicked);
            }
            
            if (colorPicked.Equals(blue))
            {
                if(FormCalendari.allHolidays.FindIndex(h => h.festive_day == daySelected) != -1)
                {
                    CalendariOrm.UpdateType(1, daySelected); //Actualitzem el dia de vacances a lliure elecció
                }
                else
                {
                    holidays holiday = new holidays();
                    holiday.calendar_id = 1;
                    holiday.festive_day = daySelected;
                    holiday.type = 1;

                    CalendariOrm.Insert(holiday);
                }

            }
            else if (colorPicked.Equals(yellow))
            {
                if (FormCalendari.allHolidays.FindIndex(h => h.festive_day == daySelected) != -1)
                {
                    CalendariOrm.UpdateType(2, daySelected); //Actualitzem el dia de lliure elecció a vacances 
                }
                else
                {
                    holidays holiday = new holidays();
                    holiday.calendar_id = 1;
                    holiday.festive_day = daySelected;
                    holiday.type = 2;

                    CalendariOrm.Insert(holiday);
                }
            }
            else if (colorPicked.Equals(green))
            {
                if (FormCalendari.allHolidays.FindIndex(h => h.festive_day == daySelected) != -1)
                {
                    CalendariOrm.Delete(daySelected);
                }
                if (FormCalendari.fiCurs == daySelected)
                {
                    CalendariOrm.UpdateEndingDate(defaultDateTime);
                }

                CalendariOrm.UpdateStartingDate(daySelected);


            }
            else if (colorPicked.Equals(pink))
            {
                if (FormCalendari.allHolidays.FindIndex(h => h.festive_day == daySelected) != -1)
                {
                    CalendariOrm.Delete(daySelected);
                }
                if (FormCalendari.iniciCurs == daySelected)
                {
                    CalendariOrm.UpdateStartingDate(defaultDateTime);
                }

                CalendariOrm.UpdateEndingDate(daySelected);

            }
            else if (colorPicked.Equals(Color.White))
            {
                if (FormCalendari.allHolidays.FindIndex(h => h.festive_day == daySelected) != -1)
                {
                    CalendariOrm.Delete(daySelected);
                }
                if (FormCalendari.fiCurs == daySelected)
                {
                    CalendariOrm.UpdateEndingDate(defaultDateTime);
                }
                if (FormCalendari.iniciCurs == daySelected)
                {
                    CalendariOrm.UpdateStartingDate(defaultDateTime);
                }
            }
        }


       
    }
}
