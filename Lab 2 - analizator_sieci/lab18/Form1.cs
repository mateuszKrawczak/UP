using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace lab18
{
    public partial class Form1 : Form
    {

        ModbusClient modbusClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(textBoxIP.Text, 502);
                modbusClient.UnitIdentifier = 0x01;
                modbusClient.ConnectionTimeout = 350;
                modbusClient.Connect();
                labelStatus.Text = "Connected";
                timer.Start();
            } catch(Exception ex)
            {
                labelStatus.Text = ex.ToString();
            }

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            labelStatus.Text = "Offline";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
            bool[] readCoils = modbusClient.ReadCoils(9, 10);                        //Read 10 Coils from Server, starting with address 10
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);    //Read 10 Holding Registers from Server, starting with Address 1

            for (int i = 0; i < readCoils.Length; i++)
            {
                textBox1.AppendText("Value of Coil " + (9 + i + 1) + " " + readCoils[i].ToString());
            }

            for (int i = 0; i < readHoldingRegisters.Length; i++)
            {
                textBox2.AppendText("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
                modbusClient.Disconnect();
            }

            timer.Stop();
        }

    }
}
