using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicPlayer;

namespace MusicPlayerTests.TracksListTest
{
    [TestClass]
    public class WhenISearchTracks
    {
        TracksList tracksList = new TracksList();

        private void Setup()
        {
            var song = new Song
            {
                Id = 1,
                Name = "TestName",
                Artist = "TestArtist",
                AlbumId = 1,
                Path = "TestPath"
            };

            tracksList.Songs = new List<Song> { song };
        }

        [TestMethod]
        public void ThenTheTracksThatMatchTheSearchTermAreReturned()
        {
            //Arrange
            Setup();
            //Act
            var actual = tracksList.Search("TestName");
            //Assert
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("TestName", actual[0].Name);
        }

        [TestMethod]
        public void ThenTheTracksThatPartiallyMatchTheSearchTermAreReturned()
        {
            //Arrange
            Setup();
            //Act
            var actual = tracksList.Search("Test");
            //Assert
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("TestName", actual[0].Name);
        }

        [TestMethod]
        public void ThenTheTracksThatMatchTheSearchTermAreReturnedIgnoringCase()
        {
            //Arrange
            Setup();
            //Act
            var actual = tracksList.Search("TESTNAME");
            //Assert
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("TestName", actual[0].Name);
        }
    }
}
