using MusicPlayer.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlayerMain : Form
    {
        TracksList TracksList = new TracksList();
        ListTypes currentListType = new ListTypes();

        public PlayerMain()
        {
            InitializeComponent();
            SearchInputTextBox.Visible = false;
            SearchButton.Visible = false;
            SearchResultsListBox.Visible = false;
            ClearSearchButton.Visible = false;
            TracksList.GetAll();
            TracksList.CurrentlyPlaying = TracksList.Songs;
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            TracksList.UpdateCurrentlyPlayingSong(true);
            UpdateCurrentlyPlaying();
            TracksList.Play();
        }

        private void PlaylistsButton_Click(object sender, EventArgs e)
        {
            MusicDisplayListBox.Items.Clear();
            foreach (Playlist playlist in TracksList.Playlists)
                MusicDisplayListBox.Items.Add(playlist.Name);
            currentListType = ListTypes.Playlist;
        }

        private void AlbumsButton_Click(object sender, EventArgs e)
        {
            MusicDisplayListBox.Items.Clear();
            foreach (Album album in TracksList.Albums)
                MusicDisplayListBox.Items.Add(album.Name);
            currentListType = ListTypes.Album;
        }

        private void SongsButton_Click(object sender, EventArgs e)
        {
            MusicDisplayListBox.Items.Clear();
            foreach (Song song in TracksList.Songs)
                MusicDisplayListBox.Items.Add(song.Name);
            currentListType = ListTypes.Song;
        }

        private void SongSearchButton_Click(object sender, EventArgs e)
        {
            SearchInputTextBox.Visible = true;
            SearchButton.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchResultsListBox.Visible = true;
            ClearSearchButton.Visible = true;
            var searchResults = TracksList.Search(SearchInputTextBox.Text);
            if (searchResults.Count() != 0)
            {
                foreach (Song song in searchResults)
                    SearchResultsListBox.Items.Add(song.Name);
            }
            else
                SearchResultsListBox.Items.Add("No results found");
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            SearchResultsListBox.ResetText();
            SearchInputTextBox.Visible = false;
            SearchButton.Visible = false;
            SearchResultsListBox.Visible = false;
            ClearSearchButton.Visible = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (MusicDisplayListBox.SelectedItem != null)
            {
                switch (currentListType)
                {
                    case ListTypes.Song:
                        var songIndex = GetSongIndex(MusicDisplayListBox.Text);
                        TracksList.UpdateCurrentlyPlayingSong(songIndex, false);
                        break;
                    case ListTypes.Album:
                        var albumIndex = GetAlbumIndex(MusicDisplayListBox.Text);
                        TracksList.UpdateCurrentlyPlayingSong(TracksList.Albums[albumIndex].Songs, false);
                        break;
                    case ListTypes.Playlist:
                        var playlistIndex = GetPlaylistIndex(MusicDisplayListBox.Text);
                        TracksList.UpdateCurrentlyPlayingSong(TracksList.Playlists[playlistIndex].Songs, false);
                        break;
                }                
            }
            else
            {
                TracksList.UpdateCurrentlyPlayingSong(false);
            }
            UpdateCurrentlyPlaying();
            TracksList.Play();
        }

        private int GetSongIndex(string songName)
        {
            for (int i = 0; i < TracksList.Songs.Count(); i++)
                if (songName == TracksList.Songs[i].Name)
                    return i;
            return 0;
        }
        
        private int GetAlbumIndex(string albumName)
        {
            for (int i = 0; i < TracksList.Albums.Count(); i++)
                if (albumName == TracksList.Albums[i].Name)
                    return i;
            return 0;
        }

        private int GetPlaylistIndex(string playlistName)
        {
            for (int i = 0; i < TracksList.Playlists.Count(); i++)
                if (playlistName == TracksList.Playlists[i].Name)
                    return i;
            return 0;
        }

        private void SkipForwardButton_Click(object sender, EventArgs e)
        {
            TracksList.SkipForward();
            TracksList.Play();
            UpdateCurrentlyPlaying();
        }

        private void SkipBackButton_Click(object sender, EventArgs e)
        {
            TracksList.SkipBackward();
            TracksList.Play();
            UpdateCurrentlyPlaying();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            TracksList.Stop();
        }

        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            CreatePlaylist form = new CreatePlaylist();
            form.TracksList = TracksList;
            form.Show();
        }

        private void UpdateCurrentlyPlaying()
        {
            var currentlyPlaying = TracksList.GetCurrentlyPlaying();
            CurrentlyPlayingFieldLabel.Text = currentlyPlaying[0];
            ArtistFieldLabel.Text = currentlyPlaying[1];
            AlbumFieldLabel.Text = currentlyPlaying[2];
        }
    }
}
