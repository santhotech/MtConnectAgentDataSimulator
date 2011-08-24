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
        Methods met;
        public Form3()
        {
            InitializeComponent();
            delBetInpTxt.Text = Properties.Settings.Default.delaySec.ToString();
            met = new Methods();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            inpFileTxt.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!met.IsAllDigits(delBetInpTxt.Text)) || (!met.IsAllDigits(prtTxt.Text)))
            {
                MessageBox.Show("Enter Only numbers for PORT and TIME DELAY", "Error");
            }
            else
            {
                Properties.Settings.Default.portNo = Convert.ToInt32(prtTxt.Text);
                Properties.Settings.Default.delaySec = Convert.ToInt32(delBetInpTxt.Text);
                Properties.Settings.Default.Save();
                //MessageBox.Show("Changes will be applied only after application restart", "Notification");      

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            prtTxt.Text = Properties.Settings.Default.portNo.ToString();
            delBetInpTxt.Text = Properties.Settings.Default.delaySec.ToString();
        }
    }
}
