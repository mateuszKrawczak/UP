using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Reflection;
using System.Threading;


namespace GPS
{
    public partial class Form1 : Form
    {

        static SerialPort serialPort;
        string outputData;
        string latitude;
        string longitude;
        bool connected = false;
        char[] receivedData = new char[512];

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            InitializeComponent();
            serialPort = new SerialPort();
            textBoxMessage.Text = "";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                serialPort.PortName = "COM8";
                serialPort.BaudRate = 9600;
                serialPort.Open();
                connected = true;
                labelConnectionStatus.Text = "Status : Połączono";
                labelConnectionStatus.ForeColor = Color.Green;
                ReadData();
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ClearData();
            if (connected)
            {
                ReadData();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");

                if (latitude != string.Empty)
                {
                    queryAddress.Append(latitude + "%2C");
                }

                if (longitude != string.Empty)
                {
                    queryAddress.Append(longitude);
                }

                System.Diagnostics.Process.Start(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void ReadData()
        {

            outputData = serialPort.ReadExisting();

            var splitedData = outputData.Split('$');

            foreach (var line in splitedData)
            {
                try
                {
                    if (line.Contains("GPGGA"))
                    {


                        string fLatitude = "";
                        string fLongitude = "";

                        var info = line.Split(',');

                        double longdec = double.Parse(info[4], CultureInfo.InvariantCulture) / 100.0;
                        double latdec = double.Parse(info[2], CultureInfo.InvariantCulture) / 100.0;

                        if (info[3] == "S")
                        {
                            fLatitude = "-";
                        }
                        if (info[5] == "W")
                        {
                            fLongitude = "-";
                        }

                        var latSplitted = Convert.ToString(latdec).Split('.');
                        var longSplitted = Convert.ToString(longdec).Split('.');

                        longdec = Convert.ToDouble("0." + longSplitted[1], CultureInfo.InvariantCulture) * 10 / 6;
                        latdec = Convert.ToDouble("0." + latSplitted[1], CultureInfo.InvariantCulture) * 10 / 6;

                        textBoxLatitude.Text = fLatitude + (Convert.ToDouble(latSplitted[0]) + latdec).ToString("F6");
                        textBoxLongitude.Text = fLongitude + (Convert.ToDouble(longSplitted[0]) + longdec).ToString("F6");

                        latitude = fLatitude + (Convert.ToDouble(latSplitted[0]) + latdec).ToString("F6");
                        longitude = fLongitude + (Convert.ToDouble(longSplitted[0]) + longdec).ToString("F6");

                        textBoxTime.Text = info[1].Substring(0, 2) + ":" + info[1].Substring(2,2) + ":" + info[1].Substring(4,2);

                        textBoxMessage.Text += "$" + line;
                        textBoxHigh.Text = info[9] + " m";
                        textBoxSatelites.Text = info[7];

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }

        private void ClearData()
        {
            textBoxLatitude.Text = "";
            textBoxLongitude.Text = "";
            textBoxMessage.Text += "";
            textBoxHigh.Text = "";
            textBoxSatelites.Text = "";
        }

    }
}
