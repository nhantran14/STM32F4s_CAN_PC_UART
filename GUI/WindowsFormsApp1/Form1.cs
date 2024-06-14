using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        void InitCom()
        {
            ccbComName.DataSource = SerialPort.GetPortNames(); // doc cong com tren may tinh
        }

        void bytetostring(byte[] data)
        {
            string[] s0 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int a = data[0] - 0x30;
            int b = data[2] - 0x30;
            int c = data[3] - 0x30;
            txtReadSerial.Text += s0[a] + "." + s0[b] + s0[c] + " ";
            Thread.Sleep(1000);
        }

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // cho phep nhan du lieu
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitCom();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:   //nhan escape de thoat form
                    Close();
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (btnOpen.Text == "Open")
            {
                if (ccbBaudrate.Text != "4800" && ccbBaudrate.Text != "9600" && ccbBaudrate.Text != "19200" && ccbBaudrate.Text != "115200")
                {
                    MessageBox.Show("Baudrate Not Found");
                }
                else
                {
                    serialPort1.PortName = ccbComName.Text;
                    serialPort1.Open();
                    btnOpen.Text = "Close";
                    serialPort1.BaudRate = int.Parse(ccbBaudrate.Text); //chuyen gia tri da chon thanh baudrate
                    ccbBaudrate.Enabled = false;
                    ccbComName.Enabled = false;
                    MessageBox.Show("Connected");
                }
            }
            else if (btnOpen.Text == "Close")
            {
                if (serialPort1.IsOpen == true)
                {
                    btnOpen.Text = "Open";
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer(); //reset ca 2 buffer nhan va gui

                    serialPort1.Close();
                    ccbBaudrate.Enabled = true;
                    ccbComName.Enabled = true;      //khi dong Serialport thi co the chon lai baudrate de bat dau chu trinh moi
                    txtReadSerial.ResetText();
                    MessageBox.Show("Not Connected");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)     //khi serialport nhan dc data 
        {
            if (serialPort1.IsOpen == true)
            {
                byte[] dataReceive = new byte[5];
                //dataReceive[0] = (byte)serialPort1.ReadByte();
                //int n = dataReceive[0] % 16;

                for (int i = 0; i < 5; i++)
                {
                    dataReceive[i] = (byte)serialPort1.ReadByte();
                }

                if (dataReceive[4] == ' ' && stop.Checked == false && allow.Checked == true) bytetostring(dataReceive);
                txtReadSerial.SelectionStart = txtReadSerial.TextLength;
                txtReadSerial.ScrollToCaret();
            }
        }
        
        private void Trs_btn_Click(object sender, EventArgs e)
        {
            string str = trs.Text;
            byte[] trs_arr = Encoding.UTF8.GetBytes(str);
            //int n = trs_arr[0] % 16;
            serialPort1.Write(trs_arr, 0, trs_arr.Length);
        }
    }
 }

