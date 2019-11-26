namespace Bluetooth
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
            this.components = new System.ComponentModel.Container();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBoxConnected = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPair = new System.Windows.Forms.Button();
            this.buttonUnpair = new System.Windows.Forms.Button();
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(1277, 739);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(141, 48);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // listBoxConnected
            // 
            this.listBoxConnected.FormattingEnabled = true;
            this.listBoxConnected.ItemHeight = 20;
            this.listBoxConnected.Location = new System.Drawing.Point(716, 60);
            this.listBoxConnected.Name = "listBoxConnected";
            this.listBoxConnected.Size = new System.Drawing.Size(309, 564);
            this.listBoxConnected.TabIndex = 2;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 20;
            this.listBoxFiles.Location = new System.Drawing.Point(392, 60);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(264, 564);
            this.listBoxFiles.TabIndex = 3;
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 20;
            this.listBoxDevices.Location = new System.Drawing.Point(1070, 60);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(415, 564);
            this.listBoxDevices.TabIndex = 4;
            // 
            // buttonPair
            // 
            this.buttonPair.Location = new System.Drawing.Point(1070, 739);
            this.buttonPair.Name = "buttonPair";
            this.buttonPair.Size = new System.Drawing.Size(132, 48);
            this.buttonPair.TabIndex = 5;
            this.buttonPair.Text = "Pair";
            this.buttonPair.UseVisualStyleBackColor = true;
            this.buttonPair.Click += new System.EventHandler(this.buttonPair_Click);
            // 
            // buttonUnpair
            // 
            this.buttonUnpair.Location = new System.Drawing.Point(866, 739);
            this.buttonUnpair.Name = "buttonUnpair";
            this.buttonUnpair.Size = new System.Drawing.Size(129, 48);
            this.buttonUnpair.TabIndex = 6;
            this.buttonUnpair.Text = "Unpair";
            this.buttonUnpair.UseVisualStyleBackColor = true;
            this.buttonUnpair.Click += new System.EventHandler(this.buttonUnpair_Click);
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.Location = new System.Drawing.Point(669, 739);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(129, 48);
            this.buttonSendFile.TabIndex = 7;
            this.buttonSendFile.Text = "SendFile";
            this.buttonSendFile.UseVisualStyleBackColor = true;
            this.buttonSendFile.Click += new System.EventHandler(this.buttonSendFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 1033);
            this.Controls.Add(this.buttonSendFile);
            this.Controls.Add(this.buttonUnpair);
            this.Controls.Add(this.buttonPair);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.listBoxConnected);
            this.Controls.Add(this.buttonFind);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBoxConnected;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPair;
        private System.Windows.Forms.Button buttonUnpair;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

