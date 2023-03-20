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
            labeUuser.Text = "Administrador";
            labelAccio.Text = printAccio();
            labelSouce.Text = printSource();
            labelSubjecte.Text = LogsOrm.SelectSubjecte(log.changed_id, log.tablechange);
        }


        private string printSource()
        {
            switch (log.tablechange)
            {
                case "PROFESORS":
                    return "el professor";
                case "STUDENTS":
                    return "l'estudiant";
                case "VALIDABLE ZONES":
                    return "la zona validable";
                case "CLASSROOMS":
                    return "la classe";
                case "GROUPS":
                    return "el grup";
                case "COURSES":
                    return "el curs";
                case "MODULES":
                    return "el mòdul";
                case "DEPARTMENTS":
                    return "el departament";
                case "UNITS":
                    return "la unitat formativa";
                default:
                    return "Nom de la taula";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
