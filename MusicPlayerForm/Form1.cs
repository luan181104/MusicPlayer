using System;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayerForm
{
    public partial class Form1 : Form
    {
        private MusicPlayer musicPlayer; // Instance of MusicPlayer

        public Form1()
        {
            InitializeComponent();
            musicPlayer = new MusicPlayer(); // Initialize the MusicPlayer instance
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Updated filter to include .mp3 files
                openFileDialog.Filter = "Audio Files (*.wav;*.mp3)|*.wav;*.mp3|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    musicPlayer.AddSong(openFileDialog.FileName); // Add the selected song to the music player
                    listBoxPlaylist.Items.Add(Path.GetFileName(openFileDialog.FileName)); // Add the song name to the list box
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPlaylist.SelectedIndex;
            if (selectedIndex >= 0)
            {
                musicPlayer.DeleteSong(selectedIndex); // Call DeleteSong in MusicPlayer
                listBoxPlaylist.Items.RemoveAt(selectedIndex); // Remove the item from the ListBox
                UpdateCurrentTrack(); // Update the UI to reflect the deletion
            }
            else
            {
                MessageBox.Show("Please select a song to delete.");
            }
        }



        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the current track index when a song is selected
            musicPlayer.SetCurrentTrackIndex(listBoxPlaylist.SelectedIndex);
            lblCurrentTrack.Text = "Current Track: " + listBoxPlaylist.SelectedItem.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            musicPlayer.Play(); // Play the selected song
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            musicPlayer.Pause(); // Pause the song
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop(); // Stop the song
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            musicPlayer.Next(); // Move to the next track
            UpdateCurrentTrack(); // Update the UI
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            musicPlayer.Previous(); // Move to the previous track
            UpdateCurrentTrack(); // Update the UI
        }

        private void UpdateCurrentTrack()
        {
            int currentTrackIndex = musicPlayer.GetCurrentTrackIndex();
            listBoxPlaylist.SelectedIndex = currentTrackIndex; // Update the ListBox selection
            lblCurrentTrack.Text = "Current Track: " + listBoxPlaylist.SelectedItem?.ToString() ?? "None"; // Update the label
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            float volume = trackBarVolume.Value / 100f; // Convert track bar value (0-100) to volume (0.0-1.0)
            musicPlayer.SetVolume(volume); // Adjust volume
            
        }

    }
}
