﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    // display this publicly
    delegate void CoinProcess(string message);

    public partial class SerialForm : Form
    {

        private SerialPort _serialPort;
        private StringBuilder messages;
        private int amount = 0;
        public SerialForm()
        {
            InitializeComponent();
            LoadInitial();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (LoadDevice())
                messages.AppendLine("Device connected.");
            else
                messages.AppendLine("Loading device failed.");
        }
        private void LoadInitial()
        {
            messages = new StringBuilder();
        }
        
        /// <summary>
        /// This function will load your device and return true or false during the connection.
        /// </summary>
        /// <returns></returns>
        private bool LoadDevice()
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = "COM4";
                _serialPort.BaudRate = 9600;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(coinReceive);
                _serialPort.Open();
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Close your open port.
        /// </summary>
        public void CloseDevice()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                messages.AppendLine("Device close.");
            }
        }
        /// <summary>
        /// This event is triggered when data receive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coinReceive(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            try
            {
                this.BeginInvoke(new CoinProcess(dataReceive), indata);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// This method calls when receiving data from the serial port.
        /// </summary>
        /// <param name="messasge"></param>
        private void dataReceive(string messasge)
        {
            if (messasge == "1\r")
                amount++;
            txtMessages.Text = amount.ToString();
        }
        /// <summary>
        /// This event triggers when the data receiving is done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            CloseDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amount = 0;
        }

      
    }
}
