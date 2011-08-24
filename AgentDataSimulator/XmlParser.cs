using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Windows.Forms;
using System.Threading;

namespace AgentDataSimulator
{
    class XmlParser
    {
        public ListView lv = new ListView();
        string ds;        
        ThreadSafeUIAccessors tsa = new ThreadSafeUIAccessors();
        bool dumpFlag = false;
        public delegate void DumperStatusChangedEventHandler(bool curFlag);
        public event DumperStatusChangedEventHandler DumperStatusChanged;
        Thread t;
        public bool DumpFlag
        {
            get { return this.dumpFlag; }
            set
            {
                this.dumpFlag = value;
                if (DumperStatusChanged != null)
                {
                    this.DumperStatusChanged(dumpFlag);
                }
            }
        }
        public XmlParser(string dataSrc)
        {
            ds = dataSrc;
        }

        public void StartDumpingData()
        {
            this.DumpFlag = true;
            t = new Thread(new ThreadStart(DumpData));
            t.Start();
        }

        public void StopDumpingData()
        {
            t.Abort();
            this.DumpFlag = false;
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
                doc = new XPathDocument(ds + "/current");
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
            catch (Exception ex)
            {
                MessageBox.Show("Cannot retrieve MTConnect Stream" + ex.ToString());
                Console.Write(ex.ToString());
            }
            return seq;
        }

    }
}
