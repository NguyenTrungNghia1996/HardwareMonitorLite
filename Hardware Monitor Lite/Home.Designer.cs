namespace Hardware_Monitor_Lite
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grCPU = new System.Windows.Forms.GroupBox();
            this.txtTempCPU = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoadCPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grGPU = new System.Windows.Forms.GroupBox();
            this.txtFanGPU = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTempGPU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoadGPU = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRamLoad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRamUse = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalRam = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDown = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grHDD = new System.Windows.Forms.GroupBox();
            this.txtHddTemp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHddLoad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHddUse = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grSSD = new System.Windows.Forms.GroupBox();
            this.txtSsdTemp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSsdLoad = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSsdUse = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckAutoWifi = new System.Windows.Forms.CheckBox();
            this.lblWIFIStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnectWIFI = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AppIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbCom = new System.Windows.Forms.ComboBox();
            this.ckAutoWired = new System.Windows.Forms.CheckBox();
            this.lblStatusWired = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnWired = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckMini = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReload = new System.Windows.Forms.Button();
            this.grCPU.SuspendLayout();
            this.grGPU.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grHDD.SuspendLayout();
            this.grSSD.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grCPU
            // 
            this.grCPU.Controls.Add(this.txtTempCPU);
            this.grCPU.Controls.Add(this.label3);
            this.grCPU.Controls.Add(this.txtLoadCPU);
            this.grCPU.Controls.Add(this.label1);
            this.grCPU.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCPU.Location = new System.Drawing.Point(12, 27);
            this.grCPU.Name = "grCPU";
            this.grCPU.Size = new System.Drawing.Size(211, 100);
            this.grCPU.TabIndex = 0;
            this.grCPU.TabStop = false;
            // 
            // txtTempCPU
            // 
            this.txtTempCPU.AutoSize = true;
            this.txtTempCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempCPU.Location = new System.Drawing.Point(112, 60);
            this.txtTempCPU.Name = "txtTempCPU";
            this.txtTempCPU.Size = new System.Drawing.Size(0, 21);
            this.txtTempCPU.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperature:";
            // 
            // txtLoadCPU
            // 
            this.txtLoadCPU.AutoSize = true;
            this.txtLoadCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoadCPU.Location = new System.Drawing.Point(113, 29);
            this.txtLoadCPU.Name = "txtLoadCPU";
            this.txtLoadCPU.Size = new System.Drawing.Size(0, 21);
            this.txtLoadCPU.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load:";
            // 
            // grGPU
            // 
            this.grGPU.Controls.Add(this.txtFanGPU);
            this.grGPU.Controls.Add(this.label8);
            this.grGPU.Controls.Add(this.txtTempGPU);
            this.grGPU.Controls.Add(this.label4);
            this.grGPU.Controls.Add(this.txtLoadGPU);
            this.grGPU.Controls.Add(this.label6);
            this.grGPU.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grGPU.Location = new System.Drawing.Point(229, 27);
            this.grGPU.Name = "grGPU";
            this.grGPU.Size = new System.Drawing.Size(211, 100);
            this.grGPU.TabIndex = 1;
            this.grGPU.TabStop = false;
            // 
            // txtFanGPU
            // 
            this.txtFanGPU.AutoSize = true;
            this.txtFanGPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFanGPU.Location = new System.Drawing.Point(106, 71);
            this.txtFanGPU.Name = "txtFanGPU";
            this.txtFanGPU.Size = new System.Drawing.Size(0, 21);
            this.txtFanGPU.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fan:";
            // 
            // txtTempGPU
            // 
            this.txtTempGPU.AutoSize = true;
            this.txtTempGPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempGPU.Location = new System.Drawing.Point(106, 50);
            this.txtTempGPU.Name = "txtTempGPU";
            this.txtTempGPU.Size = new System.Drawing.Size(0, 21);
            this.txtTempGPU.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature:";
            // 
            // txtLoadGPU
            // 
            this.txtLoadGPU.AutoSize = true;
            this.txtLoadGPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoadGPU.Location = new System.Drawing.Point(106, 29);
            this.txtLoadGPU.Name = "txtLoadGPU";
            this.txtLoadGPU.Size = new System.Drawing.Size(0, 21);
            this.txtLoadGPU.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Load:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRamLoad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRamUse);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTotalRam);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(446, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAM";
            // 
            // txtRamLoad
            // 
            this.txtRamLoad.AutoSize = true;
            this.txtRamLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamLoad.Location = new System.Drawing.Point(94, 71);
            this.txtRamLoad.Name = "txtRamLoad";
            this.txtRamLoad.Size = new System.Drawing.Size(0, 21);
            this.txtRamLoad.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ram Load:";
            // 
            // txtRamUse
            // 
            this.txtRamUse.AutoSize = true;
            this.txtRamUse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamUse.Location = new System.Drawing.Point(94, 50);
            this.txtRamUse.Name = "txtRamUse";
            this.txtRamUse.Size = new System.Drawing.Size(0, 21);
            this.txtRamUse.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ram Use:";
            // 
            // txtTotalRam
            // 
            this.txtTotalRam.AutoSize = true;
            this.txtTotalRam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRam.Location = new System.Drawing.Point(94, 29);
            this.txtTotalRam.Name = "txtTotalRam";
            this.txtTotalRam.Size = new System.Drawing.Size(0, 21);
            this.txtTotalRam.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Ram:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUp);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDown);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(663, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // txtUp
            // 
            this.txtUp.AutoSize = true;
            this.txtUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUp.Location = new System.Drawing.Point(113, 60);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(0, 21);
            this.txtUp.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Upload:";
            // 
            // txtDown
            // 
            this.txtDown.AutoSize = true;
            this.txtDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDown.Location = new System.Drawing.Point(113, 29);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(0, 21);
            this.txtDown.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Download:";
            // 
            // grHDD
            // 
            this.grHDD.Controls.Add(this.txtHddTemp);
            this.grHDD.Controls.Add(this.label18);
            this.grHDD.Controls.Add(this.txtHddLoad);
            this.grHDD.Controls.Add(this.label10);
            this.grHDD.Controls.Add(this.txtHddUse);
            this.grHDD.Controls.Add(this.label15);
            this.grHDD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHDD.Location = new System.Drawing.Point(12, 133);
            this.grHDD.Name = "grHDD";
            this.grHDD.Size = new System.Drawing.Size(428, 100);
            this.grHDD.TabIndex = 11;
            this.grHDD.TabStop = false;
            // 
            // txtHddTemp
            // 
            this.txtHddTemp.AutoSize = true;
            this.txtHddTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHddTemp.Location = new System.Drawing.Point(138, 71);
            this.txtHddTemp.Name = "txtHddTemp";
            this.txtHddTemp.Size = new System.Drawing.Size(0, 21);
            this.txtHddTemp.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 21);
            this.label18.TabIndex = 5;
            this.label18.Text = "Temperature:";
            // 
            // txtHddLoad
            // 
            this.txtHddLoad.AutoSize = true;
            this.txtHddLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHddLoad.Location = new System.Drawing.Point(138, 50);
            this.txtHddLoad.Name = "txtHddLoad";
            this.txtHddLoad.Size = new System.Drawing.Size(0, 21);
            this.txtHddLoad.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Activity:";
            // 
            // txtHddUse
            // 
            this.txtHddUse.AutoSize = true;
            this.txtHddUse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHddUse.Location = new System.Drawing.Point(138, 29);
            this.txtHddUse.Name = "txtHddUse";
            this.txtHddUse.Size = new System.Drawing.Size(0, 21);
            this.txtHddUse.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Used Space:";
            // 
            // grSSD
            // 
            this.grSSD.Controls.Add(this.txtSsdTemp);
            this.grSSD.Controls.Add(this.label12);
            this.grSSD.Controls.Add(this.txtSsdLoad);
            this.grSSD.Controls.Add(this.label19);
            this.grSSD.Controls.Add(this.txtSsdUse);
            this.grSSD.Controls.Add(this.label21);
            this.grSSD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSSD.Location = new System.Drawing.Point(446, 133);
            this.grSSD.Name = "grSSD";
            this.grSSD.Size = new System.Drawing.Size(428, 100);
            this.grSSD.TabIndex = 12;
            this.grSSD.TabStop = false;
            // 
            // txtSsdTemp
            // 
            this.txtSsdTemp.AutoSize = true;
            this.txtSsdTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSsdTemp.Location = new System.Drawing.Point(152, 71);
            this.txtSsdTemp.Name = "txtSsdTemp";
            this.txtSsdTemp.Size = new System.Drawing.Size(0, 21);
            this.txtSsdTemp.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Temperature:";
            // 
            // txtSsdLoad
            // 
            this.txtSsdLoad.AutoSize = true;
            this.txtSsdLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSsdLoad.Location = new System.Drawing.Point(152, 50);
            this.txtSsdLoad.Name = "txtSsdLoad";
            this.txtSsdLoad.Size = new System.Drawing.Size(0, 21);
            this.txtSsdLoad.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 21);
            this.label19.TabIndex = 3;
            this.label19.Text = "Total Activity:";
            // 
            // txtSsdUse
            // 
            this.txtSsdUse.AutoSize = true;
            this.txtSsdUse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSsdUse.Location = new System.Drawing.Point(152, 29);
            this.txtSsdUse.Name = "txtSsdUse";
            this.txtSsdUse.Size = new System.Drawing.Size(0, 21);
            this.txtSsdUse.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Used Space:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckAutoWifi);
            this.groupBox3.Controls.Add(this.lblWIFIStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnConnectWIFI);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wireless Connection";
            // 
            // ckAutoWifi
            // 
            this.ckAutoWifi.AutoSize = true;
            this.ckAutoWifi.Location = new System.Drawing.Point(267, 61);
            this.ckAutoWifi.Name = "ckAutoWifi";
            this.ckAutoWifi.Size = new System.Drawing.Size(141, 29);
            this.ckAutoWifi.TabIndex = 9;
            this.ckAutoWifi.Text = "AutoConnect";
            this.ckAutoWifi.UseVisualStyleBackColor = true;
            this.ckAutoWifi.CheckedChanged += new System.EventHandler(this.ckAutoWifi_CheckedChanged);
            // 
            // lblWIFIStatus
            // 
            this.lblWIFIStatus.AutoSize = true;
            this.lblWIFIStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWIFIStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblWIFIStatus.Location = new System.Drawing.Point(74, 65);
            this.lblWIFIStatus.Name = "lblWIFIStatus";
            this.lblWIFIStatus.Size = new System.Drawing.Size(66, 21);
            this.lblWIFIStatus.TabIndex = 8;
            this.lblWIFIStatus.Text = "Standby";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // btnConnectWIFI
            // 
            this.btnConnectWIFI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectWIFI.Location = new System.Drawing.Point(267, 29);
            this.btnConnectWIFI.Name = "btnConnectWIFI";
            this.btnConnectWIFI.Size = new System.Drawing.Size(141, 33);
            this.btnConnectWIFI.TabIndex = 5;
            this.btnConnectWIFI.Text = "Connect";
            this.btnConnectWIFI.UseVisualStyleBackColor = true;
            this.btnConnectWIFI.Click += new System.EventHandler(this.btnConnectWIFI_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(78, 29);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(183, 33);
            this.txtIP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "MCU IP:";
            // 
            // AppIcon
            // 
            this.AppIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AppIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AppIcon.Icon")));
            this.AppIcon.Text = "Hardware Monitor Lite";
            this.AppIcon.Visible = true;
            this.AppIcon.DoubleClick += new System.EventHandler(this.AppIcon_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReload);
            this.groupBox4.Controls.Add(this.cbbCom);
            this.groupBox4.Controls.Add(this.ckAutoWired);
            this.groupBox4.Controls.Add(this.lblStatusWired);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btnWired);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(446, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wired Connection";
            // 
            // cbbCom
            // 
            this.cbbCom.FormattingEnabled = true;
            this.cbbCom.Location = new System.Drawing.Point(78, 28);
            this.cbbCom.Name = "cbbCom";
            this.cbbCom.Size = new System.Drawing.Size(166, 33);
            this.cbbCom.TabIndex = 10;
            // 
            // ckAutoWired
            // 
            this.ckAutoWired.AutoSize = true;
            this.ckAutoWired.Location = new System.Drawing.Point(267, 61);
            this.ckAutoWired.Name = "ckAutoWired";
            this.ckAutoWired.Size = new System.Drawing.Size(141, 29);
            this.ckAutoWired.TabIndex = 9;
            this.ckAutoWired.Text = "AutoConnect";
            this.ckAutoWired.UseVisualStyleBackColor = true;
            this.ckAutoWired.CheckedChanged += new System.EventHandler(this.ckAutoWired_CheckedChanged);
            // 
            // lblStatusWired
            // 
            this.lblStatusWired.AutoSize = true;
            this.lblStatusWired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusWired.ForeColor = System.Drawing.Color.Yellow;
            this.lblStatusWired.Location = new System.Drawing.Point(74, 65);
            this.lblStatusWired.Name = "lblStatusWired";
            this.lblStatusWired.Size = new System.Drawing.Size(66, 21);
            this.lblStatusWired.TabIndex = 8;
            this.lblStatusWired.Text = "Standby";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 21);
            this.label17.TabIndex = 7;
            this.label17.Text = "Status:";
            // 
            // btnWired
            // 
            this.btnWired.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWired.Location = new System.Drawing.Point(289, 29);
            this.btnWired.Name = "btnWired";
            this.btnWired.Size = new System.Drawing.Size(119, 33);
            this.btnWired.TabIndex = 5;
            this.btnWired.Text = "Connect";
            this.btnWired.UseVisualStyleBackColor = true;
            this.btnWired.Click += new System.EventHandler(this.btnWired_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 21);
            this.label20.TabIndex = 3;
            this.label20.Text = "PORT:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ckMini});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // ckMini
            // 
            this.ckMini.CheckOnClick = true;
            this.ckMini.Name = "ckMini";
            this.ckMini.Size = new System.Drawing.Size(150, 22);
            this.ckMini.Text = "Start Minimize";
            this.ckMini.CheckedChanged += new System.EventHandler(this.ckMini_CheckedChanged);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(250, 29);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(33, 33);
            this.btnReload.TabIndex = 11;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(881, 348);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grSSD);
            this.Controls.Add(this.grHDD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grGPU);
            this.Controls.Add(this.grCPU);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(897, 387);
            this.MinimumSize = new System.Drawing.Size(897, 387);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Monitor Lite";
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.grCPU.ResumeLayout(false);
            this.grCPU.PerformLayout();
            this.grGPU.ResumeLayout(false);
            this.grGPU.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grHDD.ResumeLayout(false);
            this.grHDD.PerformLayout();
            this.grSSD.ResumeLayout(false);
            this.grSSD.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLoadCPU;
        private System.Windows.Forms.Label txtTempCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grGPU;
        private System.Windows.Forms.Label txtTempGPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtLoadGPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtFanGPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtRamLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtRamUse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtTotalRam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtUp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grHDD;
        private System.Windows.Forms.Label txtHddLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtHddUse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtHddTemp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grSSD;
        private System.Windows.Forms.Label txtSsdTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtSsdLoad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtSsdUse;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblWIFIStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConnectWIFI;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckAutoWifi;
        private System.Windows.Forms.NotifyIcon AppIcon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckAutoWired;
        private System.Windows.Forms.Label lblStatusWired;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnWired;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbCom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ckMini;
        private System.Windows.Forms.Button btnReload;
    }
}

