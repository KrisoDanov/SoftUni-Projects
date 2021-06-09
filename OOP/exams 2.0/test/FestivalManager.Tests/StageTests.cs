// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class StageTests
    {
        [Test]
        public void DoesListFromSongsAddsSongs()
        {
            TimeSpan interval = new TimeSpan(5, 6, 2);
            Song ivana = new Song("NeshtoNeTipichno", interval);
            List<Song> songs = new List<Song>();
            songs.Add(ivana);
            songs.Add(ivana);

            int expectedOutpu = 2;
            int realOutput = songs.Count;

            Assert.AreEqual(expectedOutpu, realOutput);
        }

        [Test]
        public void DoesListFromPerformerAddsPerfomer()
        {
            Performer performer = new Performer("Kriso", "Bace", 22);
            List<Performer> performers = new List<Performer>();
            performers.Add(performer);
            performers.Add(performer);

            int expectedOutpu = 2;
            int realOutput = performers.Count;

            Assert.AreEqual(expectedOutpu, realOutput);

        }

        [Test]
        public void IFperformerIsLessThan18()
        {
            Performer kriso = new Performer("Kriso", "Bace", 13);
            Stage stage = new Stage();
            Assert.Throws<ArgumentException>(() => stage.AddPerformer(kriso));

        }
        [Test]
        public void IFsongsIsLessTnah1Min()
        {
            TimeSpan interval = new TimeSpan(0, 0, 1);
            Song song = new Song("udrii", interval);
            Stage stage = new Stage();
            Assert.Throws<ArgumentException>(() => stage.AddSong(song));

        }

        [Test]
        public void TryToAddSongToPerfomer()
        {
            TimeSpan interval = new TimeSpan(0, 0, 1);
            Song song = new Song("udrii", interval);
            Performer kriso = new Performer("Kriso", "Bace", 13);

            kriso.SongList.Add(song);
            kriso.SongList.Add(song);

            var expectedOuptup = 2;
            var realdOuptup = kriso.SongList.Count;

            Assert.AreEqual(expectedOuptup, realdOuptup);
        }
        
    }
}