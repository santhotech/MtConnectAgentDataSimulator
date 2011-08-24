namespace AgentDataSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.strt = new System.Windows.Forms.Button();
            this.stp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cliNumStatLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.agentStrt = new System.Windows.Forms.Button();
            this.agentStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agentSettings = new System.Windows.Forms.Button();
            this.currStat = new System.Windows.Forms.TextBox();
            this.inpDataClearBtn = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.clearAgenData = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.expTxtBtn = new System.Windows.Forms.Button();
            this.expCsvBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.simStngBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simPrtTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.simStatBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.simDelTxt = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.agntStatBtn = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.cliStatBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dcdrStngs = new System.Windows.Forms.Button();
            this.dcdrStp = new System.Windows.Forms.Button();
            this.dcdrStrt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // strt
            // 
            this.strt.Enabled = false;
            this.strt.Location = new System.Drawing.Point(10, 22);
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(83, 23);
            this.strt.TabIndex = 0;
            this.strt.Text = "Start";
            this.strt.UseVisualStyleBackColor = true;
            this.strt.Click += new System.EventHandler(this.strt_Click);
            // 
            // stp
            // 
            this.stp.Enabled = false;
            this.stp.Location = new System.Drawing.Point(99, 22);
            this.stp.Name = "stp";
            this.stp.Size = new System.Drawing.Size(75, 23);
            this.stp.TabIndex = 1;
            this.stp.Text = "Stop";
            this.stp.UseVisualStyleBackColor = true;
            this.stp.Click += new System.EventHandler(this.stp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Status: ";
            // 
            // cliNumStatLbl
            // 
            this.cliNumStatLbl.AutoSize = true;
            this.cliNumStatLbl.Location = new System.Drawing.Point(91, 1);
            this.cliNumStatLbl.Name = "cliNumStatLbl";
            this.cliNumStatLbl.Size = new System.Drawing.Size(79, 13);
            this.cliNumStatLbl.TabIndex = 6;
            this.cliNumStatLbl.Text = "Not Connected";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // agentStrt
            // 
            this.agentStrt.Location = new System.Drawing.Point(9, 19);
            this.agentStrt.Name = "agentStrt";
            this.agentStrt.Size = new System.Drawing.Size(84, 23);
            this.agentStrt.TabIndex = 13;
            this.agentStrt.Text = "Start";
            this.agentStrt.UseVisualStyleBackColor = true;
            this.agentStrt.Click += new System.EventHandler(this.agentStrt_Click);
            // 
            // agentStop
            // 
            this.agentStop.Enabled = false;
            this.agentStop.Location = new System.Drawing.Point(99, 19);
            this.agentStop.Name = "agentStop";
            this.agentStop.Size = new System.Drawing.Size(75, 23);
            this.agentStop.TabIndex = 14;
            this.agentStop.Text = "Stop";
            this.agentStop.UseVisualStyleBackColor = true;
            this.agentStop.Click += new System.EventHandler(this.agentStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agentSettings);
            this.groupBox1.Controls.Add(this.agentStop);
            this.groupBox1.Controls.Add(this.agentStrt);
            this.groupBox1.Location = new System.Drawing.Point(7, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 50);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent Controls";
            // 
            // agentSettings
            // 
            this.agentSettings.Location = new System.Drawing.Point(180, 19);
            this.agentSettings.Name = "agentSettings";
            this.agentSettings.Size = new System.Drawing.Size(89, 23);
            this.agentSettings.TabIndex = 15;
            this.agentSettings.Text = "Settings";
            this.agentSettings.UseVisualStyleBackColor = true;
            this.agentSettings.Click += new System.EventHandler(this.agentSettings_Click);
            // 
            // currStat
            // 
            this.currStat.Location = new System.Drawing.Point(6, 19);
            this.currStat.Multiline = true;
            this.currStat.Name = "currStat";
            this.currStat.ReadOnly = true;
            this.currStat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currStat.Size = new System.Drawing.Size(259, 117);
            this.currStat.TabIndex = 23;
            // 
            // inpDataClearBtn
            // 
            this.inpDataClearBtn.Location = new System.Drawing.Point(6, 142);
            this.inpDataClearBtn.Name = "inpDataClearBtn";
            this.inpDataClearBtn.Size = new System.Drawing.Size(75, 23);
            this.inpDataClearBtn.TabIndex = 24;
            this.inpDataClearBtn.Text = "Clear";
            this.inpDataClearBtn.UseVisualStyleBackColor = true;
            this.inpDataClearBtn.Click += new System.EventHandler(this.inpDataClearBtn_Click);
            // 
            // ListView1
            // 
            this.ListView1.Enabled = false;
            this.ListView1.Location = new System.Drawing.Point(9, 19);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(349, 214);
            this.ListView1.TabIndex = 25;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // clearAgenData
            // 
            this.clearAgenData.Location = new System.Drawing.Point(9, 236);
            this.clearAgenData.Name = "clearAgenData";
            this.clearAgenData.Size = new System.Drawing.Size(75, 23);
            this.clearAgenData.TabIndex = 28;
            this.clearAgenData.Text = "Clear";
            this.clearAgenData.UseVisualStyleBackColor = true;
            this.clearAgenData.Click += new System.EventHandler(this.clearAgenData_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.ControlText;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(143, 59);
            this.Logo.TabIndex = 29;
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Location = new System.Drawing.Point(7, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 69);
            this.panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Agent Data Simulator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListView1);
            this.groupBox3.Controls.Add(this.expTxtBtn);
            this.groupBox3.Controls.Add(this.expCsvBtn);
            this.groupBox3.Controls.Add(this.clearAgenData);
            this.groupBox3.Location = new System.Drawing.Point(7, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 265);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML Decoded Data from Agent";
            // 
            // expTxtBtn
            // 
            this.expTxtBtn.Location = new System.Drawing.Point(194, 236);
            this.expTxtBtn.Name = "expTxtBtn";
            this.expTxtBtn.Size = new System.Drawing.Size(98, 23);
            this.expTxtBtn.TabIndex = 28;
            this.expTxtBtn.Text = "Export to Text";
            this.expTxtBtn.UseVisualStyleBackColor = true;
            this.expTxtBtn.Click += new System.EventHandler(this.expTxtBtn_Click);
            // 
            // expCsvBtn
            // 
            this.expCsvBtn.Location = new System.Drawing.Point(90, 236);
            this.expCsvBtn.Name = "expCsvBtn";
            this.expCsvBtn.Size = new System.Drawing.Size(98, 23);
            this.expCsvBtn.TabIndex = 28;
            this.expCsvBtn.Text = "Export to CSV";
            this.expCsvBtn.UseVisualStyleBackColor = true;
            this.expCsvBtn.Click += new System.EventHandler(this.expCsvBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.simStngBtn);
            this.groupBox4.Controls.Add(this.stp);
            this.groupBox4.Controls.Add(this.strt);
            this.groupBox4.Location = new System.Drawing.Point(7, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 51);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulator Controls";
            // 
            // simStngBtn
            // 
            this.simStngBtn.Location = new System.Drawing.Point(180, 22);
            this.simStngBtn.Name = "simStngBtn";
            this.simStngBtn.Size = new System.Drawing.Size(89, 23);
            this.simStngBtn.TabIndex = 16;
            this.simStngBtn.Text = "Settings";
            this.simStngBtn.UseVisualStyleBackColor = true;
            this.simStngBtn.Click += new System.EventHandler(this.simStngBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.currStat);
            this.groupBox5.Controls.Add(this.inpDataClearBtn);
            this.groupBox5.Location = new System.Drawing.Point(293, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 171);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Input Data being Sent";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel1);
            this.groupBox7.Location = new System.Drawing.Point(377, 249);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(187, 105);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Simulator Status";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.simPrtTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.simStatBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.simDelTxt, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // simPrtTxt
            // 
            this.simPrtTxt.AutoSize = true;
            this.simPrtTxt.Location = new System.Drawing.Point(91, 1);
            this.simPrtTxt.Name = "simPrtTxt";
            this.simPrtTxt.Size = new System.Drawing.Size(31, 13);
            this.simPrtTxt.TabIndex = 11;
            this.simPrtTxt.Text = "9000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sim Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Status";
            // 
            // simStatBtn
            // 
            this.simStatBtn.BackColor = System.Drawing.Color.Red;
            this.simStatBtn.Enabled = false;
            this.simStatBtn.Location = new System.Drawing.Point(91, 29);
            this.simStatBtn.Name = "simStatBtn";
            this.simStatBtn.Size = new System.Drawing.Size(80, 18);
            this.simStatBtn.TabIndex = 12;
            this.simStatBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay";
            // 
            // simDelTxt
            // 
            this.simDelTxt.AutoSize = true;
            this.simDelTxt.Location = new System.Drawing.Point(91, 51);
            this.simDelTxt.Name = "simDelTxt";
            this.simDelTxt.Size = new System.Drawing.Size(29, 13);
            this.simDelTxt.TabIndex = 11;
            this.simDelTxt.Text = "1 ms";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel2);
            this.groupBox8.Location = new System.Drawing.Point(377, 360);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(187, 74);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Agent Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.agntStatBtn, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "5000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Agent Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Status";
            // 
            // agntStatBtn
            // 
            this.agntStatBtn.BackColor = System.Drawing.Color.Red;
            this.agntStatBtn.Enabled = false;
            this.agntStatBtn.Location = new System.Drawing.Point(91, 28);
            this.agntStatBtn.Name = "agntStatBtn";
            this.agntStatBtn.Size = new System.Drawing.Size(80, 17);
            this.agntStatBtn.TabIndex = 12;
            this.agntStatBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel3);
            this.groupBox9.Location = new System.Drawing.Point(377, 440);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(187, 74);
            this.groupBox9.TabIndex = 36;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Client Status";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cliStatBtn, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cliNumStatLbl, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(175, 49);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Status";
            // 
            // cliStatBtn
            // 
            this.cliStatBtn.BackColor = System.Drawing.Color.Red;
            this.cliStatBtn.Enabled = false;
            this.cliStatBtn.Location = new System.Drawing.Point(91, 28);
            this.cliStatBtn.Name = "cliStatBtn";
            this.cliStatBtn.Size = new System.Drawing.Size(80, 17);
            this.cliStatBtn.TabIndex = 12;
            this.cliStatBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dcdrStngs);
            this.groupBox2.Controls.Add(this.dcdrStp);
            this.groupBox2.Controls.Add(this.dcdrStrt);
            this.groupBox2.Location = new System.Drawing.Point(7, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 58);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML Decoder Controls";
            // 
            // dcdrStngs
            // 
            this.dcdrStngs.Location = new System.Drawing.Point(180, 19);
            this.dcdrStngs.Name = "dcdrStngs";
            this.dcdrStngs.Size = new System.Drawing.Size(89, 23);
            this.dcdrStngs.TabIndex = 15;
            this.dcdrStngs.Text = "Settings";
            this.dcdrStngs.UseVisualStyleBackColor = true;
            this.dcdrStngs.Click += new System.EventHandler(this.dcdrStngs_Click);
            // 
            // dcdrStp
            // 
            this.dcdrStp.Enabled = false;
            this.dcdrStp.Location = new System.Drawing.Point(99, 19);
            this.dcdrStp.Name = "dcdrStp";
            this.dcdrStp.Size = new System.Drawing.Size(75, 23);
            this.dcdrStp.TabIndex = 14;
            this.dcdrStp.Text = "Stop";
            this.dcdrStp.UseVisualStyleBackColor = true;
            this.dcdrStp.Click += new System.EventHandler(this.dcdrStp_Click);
            // 
            // dcdrStrt
            // 
            this.dcdrStrt.Location = new System.Drawing.Point(9, 19);
            this.dcdrStrt.Name = "dcdrStrt";
            this.dcdrStrt.Size = new System.Drawing.Size(84, 23);
            this.dcdrStrt.TabIndex = 13;
            this.dcdrStrt.Text = "Start";
            this.dcdrStrt.UseVisualStyleBackColor = true;
            this.dcdrStrt.Click += new System.EventHandler(this.dcdrStrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agent Data Simulator";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button strt;
        private System.Windows.Forms.Button stp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cliNumStatLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button agentStrt;
        private System.Windows.Forms.Button agentStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox currStat;
        private System.Windows.Forms.Button inpDataClearBtn;
        internal System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Button clearAgenData;
        internal System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button agentSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button simStngBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button expCsvBtn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label simPrtTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button simStatBtn;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button agntStatBtn;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button cliStatBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label simDelTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button expTxtBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dcdrStngs;
        private System.Windows.Forms.Button dcdrStp;
        private System.Windows.Forms.Button dcdrStrt;        
    }
}

