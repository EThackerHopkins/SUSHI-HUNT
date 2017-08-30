namespace SUSHI_HUNT
{
    partial class frm_highScore
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
            this.lbl_HIGH_SCORES = new System.Windows.Forms.Label();
            this.btn_returnMenu = new System.Windows.Forms.Button();
            this.list_highScores = new System.Windows.Forms.ListBox();
            this.musicTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_HIGH_SCORES
            // 
            this.lbl_HIGH_SCORES.AutoSize = true;
            this.lbl_HIGH_SCORES.Font = new System.Drawing.Font("Commodore PET", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HIGH_SCORES.Location = new System.Drawing.Point(13, 13);
            this.lbl_HIGH_SCORES.Name = "lbl_HIGH_SCORES";
            this.lbl_HIGH_SCORES.Size = new System.Drawing.Size(23, 12);
            this.lbl_HIGH_SCORES.TabIndex = 0;
            this.lbl_HIGH_SCORES.Text = "[]";
            // 
            // btn_returnMenu
            // 
            this.btn_returnMenu.BackColor = System.Drawing.Color.White;
            this.btn_returnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_returnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_returnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_returnMenu.FlatAppearance.BorderSize = 2;
            this.btn_returnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_returnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_returnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returnMenu.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnMenu.Location = new System.Drawing.Point(173, 301);
            this.btn_returnMenu.Name = "btn_returnMenu";
            this.btn_returnMenu.Size = new System.Drawing.Size(130, 87);
            this.btn_returnMenu.TabIndex = 6;
            this.btn_returnMenu.Text = "Return to main menu";
            this.btn_returnMenu.UseVisualStyleBackColor = false;
            this.btn_returnMenu.Click += new System.EventHandler(this.btn_returnMenu_Click);
            // 
            // list_highScores
            // 
            this.list_highScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_highScores.Enabled = false;
            this.list_highScores.Font = new System.Drawing.Font("Commodore PET", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_highScores.FormattingEnabled = true;
            this.list_highScores.ItemHeight = 12;
            this.list_highScores.Location = new System.Drawing.Point(15, 40);
            this.list_highScores.Name = "list_highScores";
            this.list_highScores.Size = new System.Drawing.Size(471, 252);
            this.list_highScores.TabIndex = 7;
            // 
            // musicTimer
            // 
            this.musicTimer.Interval = 8512;
            this.musicTimer.Tick += new System.EventHandler(this.musicTimer_Tick);
            // 
            // frm_highScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.list_highScores);
            this.Controls.Add(this.btn_returnMenu);
            this.Controls.Add(this.lbl_HIGH_SCORES);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_highScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUSHI HUNT - High Score";
            this.Load += new System.EventHandler(this.frm_highScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HIGH_SCORES;
        private System.Windows.Forms.Button btn_returnMenu;
        private System.Windows.Forms.ListBox list_highScores;
        private System.Windows.Forms.Timer musicTimer;
    }
}