using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data;

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
            string path = @"C:\Users\thunt\source\repos\MyFitTimer\database.txt";
            if (ButtonLap.Text == "Lap")
            {
                Elap ls = new Elap();
                ls.LabelElapsed.Text = LabelTimer.Text;
                PanelElapsed.Controls.Add(ls);

                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Elapsed - {0}", LabelTimer.Text);
                }



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