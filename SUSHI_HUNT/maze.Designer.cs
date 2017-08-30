namespace SUSHI_HUNT
{
    partial class frm_Maze
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
            this.lbl_TIME = new System.Windows.Forms.Label();
            this.lbl_SUSHI = new System.Windows.Forms.Label();
            this.lbl_TIMEDISPLAY = new System.Windows.Forms.Label();
            this.lbl_SUSHI_DISPLAY = new System.Windows.Forms.Label();
            this.mazeTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_PAUSE = new System.Windows.Forms.Label();
            this.lbl_RETURN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TIME
            // 
            this.lbl_TIME.AutoSize = true;
            this.lbl_TIME.Font = new System.Drawing.Font("Commodore PET", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TIME.Location = new System.Drawing.Point(354, 29);
            this.lbl_TIME.Name = "lbl_TIME";
            this.lbl_TIME.Size = new System.Drawing.Size(42, 9);
            this.lbl_TIME.TabIndex = 0;
            this.lbl_TIME.Text = "Time:";
            // 
            // lbl_SUSHI
            // 
            this.lbl_SUSHI.AutoSize = true;
            this.lbl_SUSHI.Font = new System.Drawing.Font("Commodore PET", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SUSHI.Location = new System.Drawing.Point(354, 53);
            this.lbl_SUSHI.Name = "lbl_SUSHI";
            this.lbl_SUSHI.Size = new System.Drawing.Size(51, 9);
            this.lbl_SUSHI.TabIndex = 1;
            this.lbl_SUSHI.Text = "Sushi:";
            // 
            // lbl_TIMEDISPLAY
            // 
            this.lbl_TIMEDISPLAY.AutoSize = true;
            this.lbl_TIMEDISPLAY.Font = new System.Drawing.Font("Commodore PET", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TIMEDISPLAY.Location = new System.Drawing.Point(423, 29);
            this.lbl_TIMEDISPLAY.Name = "lbl_TIMEDISPLAY";
            this.lbl_TIMEDISPLAY.Size = new System.Drawing.Size(14, 9);
            this.lbl_TIMEDISPLAY.TabIndex = 2;
            this.lbl_TIMEDISPLAY.Text = "0";
            // 
            // lbl_SUSHI_DISPLAY
            // 
            this.lbl_SUSHI_DISPLAY.AutoSize = true;
            this.lbl_SUSHI_DISPLAY.Font = new System.Drawing.Font("Commodore PET", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SUSHI_DISPLAY.Location = new System.Drawing.Point(423, 53);
            this.lbl_SUSHI_DISPLAY.Name = "lbl_SUSHI_DISPLAY";
            this.lbl_SUSHI_DISPLAY.Size = new System.Drawing.Size(14, 9);
            this.lbl_SUSHI_DISPLAY.TabIndex = 3;
            this.lbl_SUSHI_DISPLAY.Text = "0";
            // 
            // mazeTimer
            // 
            this.mazeTimer.Enabled = true;
            this.mazeTimer.Interval = 1000;
            this.mazeTimer.Tick += new System.EventHandler(this.mazeTimer_Tick);
            // 
            // lbl_PAUSE
            // 
            this.lbl_PAUSE.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_PAUSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PAUSE.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAUSE.Location = new System.Drawing.Point(356, 132);
            this.lbl_PAUSE.Name = "lbl_PAUSE";
            this.lbl_PAUSE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbl_PAUSE.Size = new System.Drawing.Size(130, 20);
            this.lbl_PAUSE.TabIndex = 8;
            this.lbl_PAUSE.Text = "PAUSE";
            this.lbl_PAUSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_PAUSE.Click += new System.EventHandler(this.lbl_PAUSE_Click);
            // 
            // lbl_RETURN
            // 
            this.lbl_RETURN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_RETURN.Font = new System.Drawing.Font("Commodore PET", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RETURN.Location = new System.Drawing.Point(356, 323);
            this.lbl_RETURN.Name = "lbl_RETURN";
            this.lbl_RETURN.Size = new System.Drawing.Size(130, 68);
            this.lbl_RETURN.TabIndex = 9;
            this.lbl_RETURN.Text = "Return to main menu";
            this.lbl_RETURN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_RETURN.Click += new System.EventHandler(this.lbl_RETURN_Click);
            // 
            // frm_Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.lbl_RETURN);
            this.Controls.Add(this.lbl_PAUSE);
            this.Controls.Add(this.lbl_SUSHI_DISPLAY);
            this.Controls.Add(this.lbl_TIMEDISPLAY);
            this.Controls.Add(this.lbl_SUSHI);
            this.Controls.Add(this.lbl_TIME);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maze";
            this.Load += new System.EventHandler(this.frm_Maze_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Maze_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Maze_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TIME;
        private System.Windows.Forms.Label lbl_SUSHI;
        private System.Windows.Forms.Label lbl_TIMEDISPLAY;
        private System.Windows.Forms.Label lbl_SUSHI_DISPLAY;
        private System.Windows.Forms.Timer mazeTimer;
        private System.Windows.Forms.Label lbl_PAUSE;
        private System.Windows.Forms.Label lbl_RETURN;
    }
}