﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;   

namespace TaskHarmony.Properties
{
    public partial class chatwithengineer : Form
    {
         Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public chatwithengineer()
            
        {
            InitializeComponent();
        }

        private void chatwithengineer_Load(object sender, EventArgs e)
        {
            sck=new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textlocalIP.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(textlocalIP.Text), Convert.ToInt32(textlocalPort.Text));
            sck.Bind(epLocal);
            epRemote=new IPEndPoint(IPAddress.Parse(textRemoteIP.Text),Convert.ToInt32(textRemoteIP.Text));
            sck.Connect(epRemote);
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer,0,buffer.Length,SocketFlags.None,ref epRemote,new AsyncCallback(MessageCallback),buffer);
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName()); 
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);
            sck.Send(sendingMessage);
            listMessage.Items.Add("Worker: "+textMessage.Text);
            textMessage.Text = "";

        }

        private void MessageCallback(IAsyncResult aResult)
        {
            try
            { 
            byte[] receivedData = new byte[1500];
            receivedData = (byte[])aResult.AsyncState;
            ASCIIEncoding aEncoding=new ASCIIEncoding();
            string receivedMessage=aEncoding.GetString(receivedData);
            listMessage.Items.Add("Engineer: "+receivedMessage);
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallback), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
