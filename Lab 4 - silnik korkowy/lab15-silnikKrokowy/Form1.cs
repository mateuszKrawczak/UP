using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;

namespace lab15_silnikKrokowy
{
    public partial class Form1 : Form
    {

        FTD2XX_NET.FTDI.FT_STATUS ftstatus;
        FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[] devicelist = new FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[1];
        FTDI device = new FTDI();

        byte[] LeftP = { 0x08, 0x02, 0x04, 0x01 };  // jednofazowe krokowe
        byte[] RightP = { 0x01, 0x04, 0x02, 0x08 };

        byte[] LeftD = { 0x09, 0x0A, 0x06, 0x05 }; //dwufazowe krokowe
        byte[] RightD = { 0x05, 0x06, 0x0A, 0x09 };

        byte[] LeftU = { 0x09, 0x08, 0x0A, 0x02, 0x06, 0x04, 0x05, 0x01 };  // polkrokowe
        byte[] RightU = { 0x01, 0x05, 0x04, 0x06, 0x02, 0x0A, 0x08, 0x09 };

        byte[] stop = { 0x00 };

        int degree = 360; 
        int speed = 50;   

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            textBox.Text += "Obrot w lewo...\r\n";
            try
            {
                numericUpDownCounter.Enabled = false;
                rotate(LeftP, 4);
                numericUpDownCounter.Enabled = true;
                textBox.Text += "Obrot w lewo dziala\r\n";
            }
            catch(Exception ex)
            {
                textBox.Text += "Nie Dziala\r\n";
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            textBox.Text += "Obrot w prawo...\r\n";
            try
            {
                numericUpDownCounter.Enabled = false;
                rotate(RightP, 4);
                numericUpDownCounter.Enabled = true;
                textBox.Text += "Obrot w prawo dziala\r\n";
            }
            catch (Exception ex)
            {
                textBox.Text += "Nie Dziala\r\n";
            }
        }

        private void buttonRight2_Click(object sender, EventArgs e)
        {
            textBox.Text += "Obrot w prawo dwufazowy...\r\n";
            try
            {
                numericUpDownCounter.Enabled = false;
                rotate(RightD, 4);
                numericUpDownCounter.Enabled = true;
                textBox.Text += "Obrot w prawo dwufazowy dziala\r\n";
            }
            catch (Exception ex)
            {
                textBox.Text += "Nie Dziala\r\n";
            }
        }

        private void buttonLeft2_Click(object sender, EventArgs e)
        {
            textBox.Text += "Obrot w lewo dwufazowy...\r\n";
            try
            {
                numericUpDownCounter.Enabled = false;
                rotate(LeftD, 4);
                numericUpDownCounter.Enabled = true;
                textBox.Text += "Obrot w lewo dwufazowy dziala\r\n";
            }
            catch (Exception ex)
            {
                textBox.Text += "Nie Dziala\r\n";
            }
        }

        private void buttonRightHalf_Click(object sender, EventArgs e)
        {
            textBox.Text += "Obrot w prawo polkrokowy...\r\n";
            try
            {
                numericUpDownCounter.Enabled = false;
                rotate(RightU, 8);
                numericUpDownCounter.Enabled = true;
                textBox.Text += "Obrot w prawo polkrokowy dziala\r\n";
            }
            catch (Exception ex)
            {
                textBox.Text += "Nie Dziala\r\n";
            }
        }

        private void buttonLeftHalf_Click(object sender, EventArgs e)
        {
            textBox.Text += "Obrot w lewo polkrokowy...\r\n";
            try
            {
                numericUpDownCounter.Enabled = false;
                rotate(LeftU, 8);
                numericUpDownCounter.Enabled = true;
                textBox.Text += "Obrot w lewo polkrokowy dziala\r\n";
            }
            catch (Exception ex)
            {
                textBox.Text += "Nie Dziala\r\n";
            }
        }

        public void rotate(byte[] buff, int steps)
        {
            int loops = (degree * 10) / 74;

            if (steps == 8)
            {
                loops *= 2;
            }

            Int32 bytesToWrite = 1;
            UInt32 bytesWritten = 0;

            byte[][] controlByte = new byte[steps][];

            for (int i = 0; i < steps; i++)
                controlByte[i] = new byte[] { buff[i] };

            for (int k = 0, i = steps - 1; k < loops; k++)
            {

                ftstatus = device.Write(controlByte[i], bytesToWrite, ref bytesWritten); //przesłanie odpowiedniej kombinacji bitowej do sterownika
                System.Threading.Thread.Sleep(1000 / speed);

                if (i == 0)
                    i = steps - 1;
                else
                    i--;
            }

            // wysłanie 0x00 w celu zaprzestanie wysylania stanów wysokich do silnika krokowego
            ftstatus = device.Write(stop, 1, ref bytesWritten);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ftstatus = device.GetDeviceList(devicelist);
            try
            {
                ftstatus = device.OpenByDescription(devicelist[0].Description);
                ftstatus = device.SetBitMode(0xff, 1); //pozwala na przesylanie danych do ukladu
                textBox.Text += "Status Polaczenia: " + ftstatus.ToString() + "\r\n";
            }

            catch (Exception ex)
            {
                textBox.Text += "Status Polaczenia: FT_FAIL \r\n";
            }
        }

        private void numericUpDownCounter_ValueChanged(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(numericUpDownCounter.Value);
        }

        private void numericUpDownDegree_ValueChanged(object sender, EventArgs e)
        {
            degree = Convert.ToInt32(numericUpDownDegree.Value);
        }


    }
}
