using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace AgentDataSimulator
{
    public partial class Form1 : Form
    {
        string ds;
        TcpClientActions tca = new TcpClientActions();
        ThreadSafeUIAccessors tsa = new ThreadSafeUIAccessors();
        XmlParser xp;
        AgentActions aa = new AgentActions();
        SendDataFromFile sdf;
        public Form1()
        {
            InitializeComponent();

            ds = Properties.Settings.Default.dataSrc;
            simPrtTxt.Text = Properties.Settings.Default.portNo.ToString();
            simDelTxt.Text = Properties.Settings.Default.delaySec.ToString() + " ms";

            sdf = new SendDataFromFile(tca);
            xp = new XmlParser(ds);
            tca.ClientCountChanged += new TcpClientActions.ClientCountChangeDelegate(tca_ClientCountChanged);
            Thread listenThread = new Thread(new ThreadStart(tca.StartListeningForClients));
            listenThread.Start();
            xp.DumperStatusChanged += new XmlParser.DumperStatusChangedEventHandler(xp_DumperStatusChanged);
            aa.AgentStatusChanged += new AgentActions.AgentStatusChangedEventHandler(aa_AgentStatusChanged);
            xp.lv = dCodedList;
            sdf.SimStatusChanged += new SendDataFromFile.SimStatusChangedEventHandler(sdf_SimStatusChanged);
            Form3 f3 = new Form3();
            f3.delBetInpTxt.TextChanged += new EventHandler(delBetInpTxt_TextChanged);
        }

        private void agentStrt_Click(object sender, EventArgs e)
        {
            aa.AgentStart();
        }

        private void agentStop_Click(object sender, EventArgs e)
        {
            aa.AgentStop();
        }

        private void clearAgenData_Click(object sender, EventArgs e)
        {
            dCodedList.Items.Clear();
        }

        private void agentSettings_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void simStngBtn_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
        }
        public void delBetInpTxt_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            simDelTxt.Text = t.Text + " ms";
        }
        public void sdf_SimStatusChanged(bool curFlag)
        {
            if (curFlag) { simStatBtn.BackColor = Color.LimeGreen; } else { simStatBtn.BackColor = Color.Red; };
            tsa.SetEnabled(strt, !curFlag);
            tsa.SetEnabled(stp, curFlag);
        }

        public void aa_AgentStatusChanged(bool curFlag)
        {
            if (curFlag) { agntStatBtn.BackColor = Color.LimeGreen; } else { agntStatBtn.BackColor = Color.Red; };
            agentStrt.Enabled = !curFlag;
            agentStop.Enabled = curFlag;
            agentSettings.Enabled = !curFlag;
        }

        public void xp_DumperStatusChanged(bool curFlag)
        {
            tsa.SetEnabled(dcdrStrt, !curFlag);
            tsa.SetEnabled(dcdrStp, curFlag);
        }

        public void tca_ClientCountChanged(int numClients)
        {
            tsa.SetText(numClients.ToString(), this.cliNumStatLbl);
            if (numClients > 0)
            {
                tsa.SetCtrlCol(cliStatBtn, Color.LimeGreen, 0);
            }
            else
            {
                tsa.SetCtrlCol(cliStatBtn, Color.Red, 0);
            }
        }

        private void strt_Click(object sender, EventArgs e)
        {
            sdf.StartSendingData();
        }

        private void stp_Click(object sender, EventArgs e)
        {
            sdf.StopSendingData();
        }
        private void dcdrStrt_Click(object sender, EventArgs e)
        {
            xp.StartDumpingData();
        }

        private void dcdrStp_Click(object sender, EventArgs e)
        {
            xp.StopDumpingData();
        }

        private void dcdrStngs_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.ShowDialog();
        }
    }
}