namespace lab15_silnikKrokowy
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
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.numericUpDownCounter = new System.Windows.Forms.NumericUpDown();
            this.buttonRight2 = new System.Windows.Forms.Button();
            this.buttonLeft2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDegree = new System.Windows.Forms.NumericUpDown();
            this.buttonRightHalf = new System.Windows.Forms.Button();
            this.buttonLeftHalf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(464, 162);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(100, 59);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "Left 1fazowy";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(464, 82);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(100, 65);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = "Prawo 1fazowy";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(464, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(373, 43);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(406, 308);
            this.textBox.TabIndex = 3;
            // 
            // numericUpDownCounter
            // 
            this.numericUpDownCounter.Location = new System.Drawing.Point(602, 249);
            this.numericUpDownCounter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCounter.Name = "numericUpDownCounter";
            this.numericUpDownCounter.Size = new System.Drawing.Size(235, 26);
            this.numericUpDownCounter.TabIndex = 4;
            this.numericUpDownCounter.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCounter.ValueChanged += new System.EventHandler(this.numericUpDownCounter_ValueChanged);
            // 
            // buttonRight2
            // 
            this.buttonRight2.Location = new System.Drawing.Point(602, 82);
            this.buttonRight2.Name = "buttonRight2";
            this.buttonRight2.Size = new System.Drawing.Size(92, 65);
            this.buttonRight2.TabIndex = 6;
            this.buttonRight2.Text = "Right 2fazowy";
            this.buttonRight2.UseVisualStyleBackColor = true;
            this.buttonRight2.Click += new System.EventHandler(this.buttonRight2_Click);
            // 
            // buttonLeft2
            // 
            this.buttonLeft2.Location = new System.Drawing.Point(602, 162);
            this.buttonLeft2.Name = "buttonLeft2";
            this.buttonLeft2.Size = new System.Drawing.Size(92, 59);
            this.buttonLeft2.TabIndex = 5;
            this.buttonLeft2.Text = "Left 2fazowy";
            this.buttonLeft2.UseVisualStyleBackColor = true;
            this.buttonLeft2.Click += new System.EventHandler(this.buttonLeft2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SPEED :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "DEGREES :";
            // 
            // numericUpDownDegree
            // 
            this.numericUpDownDegree.Increment = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownDegree.Location = new System.Drawing.Point(602, 298);
            this.numericUpDownDegree.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownDegree.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownDegree.Name = "numericUpDownDegree";
            this.numericUpDownDegree.Size = new System.Drawing.Size(235, 26);
            this.numericUpDownDegree.TabIndex = 9;
            this.numericUpDownDegree.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownDegree.ValueChanged += new System.EventHandler(this.numericUpDownDegree_ValueChanged);
            // 
            // buttonRightHalf
            // 
            this.buttonRightHalf.Location = new System.Drawing.Point(732, 82);
            this.buttonRightHalf.Name = "buttonRightHalf";
            this.buttonRightHalf.Size = new System.Drawing.Size(105, 65);
            this.buttonRightHalf.TabIndex = 10;
            this.buttonRightHalf.Text = "Prawo Polkrokwy";
            this.buttonRightHalf.UseVisualStyleBackColor = true;
            this.buttonRightHalf.Click += new System.EventHandler(this.buttonRightHalf_Click);
            // 
            // buttonLeftHalf
            // 
            this.buttonLeftHalf.Location = new System.Drawing.Point(732, 162);
            this.buttonLeftHalf.Name = "buttonLeftHalf";
            this.buttonLeftHalf.Size = new System.Drawing.Size(105, 59);
            this.buttonLeftHalf.TabIndex = 11;
            this.buttonLeftHalf.Text = "Lewo Polkrokowy";
            this.buttonLeftHalf.UseVisualStyleBackColor = true;
            this.buttonLeftHalf.Click += new System.EventHandler(this.buttonLeftHalf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 350);
            this.Controls.Add(this.buttonLeftHalf);
            this.Controls.Add(this.buttonRightHalf);
            this.Controls.Add(this.numericUpDownDegree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRight2);
            this.Controls.Add(this.buttonLeft2);
            this.Controls.Add(this.numericUpDownCounter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.NumericUpDown numericUpDownCounter;
        private System.Windows.Forms.Button buttonRight2;
        private System.Windows.Forms.Button buttonLeft2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDegree;
        private System.Windows.Forms.Button buttonRightHalf;
        private System.Windows.Forms.Button buttonLeftHalf;
    }
}

