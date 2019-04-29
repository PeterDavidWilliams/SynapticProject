using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Screens
{
    public partial class CreatePlaylist : Form
    {
        public DatabaseAccess Db = new DatabaseAccess();
        public TracksList TracksList { get; set; }

        public CreatePlaylist()
        {
            InitializeComponent();
            InitialiazeSongsListBox();
        }

        private void InitialiazeSongsListBox()
        {
            List<Song> Songs = Db.GetSongs();
            SongsListBox.ResetText();
            foreach (Song song in Songs)
                SongsListBox.Items.Add(song.Name);
        }

        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            bool hasErrored = false;
            if(string.IsNullOrWhiteSpace(PlaylistNameTextBox.Text))
            {
                NameErrorMessageLabel.Text = "You must enter a name";
                hasErrored = true;
            }
            if(SongsListBox.SelectedIndex == -1)
            {
                SongListErrorMessageLabel.Text = "You must select at least one song";
                hasErrored = true;
            }
            if (!hasErrored)
            {
                NameErrorMessageLabel.Text = "";
                SongListErrorMessageLabel.Text = "";
                var playlistSongs = new List<Song>();
                foreach(string item in SongsListBox.SelectedItems)
                {
                    playlistSongs.Add(TracksList.GetSongByName(item));
                }
                var playlist = new Playlist { Name = PlaylistNameTextBox.Text, Songs = playlistSongs };
                Db.SavePlaylist(playlist);
                this.Close();
            }
        }
    }
}
