namespace SUSHI_HUNT
{
    partial class frm_Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Instructions));
            this.btn_returnMenu = new System.Windows.Forms.Button();
            this.txt_Instructions = new System.Windows.Forms.TextBox();
            this.musicTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.btn_returnMenu.Location = new System.Drawing.Point(178, 312);
            this.btn_returnMenu.Name = "btn_returnMenu";
            this.btn_returnMenu.Size = new System.Drawing.Size(130, 87);
            this.btn_returnMenu.TabIndex = 4;
            this.btn_returnMenu.Text = "Return to main menu";
            this.btn_returnMenu.UseVisualStyleBackColor = false;
            this.btn_returnMenu.Click += new System.EventHandler(this.btn_returnMenu_Click);
            // 
            // txt_Instructions
            // 
            this.txt_Instructions.BackColor = System.Drawing.Color.White;
            this.txt_Instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Instructions.Font = new System.Drawing.Font("Commodore PET", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Instructions.Location = new System.Drawing.Point(13, 13);
            this.txt_Instructions.Multiline = true;
            this.txt_Instructions.Name = "txt_Instructions";
            this.txt_Instructions.ReadOnly = true;
            this.txt_Instructions.Size = new System.Drawing.Size(473, 293);
            this.txt_Instructions.TabIndex = 5;
            this.txt_Instructions.Text = resources.GetString("txt_Instructions.Text");
            this.txt_Instructions.Enter += new System.EventHandler(this.txt_Instructions_Enter);
            // 
            // musicTimer
            // 
            this.musicTimer.Enabled = true;
            this.musicTimer.Interval = 6495;
            this.musicTimer.Tick += new System.EventHandler(this.musicTimer_Tick);
            // 
            // frm_Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.txt_Instructions);
            this.Controls.Add(this.btn_returnMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUSHI HUNT - Instructions";
            this.Load += new System.EventHandler(this.frm_Instructions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_returnMenu;
        private System.Windows.Forms.TextBox txt_Instructions;
        private System.Windows.Forms.Timer musicTimer;
    }
}