using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;

delegate void SetTextCallback(string text, Control ctrl);
delegate void SetBtnCallback(Control ctrl,bool a);
delegate void AccessControlListCallback(ListViewItem  itm,ListView lst);
delegate void SetBtnColCallback(Control ctrl,int a);


namespace AgentDataSimulator
{
    public partial class Form1 : Form
    {

        public TcpListener tcpListener;
        private Thread listenThread;
        //public TcpClient client;
        public string fileToOpen;
        int count = 0;
        public int flag = 0;
        public int listenFlag = 1;
        Process p1;
        ArrayList clients = new ArrayList();
        public Thread t;
        public int agentDataFlag = 1;
        public Thread showAgentData;        
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        string ds;
        int delaySec = 0;
        int portNo = 0;
        string csvStr = string.Empty;
        string txtStr = string.Empty;
        public Form1()
        {
             ds = f4.agntDataSrcTxt.Text;
            portNo = Int32.Parse(f3.prtTxt.Text);            
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeComponent();
            int port = portNo;
            this.tcpListener = new TcpListener(IPAddress.Any, port);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();            
        }
        public void OnApplicationExit(object sender, EventArgs e)
        {
            listenFlag = 0;
            StopSending();
            AgentStop();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DesignList();            
            simPrtTxt.Text = portNo.ToString();            
        }
        private void ChangeDelayLbl()
        {
            simDelTxt.Text = delaySec.ToString() + " ms";
        }
        private void ListenForClients()
        {
            this.tcpListener.Start();
            while (listenFlag == 1)
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                ++count;
                this.SetText(count + " " + GetClientMsg(count) + " connected", cliNumStatLbl);
                if (stp.Enabled == false) { SetBtn(strt, true); }
                SetBtnCol(cliStatBtn, 1);
                SendDataToTCPPort sd = new SendDataToTCPPort(client);
                Thread t = new Thread(new ThreadStart(sd.sndData));
                t.Start();
                clients.Add(sd);
                Thread a = new Thread(new ParameterizedThreadStart(CheckClientActive));
                a.Start(client);
            }
        }
        
