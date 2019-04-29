using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MusicPlayer;

namespace MusicPlayerTests
{
    [TestClass]
    public class WhenIGetTracks
    {
        TracksList tracksList = new TracksList();
        Mock<DatabaseAccess> db = new Mock<DatabaseAccess>();

        private void Setup()
        {
            tracksList.db = db.Object;

            var song = new Song {
                Id = 1,
                Name = "TestName",
                Artist = "TestArtist",
                AlbumId = 1,
                Path = "TestPath"
            };

            db.Setup(x => x.GetSongs()).Returns(new List<Song>{song});

            db.Setup(x => x.GetAlbums()).Returns(new List<Album>{ new Album
            {Name = "TestAlbum", Artist = "TestArtist",
                Songs = new List<Song>{song}, Id = 1 } });

            db.Setup(x => x.GetPlaylists()).Returns(new List<Playlist> { new Playlist
            {
                Name = "TestPlaylist",
                Songs = new List<Song>{song}
            } });

            tracksList.CurrentlyPlaying = new List<Song>();
        }

        [TestMethod]
        public void ThenTheSongsAreStored()
        {
            //Arrange
            Setup();
            //Act
            tracksList.GetAll();
            //Assert
            Assert.AreEqual(1, tracksList.Songs.Count);
            Assert.AreEqual("TestName", tracksList.Songs[0].Name);
        }

        [TestMethod]
        public void ThenTheAlbumsAreStored()
        {
            //Arrange
            Setup();
            //Act
            tracksList.GetAll();
            //Assert
            Assert.AreEqual(1, tracksList.Albums.Count);
            Assert.AreEqual("TestAlbum", tracksList.Albums[0].Name);
        }

        [TestMethod]
        public void ThenThePlaylistsAreStored()
        {
            //Arrange
            Setup();
            //Act
            tracksList.GetAll();
            //Assert
            Assert.AreEqual(1, tracksList.Albums.Count);
            Assert.AreEqual("TestPlaylist", tracksList.Playlists[0].Name);
        }
    }
}
