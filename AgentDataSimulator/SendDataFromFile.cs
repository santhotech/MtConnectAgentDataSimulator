using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace AgentDataSimulator
{
    class SendDataFromFile
    {
        bool sendFlag = false;
        TcpClientActions tca;
        public delegate void SimStatusChangedEventHandler(bool curFlag);
        public event SimStatusChangedEventHandler SimStatusChanged;
        public bool SendFlag
        {
            get { return this.sendFlag; }
            set
            {
                this.sendFlag = value;
                if (SimStatusChanged != null)
                {
                    this.SimStatusChanged(sendFlag);
                }
            }
        }
    }
}
