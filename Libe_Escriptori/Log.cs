using Libe_Escriptori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori
{
    public partial class Log : UserControl
    {
        logs log = new logs();
        public Log(logs log)
        {
            InitializeComponent();
            this.log = log;
            fillFields();
        }

        private void fillFields()
        {
            string subj;
            labeUuser.Text = "Administrador";
            labelAccio.Text = printAccio();
            labelSouce.Text = printSource();
            subj = LogsOrm.SelectSubjecte(log.changed_id, log.tablechange);
            if (subj.Length > 17)
            {
                labelSubjecte.Text = subj.Substring(0, 17) + "...";
            }
            else
            {
                labelSubjecte.Text = subj;
            }
            labelTimeStamp.Text = log.datetime.ToShortTimeString();
            labelDate.Text = log.datetime.ToShortDateString();
        }


        private string printSource()
        {
            switch (log.tablechange)
            {
                case "PROFESORS":
                    return "el docent";
                case "STUDENTS":
                    return "l'estudiant";
                case "VALIDABLE ZONES":
                    return "la zona";
                case "CLASSROOMS":
                    return "la classe";
                case "GROUPS":
                    return "el grup";
                case "COURSES":
                    return "el curs";
                case "MODULES":
                    return "el mòdul";
                case "DEPARTMENTS":
                    return "el dept";
                case "UNITS":
                    return "la UF";
                case "CALENDAR":
                    return "el calendari";
                default:
                    return "Not found";
            }
        }

        private string printAccio()
        {
            switch (log.type)
            {
                case "UPDATE":
                    return "ha actualitzat";
                case "INSERT":
                    return "ha afegit";
                case "DELETE":
                    return "ha esborrat";
            }
            return "";
        }

        private void labeUuser_Click(object sender, EventArgs e)
        {

        }
    }
}
