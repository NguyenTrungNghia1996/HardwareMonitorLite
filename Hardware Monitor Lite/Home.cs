using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;
using Newtonsoft.Json;
using System.IO.Ports;

namespace Hardware_Monitor_Lite
{
    public partial class Home : Form
    {
        readonly private Computer thisComputer = new Computer();
        public TcpClient client = new TcpClient();
        string cpuName = "", gpuName = "", strNw = "",hdd,ssd;
        float cpuLoad = 0, cpuTemp = 0;
        float gpuLoad = 0, gpuTemp = 0, gpuFan = 0, gpuFanLoad = 0;
        float ramLoad = 0, ramUse = 0, totalRam = 0;
        float upload = 0, download = 0;
        float hddUse, hddLoad, hddTemp, ssdUse, ssdLoad, ssdTemp;

        private void btnWired_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cbbCom.Text;
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["port"].Value = cbbCom.Text;
                    _config.Save();
                    serialPort1.Open();
                    btnWired.Text = "Disconnect";
                    btnWired.ForeColor = Color.Red;
                    lblStatusWired.Text = "Connected";
                    lblStatusWired.ForeColor = Color.Green;
                    AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                }
                else
                {
                    serialPort1.Close();
                    btnWired.Text = "Connect";
                    btnWired.ForeColor = Color.Black;
                    lblStatusWired.Text = "Disconnect";
                    lblStatusWired.ForeColor = Color.Red;
                    AppIcon.ShowBalloonTip(5000, "Đã ngắt kết nối ", "Disconnected", ToolTipIcon.Warning);
                }
            }
            catch
            {
                AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy PORT", ToolTipIcon.Warning);
            }

        }
        public class Processor
        {
            public string Name { get; set; }
            public double Load { get; set; }
            public double Temp { get; set; }
        }
        public class Graphic
        {
            public string Name { get; set; }
            public double Load { get; set; }
            public double Temp { get; set; }
        }
        public class Ram
        {
            public string Use { get; set; }
        }
        public class Connection
        {
            public string Speed { get; set; }
        }
        public class HDD
        {
            public string Name { get; set; }
            public double Use { get; set; }
            public double Temp { get; set; }
            public double Load { get; set; }
        }
        public class SSD
        {
            public string Name { get; set; }
            public double Use { get; set; }
            public double Temp { get; set; }
            public double Load { get; set; }
        }
        public class Infomation
        {
            public Processor CPU { get; set; }
            public Graphic GPU { get; set; }
            public Ram RAM { get; set; }
            public Connection Net { get; set; }
            public HDD hddDrive { get; set; }
            public SSD ssdDrive { get; set; }
        }


        public Home()
        {
            InitializeComponent();
            this.thisComputer.IsCpuEnabled = true;
            this.thisComputer.IsGpuEnabled = true;
            this.thisComputer.IsStorageEnabled = true;
            this.thisComputer.IsMemoryEnabled = true;
            this.thisComputer.IsNetworkEnabled = true;
            this.thisComputer.Open();
            timer1.Interval = 1000;
            timer1.Start();
            AddMenu();
            /*AUTO*/
            if (ConfigurationManager.AppSettings["autoConnectWifi"].ToString().ToLower().Equals("true"))
            {
                ckAutoWifi.CheckState = CheckState.Checked;
            }
            else
            {
                ckAutoWifi.CheckState = CheckState.Unchecked;
            }
            if (ConfigurationManager.AppSettings["autoConnectWired"].ToString().ToLower().Equals("true"))
            {
                ckAutoWired.CheckState = CheckState.Checked;
            }
            else
            {
                ckAutoWired.CheckState = CheckState.Unchecked;
            }
            if (ConfigurationManager.AppSettings["state"].ToString().ToLower().Equals("true"))
            {
                base.WindowState = FormWindowState.Minimized;
                base.ShowInTaskbar = false;
                ckMini.CheckState = CheckState.Checked;
            }
            else
            {
                base.WindowState = FormWindowState.Normal;
                base.ShowInTaskbar = true;
                ckMini.CheckState = CheckState.Unchecked;
            }
            serialPort1.BaudRate = 115200;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;
            serialPort1.RtsEnable = true;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbbCom.Items.Add(port);
            }
            cbbCom.SelectedIndex = cbbCom.Items.IndexOf(ConfigurationManager.AppSettings["port"].ToString());
            if (ckAutoWired.Checked == true)
            {
                if (cbbCom.Text != "")
                {
                    try
                    {
                        serialPort1.PortName = cbbCom.Text;
                        if (!serialPort1.IsOpen)
                        {
                            serialPort1.Open();
                            btnWired.Text = "Disconnect";
                            btnWired.ForeColor = Color.Red;
                            lblStatusWired.Text = "Connected";
                            lblStatusWired.ForeColor = Color.Green;
                            AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                        }
                    }
                    catch
                    {
                        AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy Port", ToolTipIcon.Warning);
                        btnWired.Text = "Connect";
                        btnWired.ForeColor = Color.Black;
                        lblStatusWired.Text = "Disconnected";
                        lblStatusWired.ForeColor = Color.Red;
                    }
                }

            }
            /*WIFI*/
            string ip = ConfigurationManager.AppSettings["ip"].ToString();
            if (ip != "")
            {
                txtIP.Text = ip;
            }
            if (ckAutoWifi.Checked == true)
            {
                if (ip == "")
                {
                    AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không có địa chỉ IP để kết nối\r\nYêu cầu nhập địa chỉ IP của server", ToolTipIcon.Warning);
                }
                else
                {
                    client.ConnectAsync(ip, 80).Wait(3000);
                    if (client.Connected)
                    {
                        txtIP.Enabled = false;
                        btnConnectWIFI.Text = "Disconnect";
                        btnConnectWIFI.ForeColor = Color.Red;
                        lblWIFIStatus.Text = "Connected";
                        lblWIFIStatus.ForeColor = Color.Green;
                        AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                    }
                    else
                    {
                        AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy server", ToolTipIcon.Warning);
                        client.Close();
                        btnConnectWIFI.Text = "Connect";
                        btnConnectWIFI.ForeColor = Color.Black;
                        lblWIFIStatus.Text = "Disconnected";
                        lblWIFIStatus.ForeColor = Color.Red;
                        client = new TcpClient();
                    }
                }
            }
        }
        private void AddMenu()
        {
            this.AppIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.AppIcon.ContextMenuStrip.Items.Add("Show", null, this.OpenConnectForm);
            this.AppIcon.ContextMenuStrip.Items.Add("About", null, this.OpenAboutForm);
            this.AppIcon.ContextMenuStrip.Items.Add("Exit", null, this.Exit);
        }
        private void OpenConnectForm(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Normal;  // Mở cửa sổ Connect
            base.ShowInTaskbar = true;
            base.Visible = false;
            base.Focus();
            base.Show();
        }

        private void OpenAboutForm(object sender, EventArgs e)      // Mở cửa sổ About
        {
            new About().Show();
        }
        private void Exit(object sender, EventArgs e)               // Thoát chương trình
        {
            Application.Exit();
            AppIcon.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cbbCom.DataSource = SerialPort.GetPortNames();

            foreach (var hardware in thisComputer.Hardware)
            {
                hardware.Update();
                /*---------------------------------CPU---------------------------------*/
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    cpuName = hardware.Name;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            cpuLoad = sensor.Value.Value;
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package")
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
                /*---------------------------------GPU---------------------------------*/
                if (hardware.HardwareType == HardwareType.GpuAmd || hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    gpuName = hardware.Name;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            gpuLoad = sensor.Value.Value;
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "GPU Core")
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Fan && sensor.Name == "GPU Fan")
                        {
                            gpuFan = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Control && sensor.Name == "GPU Fan")
                        {
                            gpuFanLoad = sensor.Value.GetValueOrDefault();
                        }

                    }

                }
                /*---------------------------------RAM---------------------------------*/
                if (hardware.HardwareType == HardwareType.Memory)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Memory")
                        {
                            ramLoad = sensor.Value.Value;
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Memory Used")
                        {
                            ramUse = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Memory Available")
                        {
                            float ramAva = sensor.Value.GetValueOrDefault();
                            totalRam = ramAva + ramUse;
                        }
                    }
                }
                /*---------------------------------Connection---------------------------------*/
                if (hardware.HardwareType == HardwareType.Network)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Throughput && sensor.Name == "Upload Speed")
                        {
                            upload = (sensor.Value.GetValueOrDefault()) * 8 / 1048576;
                        }
                        if (sensor.SensorType == SensorType.Throughput && sensor.Name == "Download Speed")
                        {
                            download = (sensor.Value.GetValueOrDefault()) * 8 / 1048576;
                        }
                        strNw = Math.Round(download, 2).ToString("F2") + "/" + Math.Round(upload, 2).ToString("F2");
                        if (strNw.Length > 10)
                        {
                            strNw = "Connecting...";
                        }
                    }
                }
                /*---------------------------------Drive---------------------------------*/
                if (hardware.Name == "WDC WD10EZEX-00WN4A0")
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        hdd = hardware.Name;
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Total Activity")
                        {
                            hddLoad = sensor.Value.Value;
                        }
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "Temperature")
                        {
                            hddTemp = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Used Space")
                        {
                            hddUse = sensor.Value.GetValueOrDefault();
                        }
                    }
                }

                if (hardware.Name == "Samsung SSD 960 EVO 250GB")
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        ssd = hardware.Name;
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Total Activity")
                        {
                            ssdLoad = sensor.Value.Value;
                        }
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "Temperature")
                        {
                            ssdTemp = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Used Space")
                        {
                            ssdUse = sensor.Value.GetValueOrDefault();
                        }
                    }
                }

                if (hardware.HardwareType == HardwareType.Heatmaster)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            cpuLoad = sensor.Value.Value;
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package")
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
                /*---------------------------------Display---------------------------------*/
                grCPU.Text = cpuName;
                txtLoadCPU.Text = Math.Round(cpuLoad).ToString()+" %";
                txtTempCPU.Text = Math.Round(cpuTemp).ToString() + " °C";

                grGPU.Text = gpuName;
                txtLoadGPU.Text = Math.Round(gpuLoad).ToString() + " %";
                txtTempGPU.Text = Math.Round(gpuTemp).ToString() + " °C";
                txtFanGPU.Text = Math.Round(gpuFan).ToString() + " RPM";

                txtTotalRam.Text = Math.Round(totalRam).ToString() + " GB";
                txtRamUse.Text = Math.Round(ramUse).ToString() + " GB";
                txtRamLoad.Text = Math.Round(ramLoad).ToString() + " %";

                txtDown.Text = Math.Round(download, 2).ToString("F2") + " MB/s";
                txtUp.Text = Math.Round(upload, 2).ToString("F2") + " MB/s";

                grHDD.Text = hdd;
                txtHddLoad.Text = Math.Round(hddLoad).ToString() + " %";
                txtHddUse.Text = Math.Round(hddUse).ToString() + " %";
                txtHddTemp.Text = Math.Round(hddTemp).ToString() + " °C";

                grSSD.Text = ssd;
                txtSsdLoad.Text = Math.Round(ssdLoad).ToString() + " %";
                txtSsdUse.Text = Math.Round(ssdUse).ToString() + " %";
                txtSsdTemp.Text = Math.Round(ssdTemp).ToString() + " °C";
                /*---------------------------------Send DATA---------------------------------*/
                
            }
            Processor dataCPU = new Processor
            {
                Name = cpuName,
                Load = Math.Round(cpuLoad, 1),
                Temp = Math.Round(cpuTemp, 1)
            };
            Graphic dataGPU = new Graphic
            {
                Name = gpuName,
                Load = Math.Round(gpuLoad, 1),
                Temp = Math.Round(gpuTemp, 1),
            };
            Ram dataRam = new Ram
            {
                Use = Math.Round(ramUse).ToString() + "/" + Math.Round(totalRam).ToString()
            };
            Connection dataNet = new Connection
            {
                Speed = strNw
            };
            HDD infoHDD = new HDD
            {
                Name = hdd,
                Use = Math.Round(hddUse),
                Load = Math.Round(hddLoad),
                Temp = Math.Round(hddTemp)

            };
            SSD infoSSD = new SSD
            {
                Name = ssd,
                Use = Math.Round(ssdUse),
                Load = Math.Round(ssdLoad),
                Temp = Math.Round(ssdTemp)
            };
            Infomation info = new Infomation
            {
                CPU = dataCPU,
                GPU = dataGPU,
                RAM = dataRam,
                Net = dataNet,
                hddDrive = infoHDD,
                ssdDrive = infoSSD
            };
            string obj = JsonConvert.SerializeObject(info);
            if (lblWIFIStatus.Text == "Connected")
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.ASCII.GetBytes(obj + "\r\n");
                    stream.Write(data, 0, data.Length);
                }
                catch (Exception)
                {
                    AppIcon.ShowBalloonTip(5000, "Mất kêt nối", "Kiểm tra lại server", ToolTipIcon.Warning);
                    txtIP.Enabled = true;
                    timer1.Enabled = false;
                    btnConnectWIFI.Text = "Connect";
                    lblWIFIStatus.Text = "Disconnected";
                    lblWIFIStatus.ForeColor = Color.Red;
                    client.Close();
                    client = new TcpClient();
                }
            }
        }
        private void btnConnectWIFI_Click(object sender, EventArgs e)
        {
            if (btnConnectWIFI.Text == "Connect")
            {
                lblWIFIStatus.Text = "Connecting...";
                lblWIFIStatus.ForeColor = Color.Black;
                btnConnectWIFI.Enabled = false;

                try
                {
                    client.ConnectAsync(txtIP.Text, 80).Wait(5000);
                }
                catch
                {
                    AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Địa Chỉ IP không đúng !!", ToolTipIcon.Warning);
                    lblWIFIStatus.Text = "Disconnected";
                    lblWIFIStatus.ForeColor = Color.Red;
                }
                if (client.Connected)
                {
                    txtIP.Enabled = false;
                    btnConnectWIFI.Text = "Disconnect";
                    btnConnectWIFI.ForeColor = Color.Red;
                    lblWIFIStatus.Text = "Connected";
                    lblWIFIStatus.ForeColor = Color.Green;
                    AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["ip"].Value = txtIP.Text;
                    _config.Save();
                }
                else
                {
                    AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy server", ToolTipIcon.Warning);
                    lblWIFIStatus.Text = "Disconnect";
                    lblWIFIStatus.ForeColor = Color.Red;
                    client.Close();
                    client = new TcpClient();
                }
            }
            else
            {
                txtIP.Enabled = true;
                btnConnectWIFI.Text = "Connect";
                btnConnectWIFI.ForeColor = Color.Black;
                lblWIFIStatus.Text = "Disconnect";
                lblWIFIStatus.ForeColor = Color.Red;
                client.Close();
                client = new TcpClient();
            }
            btnConnectWIFI.Enabled = true;
        }
        private void ckAutoWifi_CheckedChanged(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["autoConnectWifi"].Value = ckAutoWifi.Checked.ToString();
            _config.Save();
        }
        private void ckAutoWired_CheckedChanged(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["autoConnectWired"].Value = ckAutoWired.Checked.ToString();
            _config.Save();
        }
        private void AppIcon_DoubleClick(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Normal;
            base.ShowInTaskbar = true;
            base.Visible = false;
            base.Focus();
            base.Show();
        }
        private void Home_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                base.ShowInTaskbar = false;
                base.Visible = true;
                AppIcon.ShowBalloonTip(500, "Đang Chạy Thu Nhỏ !", "Minimize to tray!", ToolTipIcon.Info);
            }
            else
            {
                //this.Visible = true;
                //this.Show();
                // this.WindowState = FormWindowState.Normal;
                //this.Activate();
                // this.Focus();
                //this.ShowInTaskbar = true;
                base.WindowState = FormWindowState.Normal;
                base.ShowInTaskbar = true;
                base.Visible = false;
                base.Focus();
                base.Show();
            }
        }
        private void ckMini_CheckedChanged(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["state"].Value = ckMini.Checked.ToString();
            _config.Save();
        }
    }
}
