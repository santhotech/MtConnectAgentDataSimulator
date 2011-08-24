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

    }
}
