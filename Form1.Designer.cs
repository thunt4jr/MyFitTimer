
namespace MyFitTimer
{
    partial class MyFitTimer
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonLap = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelTimer = new System.Windows.Forms.Label();
            this.PanelElapsed = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(89, 233);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 42);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonLap
            // 
            this.ButtonLap.Location = new System.Drawing.Point(170, 233);
            this.ButtonLap.Name = "ButtonLap";
            this.ButtonLap.Size = new System.Drawing.Size(75, 42);
            this.ButtonLap.TabIndex = 2;
            this.ButtonLap.Text = "Lap";
            this.ButtonLap.UseVisualStyleBackColor = true;
            this.ButtonLap.Visible = false;
            this.ButtonLap.Click += new System.EventHandler(this.ButtonLap_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimer.Location = new System.Drawing.Point(8, 10);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(324, 64);
            this.LabelTimer.TabIndex = 0;
            this.LabelTimer.Text = "00:00:00:00";
            this.LabelTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelElapsed
            // 
            this.PanelElapsed.Location = new System.Drawing.Point(90, 77);
            this.PanelElapsed.Name = "PanelElapsed";
            this.PanelElapsed.Size = new System.Drawing.Size(155, 150);
            this.PanelElapsed.TabIndex = 3;
            // 
            // MyFitTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.PanelElapsed);
            this.Controls.Add(this.ButtonLap);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelTimer);
            this.Name = "MyFitTimer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonLap;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.FlowLayoutPanel PanelElapsed;
    }
}

