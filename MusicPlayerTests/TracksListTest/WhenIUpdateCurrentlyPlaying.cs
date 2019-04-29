using System;
using System.Collections.Generic;
using System.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MusicPlayer;

namespace MusicPlayerTests.TracksListTest
{
    [TestClass]
    public class WhenIUpdateCurrentlyPlaying
    {
        TracksList tracksList = new TracksList();

        private void Setup()
        {
            var song1 = new Song
            {
                Id = 1,
                Name = "TestName1",
                Artist = "TestArtist1",
                AlbumId = 1,
                Path = "TestPath1"
            };
            var song2 = new Song
            {
                Id = 2,
                Name = "TestName2",
                Artist = "TestArtist2",
                AlbumId = 2,
                Path = "TestPath2"
            };
            var song3 = new Song
            {
                Id = 3,
                Name = "TestName3",
                Artist = "TestArtist3",
                AlbumId = 3,
                Path = "TestPath3"
            };
            var song4 = new Song
            {
                Id = 4,
                Name = "TestName4",
                Artist = "TestArtist4",
                AlbumId = 4,
                Path = "TestPath4"
            };
            var song5 = new Song
            {
                Id = 5,
                Name = "TestName5",
                Artist = "TestArtist5",
                AlbumId = 5,
                Path = "TestPath5"
            };
            tracksList.CurrentlyPlaying = new List<Song> { song1, song2, song3, song4, song5 };
        }

        [TestMethod]
        public void AndISpecifyWhichSongsToPlayThenThoseSongsWillReplaceTheCurrentlyPlayingList()
        {
            //Arrange
            Setup();

            var song6 = new Song
            {
                Id = 6,
                Name = "TestName6",
                Artist = "TestArtist6",
                AlbumId = 6,
                Path = "TestPath6"
            };
            var song7 = new Song
            {
                Id = 7,
                Name = "TestName7",
                Artist = "TestArtist7",
                AlbumId = 7,
                Path = "TestPath7"
            };
            var song8 = new Song
            {
                Id = 8,
                Name = "TestName8",
                Artist = "TestArtist8",
                AlbumId = 8,
                Path = "TestPath8"
            };

            var newSongList = new List<Song> { song6, song7, song8 };

            //Act
            tracksList.UpdateCurrentlyPlayingSong(newSongList, false);

            //Assert
            Assert.AreEqual(3, tracksList.CurrentlyPlaying.Count);
            Assert.AreEqual("TestName6", tracksList.CurrentlyPlaying[0].Name);
        }

        [TestMethod]
        public void AndISpecifyWhichSongInTheListToPlayThenTheChoseSongWillBePlayed()
        {
            //Arrange
            Setup();
            //Act
            tracksList.UpdateCurrentlyPlayingSong(3, false);
            //Assert
            Assert.AreEqual(3, tracksList.CurrentlyPlayingIndex);
            Assert.AreEqual("TestName4", tracksList.CurrentlyPlaying[3].Name);
        }
    }
}
