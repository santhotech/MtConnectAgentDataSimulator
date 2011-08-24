using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgentDataSimulator
{
    public partial class Form3 : Form
    {        
        public Form3()
        {
            InitializeComponent();
            delBetInpTxt.Text = Properties.Settings.Default.delaySec.ToString();
        }

        
    }
}
