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
delegate void SetEnabledCallback(Control ctrl, bool a);
delegate void AccessControlListCallback(ListViewItem itm, ListView lst);
delegate void SetCtrlColCallback(Control ctrl, Color col, int a);

namespace AgentDataSimulator
{
    class ThreadSafeUIAccessors
    {
    }
}
