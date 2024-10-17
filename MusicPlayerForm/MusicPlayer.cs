using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using NAudio.Wave;

namespace MusicPlayerForm
{
    public class MusicPlayer
    {
        private List<string> playlist;
        private WaveOutEvent player;
        private AudioFileReader audioFile;
        private int currentTrackIndex;

        public MusicPlayer()
        {
            playlist = new List<string>();
            currentTrackIndex = 0;
            player = new WaveOutEvent();
        }

        public void AddSong(string filePath)
        {
            if (File.Exists(filePath))
            {
                playlist.Add(filePath);
            }
        }

        public void Play()
        {
            if (playlist.Count > 0 && currentTrackIndex >= 0 && currentTrackIndex < playlist.Count)
            {
                Stop();
                audioFile = new AudioFileReader(playlist[currentTrackIndex]);
                player.Init(audioFile);
                player.Play();
            }
        }

        public void Pause()
        {
            if (player != null && player.PlaybackState == PlaybackState.Playing)
            {
                player.Pause();
            }
        }

        public void Stop()
        {
            player?.Stop();
            audioFile?.Dispose();
            audioFile = null;
        }

        public void Next()
        {
            if (playlist.Count > 0)
            {
                currentTrackIndex = (currentTrackIndex + 1) % playlist.Count;
                Play();
            }
        }

        public void Previous()
        {
            if (playlist.Count > 0)
            {
                currentTrackIndex = (currentTrackIndex - 1 + playlist.Count) % playlist.Count;
                Play();
            }
        }

        public void DeleteSong(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                playlist.RemoveAt(index);
                if (currentTrackIndex >= index && currentTrackIndex > 0)
                {
                    currentTrackIndex--;
                }
            }
        }

        public void SetVolume(float volume)
        {
            if (audioFile != null)
            {
                audioFile.Volume = volume; // Set volume (0.0 to 1.0)
            }
        }

        public List<string> GetPlaylist()
        {
            return playlist;
        }

        public int GetCurrentTrackIndex()
        {
            return currentTrackIndex;
        }

        public void SetCurrentTrackIndex(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                currentTrackIndex = index;
            }
        }
    }
}