        private string GetClientMsg(int count)
        {
            if (count > 1)
            {
                return "Clients";
            }
            else
                return "Client";
        }
        //method call for the delegate to enable safe cross threading calls
        public void SetText(string text, Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, ctrl });
            }
            else
            {
                if (ctrl.GetType() == typeof(Label))
                {
                    ctrl.Text = text;
                }
                else
                {
                    ctrl.Text += Environment.NewLine + text;
                }
            }
        }
        private void SetBtn(Control ctrl, bool a)
        {
            if (ctrl.InvokeRequired)
            {
                SetBtnCallback d = new SetBtnCallback(SetBtn);
                this.Invoke(d, new object[] { ctrl, a });
            }
            else
            {
                ctrl.Enabled = a;
            }
        }

        private void SetBtnCol(Control ctrl, int a)
        {
            if (ctrl.InvokeRequired)
            {
                SetBtnColCallback d = new SetBtnColCallback(SetBtnCol);
                this.Invoke(d, new object[] { ctrl, a });
            }
            else
            {
                if (a == 0)
                {
                    ctrl.BackColor = Color.Red;
                }
                if (a == 1)
                {
                    ctrl.BackColor = Color.LimeGreen;
                }
            }
        }

        private void AccessControlList(ListViewItem itm,ListView lst)
        {
            if (lst.InvokeRequired)
            {
                AccessControlListCallback d = new AccessControlListCallback(AccessControlList);
                this.Invoke(d, new object[] { itm, lst });
            }
            else
            {
                lst.Items.Add(itm);
            }
        }        
        private void strt_Click(object sender, System.EventArgs e)
        {            
            simStatBtn.BackColor = Color.LimeGreen;
            if (f3.inpFileTxt.Text == string.Empty)
            {
                MessageBox.Show("Please select a file", "Error");
            }
            else
            {
                fileToOpen = f3.inpFileTxt.Text;

                foreach (object ob in clients)
                {
                    SendDataToTCPPort sa = (SendDataToTCPPort)ob;
                    sa.SetFlag(true);
                }

                flag = 1;
                stp.Enabled = true;
                strt.Enabled = false;
               // t = new Thread(sndData);
                //t.Start();
            }
        }

        private void stp_Click(object sender, EventArgs e)
        {
            StopSending();
        }
        public void StopSending()
        {
            simStatBtn.BackColor = Color.Red;
            flag = 0;
            SetBtn(stp, false);
            if (count != 0)
            {
                SetBtn(strt, true);
            }            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            f2.agntExeTxt.Text = openFileDialog1.FileName;
        }

        private void agentStrt_Click(object sender, EventArgs e)
        {
            
            ProcessStartInfo pr1 = new ProcessStartInfo();
            pr1.FileName = f2.agntExeTxt.Text;
            pr1.WindowStyle = ProcessWindowStyle.Hidden;
            string xmltName = f2.xmlfile.Text;
            string listName = f2.listfile.Text;
            pr1.Arguments = "-f " + xmltName + " -c " + listName;            
            try
            {
                p1 = Process.Start(pr1);
                agntStatBtn.BackColor = Color.LimeGreen;
                agentStrt.Enabled = false;
                agentStop.Enabled = true;
                agentSettings.Enabled = false;
                expCsvBtn.Enabled = false;
                expTxtBtn.Enabled = false;
                DesignList();
                csvStr = string.Empty;
                txtStr = string.Empty;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot start agent", "Error");
                Console.WriteLine(ex);
            }
        }

        private void agentStop_Click(object sender, EventArgs e)
        {            
            AgentStop();
        }
        public void AgentStop()
        {
            expCsvBtn.Enabled = true;
            expTxtBtn.Enabled = true;
            agentSettings.Enabled = true;            
            try
            {
                p1.Kill();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Agent already terminated", "Notification");
                Console.WriteLine(ex);
            }
            agntStatBtn.BackColor = Color.Red;
            agentStrt.Enabled = true;
            agentStop.Enabled = false;            
        }
        public void CheckClientActive(object ob)
        {
            TcpClient tcpClient = (TcpClient)ob;
            NetworkStream clientStream = tcpClient.GetStream();
            while (true)
            {
                try
                {                                            
                        byte[] message = new byte[4096];
                        int bytesRead;
                        bytesRead = 0;
                        try
                        {
                            //blocks until a client sends a message   
                            bytesRead = clientStream.Read(message, 0, 4096);
                        }
                        catch
                        {
                            //a socket error has occured
                            //break;

                        }
                        if (bytesRead == 0)
                        {
                            //the client has disconnected from the server                        
                            --count;
                            this.SetText(count + " " + GetClientMsg(count) + " connected", cliNumStatLbl);
                            clients.Remove(ob);                            
                            if (count == 0)
                            {
                                SetBtn(strt, false);
                                SetBtnCol(cliStatBtn, 0);
                                StopSending();
                            }
                            break;
                        }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Thread.Sleep(2000);            
            }
        }

        private void inpDataClearBtn_Click(object sender, EventArgs e)
        {
            currStat.Text = string.Empty;
        }
        public void Form_closing(object sender, CancelEventArgs cargs)
        {
            listenFlag = 0;
            StopSending();
            AgentStop();
            Environment.Exit(1);
        }

        public string GetSequence()
        {         
            XPathDocument doc;
            XmlNamespaceManager ns;
            XPathNavigator navigator;
            XPathNodeIterator nodes;            
            XPathNavigator node;            
            string seq = string.Empty;             
            try
            {                
                doc = new XPathDocument(ds+"/current");
                navigator = doc.CreateNavigator();
                ns = new XmlNamespaceManager(navigator.NameTable);
                ns.AddNamespace("m", "urn:mtconnect.org:MTConnectStreams:1.1");
                nodes = navigator.Select("//m:Header", ns);
                while (nodes.MoveNext())
                {
                    node = nodes.Current;
                    seq = node.GetAttribute("nextSequence", ns.DefaultNamespace);                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot retrieve MTConnect Stream");
                Console.Write(ex.ToString());
            }             
            return seq;
        }

        public void DoGetData()
        {
            XPathDocument doc;
            XmlNamespaceManager ns;
            XPathNavigator navigator;
            XPathNodeIterator nodes;
            XPathNodeIterator nodes1;
            XPathNavigator node;
            XPathNavigator node1;
            string seq = GetSequence();
            if ((f3.IsAllDigits(seq) && (seq != string.Empty)))
            {
                while (agentDataFlag == 1)
                {
                    try
                    {
                        doc = new XPathDocument(ds + "/sample?from=" + seq);
                        navigator = doc.CreateNavigator();
                        ns = new XmlNamespaceManager(navigator.NameTable);
                        ns.AddNamespace("m", "urn:mtconnect.org:MTConnectStreams:1.1");
                        nodes = navigator.Select("//m:Header", ns);
                        while (nodes.MoveNext())
                        {
                            node = nodes.Current;
                            seq = node.GetAttribute("nextSequence", ns.DefaultNamespace);
                        }
                        nodes = navigator.Select("//m:Samples/*", ns);
                        nodes1 = navigator.Select("//m:Events/*", ns);
                        String[] addStr = new String[3];
                        ListViewItem itm;
                        while (nodes1.MoveNext())
                        {
                            node1 = nodes1.Current;
                            addStr[0] = node1.GetAttribute("timestamp", ns.DefaultNamespace);
                            addStr[1] = node1.GetAttribute("name", ns.DefaultNamespace);
                            addStr[2] = node1.Value;
                            itm = new ListViewItem(addStr);
                            AccessControlList(itm, ListView1);
                            csvStr += addStr[0] + "," + addStr[1] + "," + addStr[2] + Environment.NewLine;
                            txtStr += addStr[0] + "|" + addStr[1] + "|" + addStr[2] + Environment.NewLine;
                        }
                        while (nodes.MoveNext())
                        {
                            node1 = nodes1.Current;
                            addStr[0] = node1.GetAttribute("timestamp", ns.DefaultNamespace);
                            addStr[1] = node1.GetAttribute("name", ns.DefaultNamespace);
                            addStr[2] = node1.Value;
                            itm = new ListViewItem(addStr);
                            AccessControlList(itm, ListView1);
                            csvStr += addStr[0] + "," + addStr[1] + "," + addStr[2] + Environment.NewLine;
                            txtStr += addStr[0] + "|" + addStr[1] + "|" + addStr[2] + Environment.NewLine;
                        }
                    }
                    catch (Exception Exception)
                    {
                        agentDataFlag = 0;
                        SetBtn(dcdrStrt, true);
                        SetBtn(dcdrStp, false);
                        Console.Write(Exception.ToString());
                    }
                }
            }
            else
            {
                agentDataFlag = 0;
                SetBtn(dcdrStrt, true);
                SetBtn(dcdrStp, false);

            }
        }

        private void clearAgenData_Click(object sender, EventArgs e)
        {
            DesignList();
        }
        private void DesignList()
        {
            ListView1.Clear();
            ListView1.Columns.Add("Timestamp", 110, HorizontalAlignment.Left);
            ListView1.Columns.Add("Key", 110, HorizontalAlignment.Left);
            ListView1.Columns.Add("Value", 110, HorizontalAlignment.Left);
        }

        private void agentSettings_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void simStngBtn_Click(object sender, EventArgs e)
        {
            if (f3.ShowDialog() == DialogResult.OK)
            {                
            }
        }

        private void expCsvBtn_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true; 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    StreamWriter wText = new StreamWriter(saveFileDialog1.FileName);
                    wText.Write(csvStr);
                    wText.Close();
                }
            }
        }
        private void expTxtBtn_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    StreamWriter wText = new StreamWriter(saveFileDialog1.FileName);
                    wText.Write(txtStr);
                    wText.Close();
                }
            }
        }

        private void dcdrStrt_Click(object sender, EventArgs e)
        {
            dcdrStp.Enabled = true;
            dcdrStrt.Enabled = false;
            agentDataFlag = 1;
            showAgentData = new Thread(new ThreadStart(DoGetData));
            showAgentData.Start();
        }

        private void dcdrStp_Click(object sender, EventArgs e)
        {
            agentDataFlag = 0;
            dcdrStp.Enabled = false;
            dcdrStrt.Enabled = true;
        }

        private void dcdrStngs_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }
    }

}