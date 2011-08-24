using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Net.Sockets;

namespace AgentDataSimulator
{    
    class SendDataToTCPPort
    {
        private int delaySec = 0;
        private string fileToOpen = string.Empty;
        private bool flag = false;
        TcpClient client;
        public SendDataToTCPPort(TcpClient tcpClient)
        {
            delaySec = Properties.Settings.Default.delaySec;
            Form3 f3 = new Form3();
            fileToOpen = f3.inpFileTxt.Text;
            client = tcpClient;
        }
        
        public void SetFlag(bool fl)
        {
            flag = fl;
        }
        public void sndData()
        {
            //if there is no clients connected then addig to the temp buffer                      
            StreamReader s = File.OpenText(fileToOpen);
            string read;            
            while (flag)
            {
                while ((read = s.ReadLine()) != null)
                {
                    //Form1.SetText("Sending " + read, currStat);
                    read = "|" + read + "\n";
                    TcpClient clnt = (TcpClient)client;
                    NetworkStream clientStream = clnt.GetStream();
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    byte[] buffer = encoder.GetBytes(read);
                    clientStream.Write(buffer, 0, buffer.Length);
                    clientStream.Flush();
                }
                Thread.Sleep(delaySec);
                if (!flag)
                {
                    break;
                }
                if (s.EndOfStream)
                {
                    s.Close();
                    s = File.OpenText(fileToOpen);
                }                                
            }            
        }
    }
}
