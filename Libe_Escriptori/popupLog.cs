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
    public partial class popupLog : Form
    {
        List<logs> logList = new List<logs>();
        public popupLog()
        {
            InitializeComponent();    
            panelAllLogs.HorizontalScroll.Enabled = false;
            panelAllLogs.HorizontalScroll.Visible = false;
            panelAllLogs.HorizontalScroll.Maximum = 0;
            panelAllLogs.AutoScroll = true;
            
            getLogs();
            refreshLogs();
            //panelAllLogs.AutoScroll = false;
            //panelAllLogs.VerticalScroll.Enabled = true;
            //panelAllLogs.VerticalScroll.Visible = false;
            panelAllLogs.AutoScroll = true;
            panelAllLogs.VerticalScroll.Enabled = false;
            panelAllLogs.VerticalScroll.Visible = false;
        }

        private void refreshLogs()
        {
            foreach (logs log in logList)
            {
                if(panelAllLogs.Controls.Count > 300)
                {
                    panelAllLogs.Controls.Clear();
                }
                else
                {
                    Log ucLog = new Log(log);
                    panelAllLogs.Controls.Add(ucLog);
                }
                
            }
        }

        private void getLogs()
        {
            logList = LogsOrm.Select();
        }
    }
}
