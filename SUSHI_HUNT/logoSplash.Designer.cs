namespace SUSHI_HUNT
{
    partial class frm_logoSplash
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
            this.tim_logoTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tim_logoTimer
            // 
            this.tim_logoTimer.Enabled = true;
            this.tim_logoTimer.Interval = 18000;
            this.tim_logoTimer.Tick += new System.EventHandler(this.tim_logoTimer_Tick);
            // 
            // frm_logoSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_logoSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUSHI HUNT - Further Education College";
            this.Load += new System.EventHandler(this.frm_logoSplash_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_logoSplash_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tim_logoTimer;
    }
}