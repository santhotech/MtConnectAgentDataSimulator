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
        public void SetText(string text, Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                ctrl.Invoke(d, new object[] { text, ctrl });
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

        public void SetEnabled(Control ctrl, bool a)
        {
            if (ctrl.InvokeRequired)
            {
                SetEnabledCallback d = new SetEnabledCallback(SetEnabled);
                ctrl.Invoke(d, new object[] { ctrl, a });
            }
            else
            {
                ctrl.Enabled = a;
            }
        }

        public void SetCtrlCol(Control ctrl, Color col, int backOrFront)
        {
            if (ctrl.InvokeRequired)
            {
                SetCtrlColCallback d = new SetCtrlColCallback(SetCtrlCol);
                ctrl.Invoke(d, new object[] { ctrl, col, backOrFront });
            }
            else
            {
                if (backOrFront == 0)
                {
                    ctrl.BackColor = col;
                }
                if (backOrFront == 1)
                {
                    ctrl.ForeColor = col;
                }
            }
        }

        public void AddItemToList(ListViewItem itm, ListView lst)
        {
            if (lst.InvokeRequired)
            {
                AccessControlListCallback d = new AccessControlListCallback(AddItemToList);
                lst.Invoke(d, new object[] { itm, lst });
            }
            else
            {
                lst.Items.Add(itm);
            }
        }     

    }
}
