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
        private Color previousColor;

        private DateTime defaultDateTime = new DateTime(1, 1, 1);
        public UserControlDays(Color color, Label date)
        {
            InitializeComponent();
            BackGroundColor(color);
            this.labelMonthYear = date.Text;
        }

        private void BackGroundColor(Color color)
        {
            this.BackColor = color;
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
            
            if (colorPicked.Equals(blue) && FormCalendari.diesLliureDisposicio.Where(d => d.Equals(daySelected)).FirstOrDefault() == default)
            {
                var isFestiu = FormCalendari.diesFestius.Where(d => d.Equals(daySelected)).FirstOrDefault();
                if (isFestiu != default)
                {
                    FormCalendari.diesFestius.Remove(isFestiu);
                }
                FormCalendari.diesLliureDisposicio.Add(daySelected);

            }
            else if (colorPicked.Equals(yellow) && FormCalendari.diesFestius.Where(d => d.Equals(daySelected)).FirstOrDefault() == default)
            {
                var isLliureDisposicio = FormCalendari.diesLliureDisposicio.Where(d => d.Equals(daySelected)).FirstOrDefault();
                if (isLliureDisposicio != default)
                {
                    FormCalendari.diesLliureDisposicio.Remove(isLliureDisposicio);
                }
                FormCalendari.diesFestius.Add(daySelected);
            }
            else if (colorPicked.Equals(green))
            {
                var isFestiu = FormCalendari.diesFestius.Where(d => d.Equals(daySelected)).FirstOrDefault();
                var isLliureDisposicio = FormCalendari.diesLliureDisposicio.Where(d => d.Equals(daySelected)).FirstOrDefault();


                if (isFestiu != null)
                {
                    FormCalendari.diesFestius.Remove(isFestiu);
                }
                if (isLliureDisposicio != null)
                {
                    FormCalendari.diesLliureDisposicio.Remove(isLliureDisposicio);
                }
                if (daySelected == FormCalendari.fiCurs)
                {
                    FormCalendari.fiCurs = defaultDateTime;
                }
               
                FormCalendari.iniciCurs = daySelected;

            }
            else if (colorPicked.Equals(pink))
            {
                var isFestiu = FormCalendari.diesFestius.Where(d => d.Equals(daySelected)).FirstOrDefault();
                var isLliureDisposicio = FormCalendari.diesLliureDisposicio.Where(d => d.Equals(daySelected)).FirstOrDefault();
                if (isFestiu != null)
                {
                    FormCalendari.diesFestius.Remove(isFestiu);
                }
                if (isLliureDisposicio != null)
                {
                    FormCalendari.diesLliureDisposicio.Remove(isLliureDisposicio);
                }
                if (daySelected == FormCalendari.iniciCurs)
                {
                    FormCalendari.iniciCurs = defaultDateTime;
                }
                FormCalendari.fiCurs = daySelected;
            }
            else if (colorPicked.Equals(Color.White))
            {
                var isFestiu = FormCalendari.diesFestius.Where(d => d.Equals(daySelected)).FirstOrDefault();
                var isLliureDisposicio = FormCalendari.diesLliureDisposicio.Where(d => d.Equals(daySelected)).FirstOrDefault();
                if (isFestiu != null)
                {
                    FormCalendari.diesFestius.Remove(isFestiu);
                }
                if(isLliureDisposicio != null){
                    FormCalendari.diesLliureDisposicio.Remove(isLliureDisposicio);
                }

                if (daySelected == FormCalendari.fiCurs)
                {
                    FormCalendari.fiCurs = defaultDateTime; 
                }
                if (daySelected == FormCalendari.iniciCurs)
                {
                    FormCalendari.iniciCurs = defaultDateTime;
                }
            }
        }

        private void UserControlDays_MouseUp(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Right)
            {
                //TODO
            }
        }
    }
}
