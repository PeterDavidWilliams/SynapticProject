using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicPlayer;

namespace MusicPlayerTests.TracksListTest
{
    [TestClass]
    public class WhenISkipBackward
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
        public void ThenTheCurrentlyPlayingSongWillBeUpdated()
        {
            //Arrange
            Setup();
            tracksList.CurrentlyPlayingIndex = 1;
            //Act
            tracksList.SkipBackward();
            //Assert
            Assert.AreEqual(0, tracksList.CurrentlyPlayingIndex);
        }

        [TestMethod]
        public void AndTheFirstSongIsCurrentlyPlayingThenTheLastTrackWillBePlayed()
        {
            //Arrange
            Setup();
            tracksList.CurrentlyPlayingIndex = 0;
            var lastTrackIndex = tracksList.CurrentlyPlaying.Count - 1;
            //Act
            tracksList.SkipBackward();
            //Assert
            Assert.AreEqual(lastTrackIndex, tracksList.CurrentlyPlayingIndex);
        }
    }
}
