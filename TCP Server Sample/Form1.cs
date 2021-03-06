﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using SynchronousTCPServerLibrary;

namespace TCP_Server_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        
            TCPServer.onConnect += connected;
            TCPServer.onDisconnect += disconnected;
            TCPServer.onDataReceived += received;
        }


        private void send_btn_Click(object sender, EventArgs e)
        {
            if (send_cbox.Checked)
            {
                TCPServer.broadcastln(send_txt.Text);
                console_txt.AppendText("Server: " + send_txt.Text + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                TCPServer.broadcast(send_txt.Text);
                console_txt.AppendText("Server: " + send_txt.Text + Environment.NewLine);
            }
        }

        private void appendData(string data)
        {
            Debug.WriteLine(data);
            Func<int> l = delegate()
            {
                console_txt.AppendText(data + Environment.NewLine);
                return 0;
            };
            try
            {
                Invoke(l);
            }
            catch (Exception) { }
            
        }

        private void updateUIOnConnect(Boolean connected)
        {
            Func<int> l = delegate()
            {
                if (connected)
                {
                    connect_btn.Text = "Server closed";
                    Connection_lbl.Text = "Server listening";
                    Connection_lbl.ForeColor = Color.LawnGreen;
                    port_txt.Enabled = false;

                    broadcast_btn.Enabled = true;
                    send_txt.Enabled = true;
                }
                else
                {
                    connect_btn.Text = "Server listening";
                    Connection_lbl.Text = "Server closed";
                    Connection_lbl.ForeColor = Color.Red;
                    port_txt.Enabled = true;

                    broadcast_btn.Enabled = false;
                    send_txt.Enabled = false;
                }
                return 0;
            };
            Invoke(l);
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (connect_btn.Text.Equals("Server closed"))
            {
                updateUIOnConnect(false);
                try
                {
                    TCPServer.closeServer();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            else
            {
                TCPServer.startListeningInSeperateThread(Int32.Parse(port_txt.Text), 10);
                updateUIOnConnect(true);
            }
        }


        private void received(string message)
        {
            appendData("Client: " + message);
        }

        private void connected(Socket socket)
        {
            appendData("Client " + socket.LocalEndPoint + " Connected.");
        }

        private void disconnected(Socket socket)
        {
            appendData("Client " + socket.LocalEndPoint + " Disconnected.");
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            TCPServer.closeServer();

            base.OnFormClosing(e);
        }
    }
}