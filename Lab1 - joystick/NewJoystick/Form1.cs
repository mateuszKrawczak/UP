using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewJoystick
{
    public partial class Form1 : Form
    {

        SharpDX.DirectInput.DirectInput directInput = new SharpDX.DirectInput.DirectInput();
        List<DeviceInstance> deviceList = new List<DeviceInstance>();  // tworzymy liste znalezionych urzadzen
        Mouse mouse;
        public Form1()
        {
            InitializeComponent();

            var devices = directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly);  // 'zlap' wszystkie urzadzenia typu joystick
            var devices2 = directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AttachedOnly);  // 'zlap' wszystkie urzadzenia typu gamepad

            foreach (DeviceInstance instance in devices)
            { // dodaj kazdy joystick do listy znalezionych urzadzen
                deviceList.Add(instance);
                listBox1.Items.Add(instance.InstanceName);
            }

            foreach (DeviceInstance instance in devices2)
            { // dodaj kazdy gamepad do listy znalezionych urzadzen
                deviceList.Add(instance);
                listBox1.Items.Add(instance.InstanceName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedDevice = listBox1.SelectedIndex;  // zaznaczone urzadzenie staje sie naszym kontrolerem
            SharpDX.DirectInput.Joystick joystick = new SharpDX.DirectInput.Joystick(directInput, deviceList.ElementAt(selectedDevice).InstanceGuid);
            joystick.Acquire();

            mouse = new Mouse(joystick);  //dzieki temu wlaczamy mozliwosc emulacji myszy
            new Thread(new ThreadStart(mouse.WlaczEmulacje)).Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // X
            positionX.Text = mouse.positionX.ToString();
            // Y
            positionY.Text = mouse.positionY.ToString();
            // fire
            if (mouse.joystick.GetCurrentState().Buttons[0]) { checkBox3.Checked = true; } else { checkBox3.Checked = false; }
            // button 2
            if (mouse.joystick.GetCurrentState().Buttons[1]) { checkBox2.Checked = true; } else { checkBox2.Checked = false; }
            // button 3
            if (mouse.joystick.GetCurrentState().Buttons[2]) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
            // button 4
            if (mouse.joystick.GetCurrentState().Buttons[3]) { checkBox4.Checked = true; } else { checkBox4.Checked = false; }
            // button 5
            if (mouse.joystick.GetCurrentState().Buttons[4]) {checkBox5.Checked = true;} else {checkBox5.Checked = false;}
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

    }
}
