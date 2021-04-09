namespace MusicPlaylists
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.cmbPlaylists = new System.Windows.Forms.ComboBox();
            this.windowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.IndianRed;
            this.TopPanel.Controls.Add(this.btnQuit);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.Snow;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(799, 61);
            this.TopPanel.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(722, 0);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 61);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Player";
            // 
            // lstSongs
            // 
            this.lstSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSongs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 18;
            this.lstSongs.Location = new System.Drawing.Point(497, 135);
            this.lstSongs.Margin = new System.Windows.Forms.Padding(4);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(264, 218);
            this.lstSongs.TabIndex = 1;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSongs.ForeColor = System.Drawing.Color.Black;
            this.btnSelectSongs.Location = new System.Drawing.Point(497, 361);
            this.btnSelectSongs.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(264, 44);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Pilih Lagu";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // cmbPlaylists
            // 
            this.cmbPlaylists.FormattingEnabled = true;
            this.cmbPlaylists.Location = new System.Drawing.Point(497, 103);
            this.cmbPlaylists.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlaylists.Name = "cmbPlaylists";
            this.cmbPlaylists.Size = new System.Drawing.Size(264, 24);
            this.cmbPlaylists.TabIndex = 4;
            this.cmbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylists_SelectedIndexChanged);
            // 
            // windowsMediaPlayerMusic
            // 
            this.windowsMediaPlayerMusic.Enabled = true;
            this.windowsMediaPlayerMusic.Location = new System.Drawing.Point(23, 90);
            this.windowsMediaPlayerMusic.Margin = new System.Windows.Forms.Padding(4);
            this.windowsMediaPlayerMusic.Name = "windowsMediaPlayerMusic";
            this.windowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayerMusic.OcxState")));
            this.windowsMediaPlayerMusic.Size = new System.Drawing.Size(334, 240);
            this.windowsMediaPlayerMusic.TabIndex = 3;
            this.windowsMediaPlayerMusic.Enter += new System.EventHandler(this.windowsMediaPlayerMusic_Enter);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 427);
            this.Controls.Add(this.cmbPlaylists);
            this.Controls.Add(this.windowsMediaPlayerMusic);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        public AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayerMusic;
        private System.Windows.Forms.ComboBox cmbPlaylists;
    }
}