namespace SUSHI_HUNT
{
    partial class frm_mainMenu
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
            this.btn_playGame = new System.Windows.Forms.Button();
            this.combo_Difficulty = new System.Windows.Forms.ComboBox();
            this.lbl_DIFFICULTY = new System.Windows.Forms.Label();
            this.lbl_JAP_TITLE = new System.Windows.Forms.Label();
            this.lbl_ENG_TITLE = new System.Windows.Forms.Label();
            this.btn_Instructions = new System.Windows.Forms.Button();
            this.btn_highScores = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.pnl_nameEntry = new System.Windows.Forms.Panel();
            this.btn_confirmName = new System.Windows.Forms.Button();
            this.lbl_enterName = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lbl_welcomeName = new System.Windows.Forms.Label();
            this.btn_changeName = new System.Windows.Forms.Button();
            this.musicTimer = new System.Windows.Forms.Timer(this.components);
            this.pnl_nameEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_playGame
            // 
            this.btn_playGame.BackColor = System.Drawing.Color.White;
            this.btn_playGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_playGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_playGame.FlatAppearance.BorderSize = 2;
            this.btn_playGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_playGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_playGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playGame.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playGame.ForeColor = System.Drawing.Color.Black;
            this.btn_playGame.Location = new System.Drawing.Point(24, 116);
            this.btn_playGame.Name = "btn_playGame";
            this.btn_playGame.Size = new System.Drawing.Size(130, 87);
            this.btn_playGame.TabIndex = 0;
            this.btn_playGame.Text = "Play Game!";
            this.btn_playGame.UseVisualStyleBackColor = false;
            this.btn_playGame.Click += new System.EventHandler(this.btn_playGame_Click);
            // 
            // combo_Difficulty
            // 
            this.combo_Difficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.combo_Difficulty.DropDownHeight = 110;
            this.combo_Difficulty.DropDownWidth = 120;
            this.combo_Difficulty.Font = new System.Drawing.Font("Commodore PET", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Difficulty.ForeColor = System.Drawing.Color.Black;
            this.combo_Difficulty.FormattingEnabled = true;
            this.combo_Difficulty.IntegralHeight = false;
            this.combo_Difficulty.ItemHeight = 9;
            this.combo_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.combo_Difficulty.Location = new System.Drawing.Point(184, 156);
            this.combo_Difficulty.MaxDropDownItems = 3;
            this.combo_Difficulty.Name = "combo_Difficulty";
            this.combo_Difficulty.Size = new System.Drawing.Size(117, 17);
            this.combo_Difficulty.TabIndex = 5;
            this.combo_Difficulty.Text = "Difficulty";
            this.combo_Difficulty.SelectedIndexChanged += new System.EventHandler(this.combo_Difficulty_SelectedIndexChanged);
            // 
            // lbl_DIFFICULTY
            // 
            this.lbl_DIFFICULTY.AutoSize = true;
            this.lbl_DIFFICULTY.BackColor = System.Drawing.Color.White;
            this.lbl_DIFFICULTY.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DIFFICULTY.Location = new System.Drawing.Point(181, 119);
            this.lbl_DIFFICULTY.Name = "lbl_DIFFICULTY";
            this.lbl_DIFFICULTY.Size = new System.Drawing.Size(130, 14);
            this.lbl_DIFFICULTY.TabIndex = 6;
            this.lbl_DIFFICULTY.Text = "Difficulty:";
            // 
            // lbl_JAP_TITLE
            // 
            this.lbl_JAP_TITLE.AutoSize = true;
            this.lbl_JAP_TITLE.Font = new System.Drawing.Font("Commodore PET", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JAP_TITLE.Location = new System.Drawing.Point(197, 18);
            this.lbl_JAP_TITLE.Name = "lbl_JAP_TITLE";
            this.lbl_JAP_TITLE.Size = new System.Drawing.Size(105, 25);
            this.lbl_JAP_TITLE.TabIndex = 7;
            this.lbl_JAP_TITLE.Text = "寿司狩り！";
            // 
            // lbl_ENG_TITLE
            // 
            this.lbl_ENG_TITLE.AutoSize = true;
            this.lbl_ENG_TITLE.Font = new System.Drawing.Font("Commodore PET", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ENG_TITLE.ForeColor = System.Drawing.Color.Black;
            this.lbl_ENG_TITLE.Location = new System.Drawing.Point(152, 53);
            this.lbl_ENG_TITLE.Name = "lbl_ENG_TITLE";
            this.lbl_ENG_TITLE.Size = new System.Drawing.Size(189, 19);
            this.lbl_ENG_TITLE.TabIndex = 8;
            this.lbl_ENG_TITLE.Text = "SUSHI HUNT!";
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.BackColor = System.Drawing.Color.White;
            this.btn_Instructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Instructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Instructions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_Instructions.FlatAppearance.BorderSize = 2;
            this.btn_Instructions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_Instructions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instructions.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instructions.ForeColor = System.Drawing.Color.Black;
            this.btn_Instructions.Location = new System.Drawing.Point(24, 243);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.Size = new System.Drawing.Size(130, 87);
            this.btn_Instructions.TabIndex = 1;
            this.btn_Instructions.Text = "How to play";
            this.btn_Instructions.UseVisualStyleBackColor = false;
            this.btn_Instructions.Click += new System.EventHandler(this.btn_Instructions_Click);
            // 
            // btn_highScores
            // 
            this.btn_highScores.BackColor = System.Drawing.Color.White;
            this.btn_highScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_highScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_highScores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_highScores.FlatAppearance.BorderSize = 2;
            this.btn_highScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_highScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_highScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_highScores.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highScores.Location = new System.Drawing.Point(343, 119);
            this.btn_highScores.Name = "btn_highScores";
            this.btn_highScores.Size = new System.Drawing.Size(130, 87);
            this.btn_highScores.TabIndex = 3;
            this.btn_highScores.Text = "High score";
            this.btn_highScores.UseVisualStyleBackColor = false;
            this.btn_highScores.Click += new System.EventHandler(this.btn_highScore_Click);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.BackColor = System.Drawing.Color.White;
            this.btn_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_EXIT.FlatAppearance.BorderSize = 2;
            this.btn_EXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EXIT.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.ForeColor = System.Drawing.Color.Black;
            this.btn_EXIT.Location = new System.Drawing.Point(343, 243);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(130, 87);
            this.btn_EXIT.TabIndex = 4;
            this.btn_EXIT.Text = "Exit game";
            this.btn_EXIT.UseVisualStyleBackColor = false;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // pnl_nameEntry
            // 
            this.pnl_nameEntry.Controls.Add(this.btn_confirmName);
            this.pnl_nameEntry.Controls.Add(this.lbl_enterName);
            this.pnl_nameEntry.Controls.Add(this.txt_userName);
            this.pnl_nameEntry.Location = new System.Drawing.Point(12, 12);
            this.pnl_nameEntry.Name = "pnl_nameEntry";
            this.pnl_nameEntry.Size = new System.Drawing.Size(474, 381);
            this.pnl_nameEntry.TabIndex = 10;
            // 
            // btn_confirmName
            // 
            this.btn_confirmName.BackColor = System.Drawing.Color.White;
            this.btn_confirmName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirmName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_confirmName.FlatAppearance.BorderSize = 2;
            this.btn_confirmName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_confirmName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_confirmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmName.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmName.Location = new System.Drawing.Point(172, 68);
            this.btn_confirmName.Name = "btn_confirmName";
            this.btn_confirmName.Size = new System.Drawing.Size(130, 36);
            this.btn_confirmName.TabIndex = 5;
            this.btn_confirmName.Text = "Confirm";
            this.btn_confirmName.UseVisualStyleBackColor = false;
            this.btn_confirmName.Click += new System.EventHandler(this.btn_confirmName_Click);
            // 
            // lbl_enterName
            // 
            this.lbl_enterName.AutoSize = true;
            this.lbl_enterName.Font = new System.Drawing.Font("Commodore PET", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterName.Location = new System.Drawing.Point(142, 15);
            this.lbl_enterName.Name = "lbl_enterName";
            this.lbl_enterName.Size = new System.Drawing.Size(181, 12);
            this.lbl_enterName.TabIndex = 2;
            this.lbl_enterName.Text = "ENTER YOUR NAME";
            // 
            // txt_userName
            // 
            this.txt_userName.AcceptsReturn = true;
            this.txt_userName.Font = new System.Drawing.Font("Commodore PET", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(63, 34);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(330, 18);
            this.txt_userName.TabIndex = 1;
            // 
            // lbl_welcomeName
            // 
            this.lbl_welcomeName.AutoSize = true;
            this.lbl_welcomeName.Font = new System.Drawing.Font("Commodore PET", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeName.Location = new System.Drawing.Point(22, 87);
            this.lbl_welcomeName.Name = "lbl_welcomeName";
            this.lbl_welcomeName.Size = new System.Drawing.Size(60, 10);
            this.lbl_welcomeName.TabIndex = 6;
            this.lbl_welcomeName.Text = "[name]";
            this.lbl_welcomeName.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_welcomeName_Load);
            // 
            // btn_changeName
            // 
            this.btn_changeName.BackColor = System.Drawing.Color.White;
            this.btn_changeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_changeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changeName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_changeName.FlatAppearance.BorderSize = 2;
            this.btn_changeName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btn_changeName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_changeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeName.Font = new System.Drawing.Font("Commodore PET", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeName.Location = new System.Drawing.Point(184, 243);
            this.btn_changeName.Name = "btn_changeName";
            this.btn_changeName.Size = new System.Drawing.Size(130, 87);
            this.btn_changeName.TabIndex = 11;
            this.btn_changeName.Text = "Change name";
            this.btn_changeName.UseVisualStyleBackColor = false;
            this.btn_changeName.Click += new System.EventHandler(this.btn_changeName_Click);
            // 
            // musicTimer
            // 
            this.musicTimer.Interval = 1907;
            this.musicTimer.Tick += new System.EventHandler(this.musicTimer_Tick);
            // 
            // frm_mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.pnl_nameEntry);
            this.Controls.Add(this.lbl_ENG_TITLE);
            this.Controls.Add(this.lbl_welcomeName);
            this.Controls.Add(this.lbl_JAP_TITLE);
            this.Controls.Add(this.lbl_DIFFICULTY);
            this.Controls.Add(this.combo_Difficulty);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_highScores);
            this.Controls.Add(this.btn_Instructions);
            this.Controls.Add(this.btn_playGame);
            this.Controls.Add(this.btn_changeName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUSHI HUNT - Main Menu";
            this.Activated += new System.EventHandler(this.frm_mainMenu_Activated);
            this.Load += new System.EventHandler(this.frm_mainMenu_Load);
            this.pnl_nameEntry.ResumeLayout(false);
            this.pnl_nameEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_playGame;
        private System.Windows.Forms.ComboBox combo_Difficulty;
        private System.Windows.Forms.Label lbl_DIFFICULTY;
        private System.Windows.Forms.Label lbl_JAP_TITLE;
        private System.Windows.Forms.Label lbl_ENG_TITLE;
        private System.Windows.Forms.Button btn_Instructions;
        private System.Windows.Forms.Button btn_highScores;
        private System.Windows.Forms.Button btn_EXIT;
        private System.Windows.Forms.Panel pnl_nameEntry;
        private System.Windows.Forms.Label lbl_enterName;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_confirmName;
        private System.Windows.Forms.Label lbl_welcomeName;
        private System.Windows.Forms.Button btn_changeName;
        private System.Windows.Forms.Timer musicTimer;
    }
}

