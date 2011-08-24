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
        public SendDataFromFile(TcpClientActions mTcp)
        {
            tca = mTcp;
        }
        Thread t;
        public void StartSendingData()
        {
            t = new Thread(new ThreadStart(SendData));
            t.Start();
        }
        public void SendData()
        {
            this.SendFlag = true;
            string fileToOpen = Properties.Settings.Default.fileToOpen;
            StreamReader sr = new StreamReader(fileToOpen);
            int delay = Properties.Settings.Default.delaySec;
            while (sendFlag)
            {
                string read = string.Empty;
                try
                {
                    while ((read = sr.ReadLine()) != null)
                    {
                        try
                        {
                            read = "|" + read + "\n";
                            tca.SendDataToClients(read);
                            Thread.Sleep(delay);
                            if (sr.EndOfStream == true)
                            {
                                sr = new StreamReader(fileToOpen);
                            }
                        }
                        catch
                        {
                            this.SendFlag = false;
                            break;
                        }
                    }
                }
                catch
                {
                    this.SendFlag = false;
                    break;
                }
            }
        }
        public void StopSendingData()
        {
            this.SendFlag = false;
            t.Abort();
        }
    }
}
