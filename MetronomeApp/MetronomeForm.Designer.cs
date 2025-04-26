namespace MetronomeApp
{
    partial class Metronome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metronome));
            this.bpmTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.timeSignatureDividend = new System.Windows.Forms.TextBox();
            this.timeSignatureDividerLabel = new System.Windows.Forms.Label();
            this.timeSignatureDivisor = new System.Windows.Forms.TextBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tapButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.sampleComboBox = new System.Windows.Forms.ComboBox();
            this.sampleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bpmTextBox
            // 
            this.bpmTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bpmTextBox.Location = new System.Drawing.Point(474, 124);
            this.bpmTextBox.Name = "bpmTextBox";
            this.bpmTextBox.Size = new System.Drawing.Size(89, 20);
            this.bpmTextBox.TabIndex = 0;
            this.bpmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.CausesValidation = false;
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(430, 193);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.Location = new System.Drawing.Point(537, 193);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // bpmLabel
            // 
            this.bpmLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bpmLabel.AutoSize = true;
            this.bpmLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmLabel.ForeColor = System.Drawing.Color.White;
            this.bpmLabel.Location = new System.Drawing.Point(488, 89);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(63, 32);
            this.bpmLabel.TabIndex = 3;
            this.bpmLabel.Text = "BPM";
            // 
            // timeSignatureDividend
            // 
            this.timeSignatureDividend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeSignatureDividend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeSignatureDividend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeSignatureDividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSignatureDividend.ForeColor = System.Drawing.Color.White;
            this.timeSignatureDividend.Location = new System.Drawing.Point(497, 50);
            this.timeSignatureDividend.Name = "timeSignatureDividend";
            this.timeSignatureDividend.Size = new System.Drawing.Size(14, 24);
            this.timeSignatureDividend.TabIndex = 4;
            this.timeSignatureDividend.Text = "4";
            this.timeSignatureDividend.TextChanged += new System.EventHandler(this.timeSignatureDividend_TextChanged);
            // 
            // timeSignatureDividerLabel
            // 
            this.timeSignatureDividerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeSignatureDividerLabel.AutoSize = true;
            this.timeSignatureDividerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSignatureDividerLabel.ForeColor = System.Drawing.Color.White;
            this.timeSignatureDividerLabel.Location = new System.Drawing.Point(511, 48);
            this.timeSignatureDividerLabel.Name = "timeSignatureDividerLabel";
            this.timeSignatureDividerLabel.Size = new System.Drawing.Size(20, 29);
            this.timeSignatureDividerLabel.TabIndex = 5;
            this.timeSignatureDividerLabel.Text = "/";
            // 
            // timeSignatureDivisor
            // 
            this.timeSignatureDivisor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeSignatureDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeSignatureDivisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeSignatureDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSignatureDivisor.ForeColor = System.Drawing.Color.White;
            this.timeSignatureDivisor.Location = new System.Drawing.Point(529, 50);
            this.timeSignatureDivisor.Name = "timeSignatureDivisor";
            this.timeSignatureDivisor.Size = new System.Drawing.Size(14, 24);
            this.timeSignatureDivisor.TabIndex = 6;
            this.timeSignatureDivisor.Text = "4";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(149, 251);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(766, 381);
            this.webView21.TabIndex = 7;
            this.webView21.ZoomFactor = 1D;
            // 
            // tapButton
            // 
            this.tapButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tapButton.ForeColor = System.Drawing.Color.Black;
            this.tapButton.Location = new System.Drawing.Point(582, 122);
            this.tapButton.Name = "tapButton";
            this.tapButton.Size = new System.Drawing.Size(75, 23);
            this.tapButton.TabIndex = 8;
            this.tapButton.Text = "Tap BPM";
            this.tapButton.UseVisualStyleBackColor = true;
            this.tapButton.Click += new System.EventHandler(this.tapButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.Location = new System.Drawing.Point(474, 150);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(89, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // volumeLabel
            // 
            this.volumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.Location = new System.Drawing.Point(414, 159);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(63, 20);
            this.volumeLabel.TabIndex = 10;
            this.volumeLabel.Text = "Volume";
            // 
            // sampleComboBox
            // 
            this.sampleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sampleComboBox.FormattingEnabled = true;
            this.sampleComboBox.Items.AddRange(new object[] {
            "Basic",
            "Castanet",
            "Keyboard",
            "Knock",
            "Quartz",
            "Teeth",
            "Tongue"});
            this.sampleComboBox.Location = new System.Drawing.Point(194, 161);
            this.sampleComboBox.Name = "sampleComboBox";
            this.sampleComboBox.Size = new System.Drawing.Size(121, 21);
            this.sampleComboBox.TabIndex = 11;
            this.sampleComboBox.SelectedIndexChanged += new System.EventHandler(this.sampleComboBox_SelectedIndexChanged);
            // 
            // sampleLabel
            // 
            this.sampleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleLabel.Location = new System.Drawing.Point(222, 138);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(63, 20);
            this.sampleLabel.TabIndex = 12;
            this.sampleLabel.Text = "Sample";
            // 
            // Metronome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1082, 666);
            this.Controls.Add(this.sampleLabel);
            this.Controls.Add(this.sampleComboBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tapButton);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.timeSignatureDivisor);
            this.Controls.Add(this.timeSignatureDividerLabel);
            this.Controls.Add(this.timeSignatureDividend);
            this.Controls.Add(this.bpmLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bpmTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Metronome";
            this.Text = "Metronome App";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bpmTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label bpmLabel;
        private System.Windows.Forms.TextBox timeSignatureDividend;
        private System.Windows.Forms.Label timeSignatureDividerLabel;
        private System.Windows.Forms.TextBox timeSignatureDivisor;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button tapButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.ComboBox sampleComboBox;
        private System.Windows.Forms.Label sampleLabel;
    }
}

