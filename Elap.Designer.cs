
namespace MyFitTimer
{
    partial class Elap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelElapsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelElapsed
            // 
            this.LabelElapsed.AutoSize = true;
            this.LabelElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelElapsed.Location = new System.Drawing.Point(4, 3);
            this.LabelElapsed.Name = "LabelElapsed";
            this.LabelElapsed.Size = new System.Drawing.Size(126, 26);
            this.LabelElapsed.TabIndex = 0;
            this.LabelElapsed.Text = "00:00:00:00";
            // 
            // Elap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelElapsed);
            this.Name = "Elap";
            this.Size = new System.Drawing.Size(127, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelElapsed;
    }
}
