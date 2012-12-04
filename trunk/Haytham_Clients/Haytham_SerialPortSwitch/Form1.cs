﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace Haytham_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Icon ico = new Icon(Properties.Resources.Untitled_2, 64, 64);
            this.Icon = ico;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClientStatus.client = new TcpClient();
            ClientStatus.serverip = IPAddress.Parse(textBox1.Text); ;



            try
            {
                ClientStatus.client.Connect(ClientStatus.serverip, 50000);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Server not found\r\n" + "Check the server IP again!");
                return;
            }





            Form_BOCU form_BOCU;


            try
            {
                ClientStatus.Connect();

                form_BOCU = new Form_BOCU(this);
                form_BOCU.Show();
                this.Hide();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Another <" + ClientStatus.type + " > is already connected to the server.");
                return;
            }





        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

     
        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }






  


    }

}
