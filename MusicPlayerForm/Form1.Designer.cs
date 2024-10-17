namespace MusicPlayerForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.lblCurrentTrack = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();

            // Form dimensions
            this.ClientSize = new System.Drawing.Size(500, 450);

            // btnAddSong
            this.btnAddSong.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSong.Location = new System.Drawing.Point(15, 15);
            this.btnAddSong.Size = new System.Drawing.Size(90, 35);
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);

            // btnPlay
            this.btnPlay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlay.Location = new System.Drawing.Point(15, 60);
            this.btnPlay.Size = new System.Drawing.Size(90, 35);
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);

            // btnPause
            this.btnPause.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPause.Location = new System.Drawing.Point(15, 105);
            this.btnPause.Size = new System.Drawing.Size(90, 35);
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);

            // btnStop
            this.btnStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(15, 150);
            this.btnStop.Size = new System.Drawing.Size(90, 35);
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // btnNext
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(15, 195);
            this.btnNext.Size = new System.Drawing.Size(90, 35);
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // btnPrevious
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.Location = new System.Drawing.Point(15, 240);
            this.btnPrevious.Size = new System.Drawing.Size(90, 35);
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);

            // btnDelete
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(15, 285);
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // listBoxPlaylist
            this.listBoxPlaylist.Font = new System.Drawing.Font("Arial", 10F);
            this.listBoxPlaylist.Location = new System.Drawing.Point(120, 15);
            this.listBoxPlaylist.Size = new System.Drawing.Size(360, 300);
            this.listBoxPlaylist.ItemHeight = 16;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);

            // lblCurrentTrack
            this.lblCurrentTrack.AutoSize = true;
            this.lblCurrentTrack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentTrack.Location = new System.Drawing.Point(120, 320);
            this.lblCurrentTrack.Text = "Current Track: ";

            // trackBarVolume
            this.trackBarVolume.Location = new System.Drawing.Point(15, 335);
            this.trackBarVolume.Size = new System.Drawing.Size(465, 45);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);

            // Form1
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.lblCurrentTrack);
            this.Controls.Add(this.trackBarVolume);

            this.Name = "Form1";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Label lblCurrentTrack;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button btnDelete;
    }
}
