namespace KartaDzwiekowa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlayNAudio = new System.Windows.Forms.Button();
            this.buttonStopNAudio = new System.Windows.Forms.Button();
            this.buttonFileMp3 = new System.Windows.Forms.Button();
            this.buttonPlayMp3 = new System.Windows.Forms.Button();
            this.buttonStopMp3 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(893, 149);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(186, 39);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Wybierz plik WAVE";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(893, 217);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(186, 39);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play SimpleSound";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInfo.Location = new System.Drawing.Point(1114, 148);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(585, 575);
            this.textBoxInfo.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilePath.Location = new System.Drawing.Point(28, 19);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(71, 29);
            this.labelFilePath.TabIndex = 3;
            this.labelFilePath.Text = "Plik : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1245, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informacje o pliku :";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(893, 283);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(186, 39);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop SimpleSound";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlayNAudio
            // 
            this.buttonPlayNAudio.Location = new System.Drawing.Point(893, 350);
            this.buttonPlayNAudio.Name = "buttonPlayNAudio";
            this.buttonPlayNAudio.Size = new System.Drawing.Size(186, 39);
            this.buttonPlayNAudio.TabIndex = 6;
            this.buttonPlayNAudio.Text = "Play WaveOut";
            this.buttonPlayNAudio.UseVisualStyleBackColor = true;
            this.buttonPlayNAudio.Click += new System.EventHandler(this.buttonPlayNAudio_Click);
            // 
            // buttonStopNAudio
            // 
            this.buttonStopNAudio.Location = new System.Drawing.Point(893, 431);
            this.buttonStopNAudio.Name = "buttonStopNAudio";
            this.buttonStopNAudio.Size = new System.Drawing.Size(186, 39);
            this.buttonStopNAudio.TabIndex = 7;
            this.buttonStopNAudio.Text = "Stop WaveOut";
            this.buttonStopNAudio.UseVisualStyleBackColor = true;
            this.buttonStopNAudio.Click += new System.EventHandler(this.buttonStopNAudio_Click);
            // 
            // buttonFileMp3
            // 
            this.buttonFileMp3.Location = new System.Drawing.Point(893, 527);
            this.buttonFileMp3.Name = "buttonFileMp3";
            this.buttonFileMp3.Size = new System.Drawing.Size(186, 39);
            this.buttonFileMp3.TabIndex = 9;
            this.buttonFileMp3.Text = "Wybierz plik Mp3";
            this.buttonFileMp3.UseVisualStyleBackColor = true;
            this.buttonFileMp3.Click += new System.EventHandler(this.buttonFileMp3_Click);
            // 
            // buttonPlayMp3
            // 
            this.buttonPlayMp3.Location = new System.Drawing.Point(893, 601);
            this.buttonPlayMp3.Name = "buttonPlayMp3";
            this.buttonPlayMp3.Size = new System.Drawing.Size(186, 39);
            this.buttonPlayMp3.TabIndex = 10;
            this.buttonPlayMp3.Text = "Play Mp3";
            this.buttonPlayMp3.UseVisualStyleBackColor = true;
            this.buttonPlayMp3.Click += new System.EventHandler(this.buttonPlayMp3_Click);
            // 
            // buttonStopMp3
            // 
            this.buttonStopMp3.Location = new System.Drawing.Point(893, 684);
            this.buttonStopMp3.Name = "buttonStopMp3";
            this.buttonStopMp3.Size = new System.Drawing.Size(186, 39);
            this.buttonStopMp3.TabIndex = 11;
            this.buttonStopMp3.Text = "Stop Mp3";
            this.buttonStopMp3.UseVisualStyleBackColor = true;
            this.buttonStopMp3.Click += new System.EventHandler(this.buttonStopMp3_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(33, 129);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(500, 446);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 989);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonStopMp3);
            this.Controls.Add(this.buttonPlayMp3);
            this.Controls.Add(this.buttonFileMp3);
            this.Controls.Add(this.buttonStopNAudio);
            this.Controls.Add(this.buttonPlayNAudio);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlayNAudio;
        private System.Windows.Forms.Button buttonStopNAudio;
        private System.Windows.Forms.Button buttonFileMp3;
        private System.Windows.Forms.Button buttonPlayMp3;
        private System.Windows.Forms.Button buttonStopMp3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

