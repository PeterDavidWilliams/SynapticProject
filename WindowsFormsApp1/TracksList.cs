using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MusicPlayer
{
    public class TracksList
    {
        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Song> CurrentlyPlaying { get; set; }
        public int CurrentlyPlayingIndex { get; set; }
        public DatabaseAccess db = new DatabaseAccess();
        public SoundPlayer player = new SoundPlayer();

        public void GetAll()
        {
            Songs = db.GetSongs();

            Albums = db.GetAlbums();

            Playlists = db.GetPlaylists();

            SetCurrentlyPlaying();
        }

        public List<Song> Search(string searchTerm)
        {
            var returnList = new List<Song>();
            foreach(Song song in Songs)
            {
                if (song.Name.ToUpper().Contains(searchTerm.ToUpper()))
                    returnList.Add(song);
            }
            return returnList;
        }

        public void UpdateCurrentlyPlayingSong(List<Song> songs, bool isShuffled)
        {
            CurrentlyPlaying.Clear();

            foreach (Song song in songs)
                CurrentlyPlaying.Add(song);

            if (isShuffled)
                Shuffle();
            
            CurrentlyPlayingIndex = 0;
        }

        public void UpdateCurrentlyPlayingSong(bool isShuffled)
        {
            if (isShuffled)
                Shuffle();
        }

        public void UpdateCurrentlyPlayingSong(int index, bool isShuffled)
        {
            if (isShuffled)
                Shuffle();

            CurrentlyPlayingIndex = index;
        }

        public void Play()
        {
            player.SoundLocation = CurrentlyPlaying[CurrentlyPlayingIndex].Path;
            player.Play();            
        }

        public void Stop()
        {
            player.Stop();
        }

        public void SkipForward()
        {
            if (CurrentlyPlayingIndex == CurrentlyPlaying.Count()-1)
            {
                CurrentlyPlayingIndex = 0;            
            }
            else
            {
                CurrentlyPlayingIndex += 1;
            }
        }

        public void SkipBackward()
        {
            if (CurrentlyPlayingIndex == 0)
            {
                CurrentlyPlayingIndex = CurrentlyPlaying.Count() - 1;
            }
            else
            {
                CurrentlyPlayingIndex -= 1;
            }
        }

        private void Shuffle()
        {
            Random r = new Random();
            CurrentlyPlaying = CurrentlyPlaying.OrderBy(x => (r.Next())).ToList();
            CurrentlyPlayingIndex = 0;
        }

        public Song GetSongByName(string name)
        {
            foreach(Song song in Songs)
            {
                if (name == song.Name)
                    return song;
            }
            return null;
        }

        public List<string> GetCurrentlyPlaying()
        {
            var name = CurrentlyPlaying[CurrentlyPlayingIndex].Name;
            var artist = CurrentlyPlaying[CurrentlyPlayingIndex].Artist;
            var albumName = "";
            foreach (Album album in Albums)
            {
                if (album.Id == CurrentlyPlaying[CurrentlyPlayingIndex].AlbumId)
                    albumName = album.Name;
            }
            return new List<string> { name, artist, albumName };
        }

        public void SetCurrentlyPlaying()
        {
            CurrentlyPlaying = new List<Song>();
            foreach (Song song in Songs)
                CurrentlyPlaying.Add(song);
        }
    }
}
