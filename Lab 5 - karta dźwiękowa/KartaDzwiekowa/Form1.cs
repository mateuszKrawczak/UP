using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartaDzwiekowa
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private bool played;

        SoundPlayer simpleSound;

        NAudio.Wave.IWavePlayer waveOutDevice = new NAudio.Wave.WaveOut();
        NAudio.Wave.AudioFileReader audioFileReader;

        public Form1()
        {
            InitializeComponent();
                    
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Audio files (.wav)|*.wav";   
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;           
                SetInfo();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

            if (filePath == String.Empty)
            {
                MessageBox.Show("Wybierz plik!");
            }
            else
            {
                simpleSound = new SoundPlayer(@filePath);
                if (!played)        
                {     
                    played = !played;
                    simpleSound.Play();         
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (played)
            {
                simpleSound = new SoundPlayer(@filePath);
                played = !played;
                simpleSound.Stop();
            }

        }

        private void SetInfo()
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                BinaryReader reader = new BinaryReader(fileStream);

                // odczytanie nagłówka pliku Wave
                byte[] wave = reader.ReadBytes(36);

                fileStream.Position = 0;

                int chunkID = reader.ReadInt32();
                int chunkSize = reader.ReadInt32();

                var fileFormat = Encoding.Default.GetString(wave);
                string format = fileFormat.Substring(8, 4);
                string subchunk1ID = fileFormat.Substring(12, 4);
                string chunkIDString = fileFormat.Substring(0, 4);
                int formatInt = reader.ReadInt32();
                int subchunkInt = reader.ReadInt32();

                int subchunk1Size = reader.ReadInt32();
                int audioFormat = reader.ReadInt16();
                int numChannels = reader.ReadInt16();
                int sampleRate = reader.ReadInt32();
                int byteRate = reader.ReadInt32();
                int blockAlign = reader.ReadInt16();
                int bitsPerSample = reader.ReadInt16();

                reader.Close();

                textBoxInfo.Text = "";

                textBoxInfo.Text += "Chunk ID:" + chunkIDString;
                textBoxInfo.Text += "\r\nChunk size:" + chunkSize;
                textBoxInfo.Text += "\r\nFormat: " + format;
                textBoxInfo.Text += "\r\nSubchunk1 ID: " + subchunk1ID;
                textBoxInfo.Text += "\r\nSubchunk1 Size: " + subchunk1Size;
                textBoxInfo.Text += "\r\nAudio Format: " + audioFormat;
                textBoxInfo.Text += "\r\nNum Channels: " + numChannels;
                textBoxInfo.Text += "\r\nSample Rate: " + sampleRate;
                textBoxInfo.Text += "\r\nByte Rate: " + byteRate;
                textBoxInfo.Text += "\r\nBlock Align: " + blockAlign;
                textBoxInfo.Text += "\r\nBitsPerSample: " + bitsPerSample;

                labelFilePath.Text = "Plik: " + filePath;

            }
        }

        private void buttonPlayNAudio_Click(object sender, EventArgs e)
        {
            try
            {
                CloseWaveOut();
                waveOutDevice = new NAudio.Wave.WaveOut();
                audioFileReader = new NAudio.Wave.AudioFileReader(filePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystąpił błąd: {0}", ex.Message));
            }
        }

        private void buttonStopNAudio_Click(object sender, EventArgs e)
        {
            try
            {
                CloseWaveOut();
                waveOutDevice = new NAudio.Wave.WaveOut();
                audioFileReader = new NAudio.Wave.AudioFileReader(filePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystąpił błąd: {0}", ex.Message));
            }
        }

        private void CloseWaveOut()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }

        private void buttonFileMp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileMp3 = new OpenFileDialog();
            fileMp3.Filter = "Audio files (.mp3)|*.mp3";
            fileMp3.ShowDialog();
            axWindowsMediaPlayer1.URL = fileMp3.FileName;
            labelFilePath.Text = "Plik: " + fileMp3.FileName;
        }

        private void buttonPlayMp3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonStopMp3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
