using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics.Eventing.Reader;

namespace MetronomeApp
{
    public partial class Metronome : Form
    {
        static System.Windows.Forms.Timer metronomeTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer flashTimer = new System.Windows.Forms.Timer();
        static readonly MediaPlayer metronomeUpBeatSample = new MediaPlayer();
        static readonly MediaPlayer metronomeDownBeatSample = new MediaPlayer();
        private System.Drawing.Color _originalLabelColor = System.Drawing.Color.White;
        private double bpm;
        private int divisor;
        private int dividend;
        private static int beatCount;
        private static long currentTimestamp;

        public Metronome()
        {
            InitializeComponent();

            // Setup for the BPM label flash timer
            flashTimer.Interval = 100;
            flashTimer.Tick += FlashTimer_Tick;

            bpmTextBox.Text = "120"; // Default BPM value

            // Setup for the YouTube Music web browser
            const string defaultUrl = "https://music.youtube.com/";

            // Load the default URL
            webView21.Source = new Uri(defaultUrl);
            webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;

            // Load samples into thier respective media players
            string downBeatSamplePath = Application.StartupPath + "\\MetronomeSamples\\MetronomeUp.wav";
            metronomeDownBeatSample.Open(new Uri(downBeatSamplePath));

            string upBeatSamplePath = Application.StartupPath + "\\MetronomeSamples\\Metronome.wav";
            metronomeUpBeatSample.Open(new Uri(upBeatSamplePath));

            sampleComboBox.SelectedIndex = 0;

            this.ActiveControl = bpmLabel; // Set focus to the label to clear other focused elements
        }

        private void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
                webView21.CoreWebView2.Profile.ClearBrowsingDataAsync();
            else
                Console.WriteLine($"WebView2 initialization failed: {e.InitializationException}");
        }

        private static void metronomeTick(Object Object, EventArgs eventArgs)
        {
            // Initiate the flash on each tick
            if (Application.OpenForms.OfType<Metronome>().FirstOrDefault() is Metronome form)
            {
                form.BeginInvoke((MethodInvoker)delegate
                {
                    form._originalLabelColor = form.bpmLabel.ForeColor;
                    form.bpmLabel.ForeColor = System.Drawing.Color.Orange;
                    flashTimer.Start();
                });

                if (beatCount % form.dividend == 0)
                {
                    metronomeDownBeatSample.Play();
                    metronomeDownBeatSample.Position = TimeSpan.Zero;
                }
                else
                {
                    metronomeUpBeatSample.Play();
                    metronomeUpBeatSample.Position = TimeSpan.Zero;
                }

                beatCount++;
            }
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            flashTimer.Stop();
            bpmLabel.ForeColor = _originalLabelColor;
        }

        private void playMetronome(int milliseconds)
        {
            beatCount = 0; // Reset the beat count every time the metronome starts

            metronomeTimer.Tick -= new EventHandler(metronomeTick);
            metronomeTimer.Tick += new EventHandler(metronomeTick);

            metronomeTimer.Interval = milliseconds;
            metronomeTimer.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.BackColor = System.Drawing.Color.Orange;

            // Attempt to get the user-given time signature
            if (!int.TryParse(timeSignatureDividend.Text, out dividend))
                dividend = 4; // Default value

            if (!int.TryParse(timeSignatureDivisor.Text, out divisor))
                divisor = 4; // Default value

            // Attempt to get the user-given beats per minute
            if (!double.TryParse(bpmTextBox.Text, out bpm))
                bpm = 120; // Default value


            // Convert BMP to milliseconds
            double bps = (bpm / 60);
            double doubleMilliseconds = ((1 / bps) * 1000);
            int milliseconds = (int)doubleMilliseconds;


            metronomeTimer.Stop();
            playMetronome(milliseconds);
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            metronomeTimer.Stop();
            startButton.BackColor = System.Drawing.Color.LightGray;
        }


        private void tapButton_Click(object sender, EventArgs e)
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            if (currentTimestamp == 0)
            {
                currentTimestamp = timestamp;
                return;
            }

            metronomeTimer.Stop();
            startButton.BackColor = System.Drawing.Color.LightGray;
            bpm = 60000 / (timestamp - currentTimestamp);
            bpmTextBox.Text = bpm.ToString();

            currentTimestamp = timestamp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float volume = trackBar1.Value / 10f;
            metronomeDownBeatSample.Volume = volume;
            metronomeUpBeatSample.Volume = volume;
        }

        private void sampleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sampleComboBox.SelectedItem)
            {
                case "Basic":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\MetronomeUp.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\Metronome.wav"));

                    break;
                case "Castanet":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\CastanetHigh.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\CastanetLow.wav"));

                    break;
                case "Keyboard":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\KeyboardHigh.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\KeyboardLow.wav"));

                    break;
                case "Knock":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\KnockHigh.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\KnockLow.wav"));

                    break;
                case "Quartz":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\QuartzHigh.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\QuartzLow.wav"));

                    break;
                case "Teeth":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\TeethHigh.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\TeethLow.wav"));

                    break;
                case "Tongue":
                    metronomeDownBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\TongueHigh.wav"));
                    metronomeUpBeatSample.Open(new Uri(Application.StartupPath + "\\MetronomeSamples\\TongueLow.wav"));

                    break;
            }
        }

        private void timeSignatureDividend_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(timeSignatureDividend.Text, out dividend))
                dividend = 4; // Default value
        }
    }
}