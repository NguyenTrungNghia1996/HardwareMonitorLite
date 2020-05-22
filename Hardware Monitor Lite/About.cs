using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hardware_Monitor_Lite
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lblFB.Links.Remove(lblFB.Links[0]);
            lblFB.Links.Add(0, lblFB.Text.Length, "https://www.facebook.com/trungnghia196");

            lblSC.Links.Remove(lblSC.Links[0]);
            lblSC.Links.Add(0, lblSC.Text.Length, "https://github.com/trungnghia196/MCUHardwareMonitor");

            LblLIB.Links.Remove(LblLIB.Links[0]);
            LblLIB.Links.Add(0, LblLIB.Text.Length, "https://github.com/LibreHardwareMonitor/LibreHardwareMonitor");

            lblVer.Text = "Version " + Application.ProductVersion;
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()));
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
