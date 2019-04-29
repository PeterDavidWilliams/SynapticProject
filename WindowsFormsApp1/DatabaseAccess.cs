using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace MusicPlayer
{
    public class DatabaseAccess
    {
        private List<Song> Songs = new List<Song>();
        private const string ConnectionString = "Server=(localdb)\\ProjectsV13;Database=MusicPlayerDb;Trusted_Connection=True";

        public virtual List<Song> GetSongs()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var command = new SqlCommand("SELECT Id, Name, Artist, AlbumId, Path FROM [Song]", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fixedPath = reader[4].ToString();
                        var newFixedPath = fixedPath.Replace("\\", "/");
                        Songs.Add(
                            new Song
                            {
                                Id = (int)reader[0],
                                Name = reader[1].ToString(),
                                Artist = reader[2].ToString(),
                                AlbumId = (int)reader[3],
                                Path = newFixedPath
                            });
                    }
                }
            }
            return Songs;
        }

        public virtual List<Album> GetAlbums()
        {
            var albums = new List<Album>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var command = new SqlCommand("SELECT Id, Name FROM Album", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var albumSongs = GetAlbumSongs((int)reader[0]);
                        albums.Add(
                            new Album
                            {
                                Id = (int)reader[0],
                                Name = reader[1].ToString(),
                                Songs = albumSongs,
                                Artist = albumSongs[0].Artist
                            });
                    }
                }
            }
            return albums;
        }

        public virtual List<Playlist> GetPlaylists()
        {
            var playlists = new List<PlaylistData>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var command = new SqlCommand("SELECT Id, Name, SongId FROM Playlist", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        playlists.Add(
                            new PlaylistData
                            {
                                Id = (int)reader[0],
                                Name = reader[1].ToString(),
                                SongId = (int)reader[2]
                            });
                    }
                }
            }

            return PopulatePlaylists(playlists);
        }

        private List<Song> GetAlbumSongs(int albumId)
        {
            var returnList = new List<Song>();
            foreach (Song song in Songs)
            {
                if (song.AlbumId == albumId)
                    returnList.Add(song);
            }
            return returnList;
        }

        private List<Playlist> PopulatePlaylists(List<PlaylistData> playlists)
        {
            List<PlaylistData> playlistsByName = playlists.GroupBy(x => x.Name).Select(y => y.First()).ToList();
            var returnPlaylists = new List<Playlist>();

            for (int i = 0; i < playlistsByName.Count(); i++)
            {
                var playlistSongs = new List<Song>();
                foreach (PlaylistData data in playlists)
                {
                    if (data.Name == playlistsByName[i].Name)
                    {
                        foreach (Song song in Songs)
                            if (song.Id == data.SongId)
                                playlistSongs.Add(song);
                    }
                }
                returnPlaylists.Add(
                    new Playlist
                    {
                        Songs = playlistSongs,
                        Name = playlistsByName[i].Name
                    });
            }

            return returnPlaylists;
        }

        public void SavePlaylist(Playlist playlist)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                var command = new SqlCommand("INSERT INTO PlayList(Name, SongId) VALUES(@Name, @SongId)", con);
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = playlist.Name;
                command.Parameters.Add("@SongId", SqlDbType.Int);

                foreach (Song song in playlist.Songs)
                {
                    command.Parameters["@SongId"].Value = song.Id;
                    command.ExecuteNonQuery();
                }                
            }
        }
    }
}
