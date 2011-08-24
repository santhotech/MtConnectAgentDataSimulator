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
    }
}
