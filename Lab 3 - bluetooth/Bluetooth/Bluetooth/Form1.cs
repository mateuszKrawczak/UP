using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Threading;

using Brecham.Obex;
using System.IO;

namespace Bluetooth
{
    public partial class Form1 : Form
    {

        private BluetoothDeviceInfo[] devices;
        private bool isPaired = false;
        private BluetoothDeviceInfo deviceToPair = null;
        int selectedID;

        public Form1()
        {
            InitializeComponent();
            buttonUnpair.Enabled = false;
            buttonSendFile.Enabled = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            Console.WriteLine("szukanie");

            listBoxDevices.Items.Clear();

            var bluetoothClient = new BluetoothClient();

            devices = bluetoothClient.DiscoverDevices();

            foreach(BluetoothDeviceInfo device in devices)
            {
                listBoxDevices.Items.Add(device.DeviceName);
                Console.WriteLine(device.DeviceName + " " + device.DeviceAddress + " " + device.ClassOfDevice.Device);
            }

        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            foreach(BluetoothDeviceInfo device in devices)
            {
                if (device.DeviceName == (string)listBoxDevices.SelectedItem)
                {
                    deviceToPair = device;
                    selectedID = listBoxDevices.SelectedIndex;
                }

            } 

            if(deviceToPair == null)
            {
                Console.WriteLine("Nie wybrano nic do sprowania");
            }
            else
            {
                Console.WriteLine("Parowanie z " + deviceToPair.DeviceName);
                deviceToPair.Update();
                deviceToPair.Refresh();
                deviceToPair.SetServiceState(BluetoothService.ObexObjectPush, true);
                string pin = "000000";
                isPaired = BluetoothSecurity.PairRequest(deviceToPair.DeviceAddress, pin);
                if (isPaired)
                {
                    Console.WriteLine("Sparowano");
                    buttonSendFile.Enabled = true;
                    
                    listBoxConnected.Items.Add(deviceToPair.DeviceName);
                    buttonPair.Enabled = false;
                    buttonUnpair.Enabled = true;
                }
                else
                {
                    Console.WriteLine("Nie Sparowano");
                }
            }
        }

        private void buttonUnpair_Click(object sender, EventArgs e)
        {
            if (isPaired)
            {
                buttonUnpair.Enabled = false;
                BluetoothSecurity.RemoveDevice(deviceToPair.DeviceAddress);
                Console.WriteLine("Odparowano");
            }
        }

        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Task.Run(async () =>
            {
                await sendFileMethod(sender, this);
            }
            );
        }

        private async Task sendFileMethod(object sender, Form1 form)
        {
            OpenFileDialog dialog = (OpenFileDialog)sender;
            BluetoothAddress address = devices[selectedID].DeviceAddress;
            var path = String.Format("obex://{0}/{1}", address.ToString(), dialog.FileName);
            ObexWebRequest request = new ObexWebRequest(new Uri(path));
            Stream stream = request.GetRequestStream();

            request.ReadFile(dialog.FileName);
            var response = (ObexWebResponse)request.GetResponse();
            response.Close();

        }

    }
}
