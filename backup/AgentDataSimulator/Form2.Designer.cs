namespace AgentDataSimulator
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.listfile = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.xmlfile = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.agntExeTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.listfile);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.xmlfile);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.agntExeTxt);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 130);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "List File :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "XML File :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Agent File :";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(180, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 20);
            this.button8.TabIndex = 18;
            this.button8.Text = "Choose File";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listfile
            // 
            this.listfile.Location = new System.Drawing.Point(71, 74);
            this.listfile.Name = "listfile";
            this.listfile.Size = new System.Drawing.Size(103, 20);
            this.listfile.TabIndex = 17;
            this.listfile.Text = "examplelist.txt";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(180, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 20);
            this.button7.TabIndex = 16;
            this.button7.Text = "Choose File";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // xmlfile
            // 
            this.xmlfile.Location = new System.Drawing.Point(71, 48);
            this.xmlfile.Name = "xmlfile";
            this.xmlfile.Size = new System.Drawing.Size(103, 20);
            this.xmlfile.TabIndex = 15;
            this.xmlfile.Text = "example.xml";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 20);
            this.button4.TabIndex = 12;
            this.button4.Text = "Choose File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // agntExeTxt
            // 
            this.agntExeTxt.Location = new System.Drawing.Point(71, 22);
            this.agntExeTxt.Name = "agntExeTxt";
            this.agntExeTxt.Size = new System.Drawing.Size(103, 20);
            this.agntExeTxt.TabIndex = 11;
            this.agntExeTxt.Text = "agent.exe";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(71, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Agent Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox listfile;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox xmlfile;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox agntExeTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}