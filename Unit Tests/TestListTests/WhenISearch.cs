using System;
using NUnit.Framework;
using MusicPlayer;
using System.Collections.Generic;

namespace Unit_Tests
{
    [TestFixture]
    public class WhenISearch
    {
        TracksList tracksList = new TracksList();
        [SetUp]
        public void Setup()
        {            
            tracksList.Songs = new List<Song>
            {
                new Song{Id = 1, Name = "Song1", Artist = "Artist1", AlbumId = 1, Path = "Path1"},
                new Song{Id = 2, Name = "Song2", Artist = "Artist2", AlbumId = 2, Path = "Path2"},
                new Song{Id = 2, Name = "Song3", Artist = "Artist3", AlbumId = 3, Path = "Path3"},
            };
        }

        [Test]
        public void AndTheSearchTermIsContainedInASongTheSongShouldBeReturned()
        {
            //Arrange
            string searchTerm = "1";
            //Act
            var actual = tracksList.Search(searchTerm);
            //Assert
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Song1", actual[0].Name);
        }
    }
}
