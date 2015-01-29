using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteBase;

namespace RemoteServer
{
    public partial class Form1 : Form
    {
        TcpChannel channel;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (channel == null)
            {
                //koneksi awal
                channel = new TcpChannel(33000);
                //register channel ip:port
                ChannelServices.RegisterChannel(channel, false);
                //meregistrasikan si service remotebase untuk client
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Services), "Lokal", WellKnownObjectMode.Singleton);

                lblStatus.Text = "Berjalan...";
                btnStart.Enabled = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

    }
}

