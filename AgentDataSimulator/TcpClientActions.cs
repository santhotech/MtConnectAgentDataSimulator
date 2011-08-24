using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net;
using System.Collections;
namespace AgentDataSimulator
{
    class TcpClientActions
    {
        // The actual tcp listener which opens a socket and listens for a client.
        TcpListener tcpListener;

        // Event handler delegate
        public delegate void ClientCountChangeDelegate(int totalClients);

        // Event to be raised when the client count changes
        public event ClientCountChangeDelegate ClientCountChanged;
        
        // total no of clients connected to the app at any given instace
        int clientCount = 0;

        // Property to set and get client count
        private int ClientCount
        {
            get { return this.clientCount; }
            set 
            { 
                this.clientCount = value;
                if (this.ClientCountChanged != null)
                {
                    this.ClientCountChanged(clientCount);
                }
            }
        }

        // Flag to set whether to listen to clients or not
        bool listenFlag = false;

        // An array list that holds the list of clients connected so far
        ArrayList clients = new ArrayList();

        // base constructor
        public TcpClientActions()
        {

        }

        // The method which will open a socket and listen for clients in the socket
        public void StartListeningForClients()
        {
            int port = Properties.Settings.Default.portNo;
            tcpListener = new TcpListener(IPAddress.Any, port);
            listenFlag = true;
            tcpListener.Start();
            while (listenFlag)
            {
                TcpClient client = this.tcpListener.AcceptTcpClient();
                clients.Add(client);
                ++ClientCount;
                Thread t = new Thread(new ParameterizedThreadStart(CheckClientsActive));
                t.IsBackground = true;
                t.Start(client);                
            }
        }

        // Calling this method will stop listening for the clients
        public void StopListeningForClients()
        {
            listenFlag = false;
        }

        // This method will send the text passed to it to all the clients it has been connected to
        public void SendDataToClients(string strToBeSent)
        {
            try
            {
                foreach (object ob in clients)
                {
                    try
                    {
                        TcpClient clnt = (TcpClient)ob;
                        NetworkStream clientStream = clnt.GetStream();
                        ASCIIEncoding encoder = new ASCIIEncoding();
                        byte[] buffer = encoder.GetBytes(strToBeSent);
                        clientStream.Write(buffer, 0, buffer.Length);
                        clientStream.Flush();
                    }
                    catch { }
                }
            }
            catch { }
        }

        // Check if the clients connected to it are active
        public void CheckClientsActive(object tClient)
        {
            TcpClient tcpClient = (TcpClient)tClient;
            NetworkStream clientStream = tcpClient.GetStream();
            while (true)
            {
                try
                {
                    byte[] message = new byte[4096];
                    int bytesRead;
                    bytesRead = 0;
                    try { bytesRead = clientStream.Read(message, 0, 4096); }
                    catch { }                    
                    if (bytesRead == 0)
                    {
                        clients.Remove(tcpClient);
                        --ClientCount;
                        break;
                    }
                }
                catch { }               
            }
        }        
        //end methods definition
    }    
}
