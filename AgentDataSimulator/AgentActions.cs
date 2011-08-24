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
    }
}
