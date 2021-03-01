using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text; 

namespace MyFitTimer
{

    public partial class MyFitTimer : Form
    {
        public MyFitTimer()
        {
            InitializeComponent();
        }

        Stopwatch tm = new Stopwatch();

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonLap.Visible = true;
            if (ButtonStart.Text == "Start" || ButtonStart.Text == "Restart")
            {
                tm.Start();
                ButtonStart.Text = "Stop";
                ButtonLap.Text = "Lap";
                Timer.Start();
            }
            else
            {
                tm.Stop();
                ButtonStart.Text = "Restart";
                ButtonLap.Text = "Reset";
                Timer.Stop();

            }

        }

        private void ButtonLap_Click(object sender, EventArgs e)
        {
            if (ButtonLap.Text == "Lap")
            {
                string path = @"data.txt";

                Elap ls = new Elap();
                ls.LabelElapsed.Text = LabelTimer.Text;
                PanelElapsed.Controls.Add(ls);
                string createText = "Elapsed: " + LabelTimer.Text;
                File.WriteAllText(path, createText);

                string AppendText = "Elapsed: " + LabelTimer.Text;
                File.AppendAllText(path, AppendText);
            }
            else
            {
                ButtonStart.Text = "Start";
                ButtonLap.Visible = false;
                LabelTimer.Text = "00:00:00:00";
                PanelElapsed.Controls.Clear();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            LabelTimer.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", tm.Elapsed.Hours, tm.Elapsed.Minutes, tm.Elapsed.Seconds, tm.Elapsed.Milliseconds / 10);
        }

    }
}