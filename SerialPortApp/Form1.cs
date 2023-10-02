using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortApp
{
    public partial class Form1 : Form
    {
        string dataOut;
        string dataIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            Cbo_Port.Items.AddRange(ports);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            Txt_Receive.Text += dataIn;
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOut = Txt_Send.Text;
                serialPort1.Write(dataOut);
            }
        }

        private void Btn_Receive_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txt_Message_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = Cbo_Port.Text;
                serialPort1.Open();
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void Btc_clear_send_Click(object sender, EventArgs e)
        {
            if (Txt_Send.Text != "")
            {
                Txt_Send.Text = "";
            }
        }

        private void Btn_Clear_receive_Click(object sender, EventArgs e)
        {
            if (Txt_Receive.Text != "")
            {
                Txt_Receive.Text = "";
            }
        }
    }
}
