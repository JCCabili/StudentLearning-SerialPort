﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThermalPrinter
{
    // display this publicly
    delegate void PrinterProcess(string message);

    public partial class ThermalPrinter : Form
    {
        private SerialPort _serialPort;
        private List<string> _receipt;
        private int _printerMaxLenght = 13;
        public ThermalPrinter()
        {
            InitializeComponent();
            LoadInitial();
        }
        private void LoadInitial()
        {
            _receipt = new List<string>();
            if (LoadPrinter()) MessageBox.Show("Device loaded.");
            addHeaders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in _receipt)
            {
                _serialPort.WriteLine(item);
                _serialPort.WriteLine(" ");
            }

            //_serialPort.WriteLine("Testing");
            

            //MessageBox.Show("Printing...");
        }

        /// <summary>
        /// This function will load your device and return true or false during the connection.
        /// </summary>
        /// <returns></returns>
        private bool LoadPrinter()
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = "COM7";
                _serialPort.BaudRate = 9600;
                _serialPort.DataBits = 8;
                _serialPort.Parity = Parity.None;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.None;
                _serialPort.Encoding = System.Text.Encoding.Default;
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
        public void ClosePrinter()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
             
            }

        }

        private void addHeaders()
        {
            this.addMessage("Ayala Center Makati".ToUpper());
            this.addMessage("Makati Avenue corner, Ayala Avenue, Makati, 1200 Metro ".ToUpper());
            this.addMessage("Phone: (02) 813 8888".ToUpper());
        }
        private void addMessage(string message)
        {
            int lineCount = message.Length / _printerMaxLenght;
            int restValue = message.Length % _printerMaxLenght;
            int lengthProcess = 0;

            if (lineCount > 0)
            {
                for (int i = 0; i < lineCount; i++)
                {

                    _receipt.Add(string.Format("{0}", message.Substring(lengthProcess, _printerMaxLenght)));
                    lengthProcess += _printerMaxLenght;
                }
            }

            if (restValue > 0)
            {
                var value = message.Substring(lengthProcess, restValue);
                _receipt.Add(string.Format("{0}", value.CenterString(_printerMaxLenght)));
            }


        }
        

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            addMessage(txtMessage.Text);
            displayReceipt();
        }

        private void displayReceipt()
        {
            txtReceipt.Text = string.Empty;

            foreach (var item in _receipt)
            {
                txtReceipt.Text += (item + Environment.NewLine);
            }

            
        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            _receipt = new List<string>();
            displayReceipt();
        }
    }
}
