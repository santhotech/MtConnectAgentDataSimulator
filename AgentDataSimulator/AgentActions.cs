using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace AgentDataSimulator
{
    class AgentActions
    {
        Process p1;
        bool agtFlag = false;
        public delegate void AgentStatusChangedEventHandler(bool curFlag);
        public event AgentStatusChangedEventHandler AgentStatusChanged;
        public bool AgtFlag
        {
            get { return this.agtFlag; }
            set
            {
                this.agtFlag = value;
                if (AgentStatusChanged != null)
                {
                    this.AgentStatusChanged(agtFlag);
                }
            }
        }
        public void AgentStart()
        {
            ProcessStartInfo pr1 = new ProcessStartInfo();
            pr1.FileName = Properties.Settings.Default.agtFile;
            pr1.WindowStyle = ProcessWindowStyle.Hidden;
            string xmltName = Properties.Settings.Default.xmlFile;
            string listName = Properties.Settings.Default.lstFile;
            pr1.Arguments = "-f " + xmltName + " -c " + listName;
            try
            {
                p1 = Process.Start(pr1);
                this.AgtFlag = true;
            }
            catch
            {
                this.AgtFlag = false;
                MessageBox.Show("Cannot start agent", "Error");
            }
        }
        public void AgentStop()
        {
            try
            {
                p1.Kill();
                this.AgtFlag = false;
            }
            catch
            {
            }
        }
    }
}
