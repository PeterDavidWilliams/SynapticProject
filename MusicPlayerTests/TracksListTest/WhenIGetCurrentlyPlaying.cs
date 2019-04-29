using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicPlayer;

namespace MusicPlayerTests.TracksListTest
{
    [TestClass]
    public class WhenIGetCurrentlyPlaying
    {
        TracksList tracksList = new TracksList();

        private void Setup()
        {
            var song1 = new Song{Id = 1, Name = "TestName1", Artist = "TestArtist1",
                AlbumId = 1,Path = "TestPath1"};
            var song2 = new Song{Id = 2,Name = "TestName2",Artist = "TestArtist2",
                AlbumId = 2,Path = "TestPath2"};
            var song3 = new Song{Id = 3,Name = "TestName3",Artist = "TestArtist3",
                AlbumId = 3,Path = "TestPath3"};
            var song4 = new Song{Id = 4,Name = "TestName4",Artist = "TestArtist4",
                AlbumId = 4,Path = "TestPath4"};
            var song5 = new Song{Id = 5,Name = "TestName5",Artist = "TestArtist5",
                AlbumId = 5,Path = "TestPath5"};

            tracksList.CurrentlyPlaying = new List<Song> { song1, song2, song3, song4, song5 };

            var album1 = new Album{Name = "TestAlbum1",Artist = "TestArtist1",
                Songs = new List<Song> { song1 },Id = 1};
            var album2 = new Album{Name = "TestAlbum2",Artist = "TestArtist2",
                Songs = new List<Song> { song2 },Id = 2};
            var album3 = new Album{Name = "TestAlbum3",Artist = "TestArtist3",
                Songs = new List<Song> { song3 },Id = 3};
            var album4 = new Album{Name = "TestAlbum4",Artist = "TestArtist4",
                Songs = new List<Song> { song4 },Id = 4};
            var album5 = new Album{Name = "TestAlbum5",Artist = "TestArtist5",
                Songs = new List<Song> { song5 },Id = 5};

            tracksList.Albums = new List<Album> { album1, album2, album3, album4, album5 };

            tracksList.CurrentlyPlayingIndex = 1;
        }
        [TestMethod]
        public void ThenTheCurrentlyPlayingSongDetailsAreReturned()
        {
            //Arrange
            Setup();
            //Act
            var currentlyPlayingDetails = tracksList.GetCurrentlyPlaying();
            //Assert
            Assert.AreEqual("TestName2", currentlyPlayingDetails[0]);
            Assert.AreEqual("TestArtist2", currentlyPlayingDetails[1]);
            Assert.AreEqual("TestAlbum2", currentlyPlayingDetails[2]);
        }
    }
}
