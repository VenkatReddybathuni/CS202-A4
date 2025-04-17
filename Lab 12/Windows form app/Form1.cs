using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlarmWinFormsApp
{
    public partial class Form1 : Form
    {
        private DateTime targetTime;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBoxTime.Text, out targetTime))
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("❌ Invalid time format. Please use HH:MM:SS.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Change background color
            this.BackColor = Color.FromArgb(
                rand.Next(256), rand.Next(256), rand.Next(256));

            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour == targetTime.Hour &&
                currentTime.Minute == targetTime.Minute &&
                currentTime.Second == targetTime.Second)
            {
                timer1.Stop();
                MessageBox.Show("⏰ Alarm! Time matched.");
            }
        }
    }
}
