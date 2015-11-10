using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisKata;

namespace TennisKataTest
{
    [TestClass]
    public class TennisKataTest
    {
        [TestMethod]
        [TestCategory("Team")]
        public void TeamAwardPoint()
        {
            ITeam team = new Team();
            int oldPoints = team.Points;

            team.AwardPoint();

            Assert.IsTrue(oldPoints + 1 == team.Points);
        }

        [TestMethod]
        [TestCategory("Game")]
        public void GameAwardPoint()
        {
            IGame game = new Game();

            game.AwardPoint(1); //give team 1 a point

            Assert.IsTrue(String.Equals(game.GetScore(), "15-0"));
        }

        [TestMethod]
        [TestCategory("Game")]
        public void GetScore()
        {
            IGame game = new Game();
            string score1 = game.GetScore();

            game.AwardPoint(1);
            string score2 = game.GetScore();
            game.AwardPoint(1); 
            string score3 = game.GetScore();
            game.AwardPoint(1);
            string score4 = game.GetScore();
            game.AwardPoint(2);
            game.AwardPoint(2);
            game.AwardPoint(2);
            string score5 = game.GetScore();
            game.AwardPoint(1);
            string score6 = game.GetScore();
            game.AwardPoint(2);
            game.AwardPoint(2);
            string score7 = game.GetScore();

            Assert.IsTrue(String.Equals(score1, "0-0"));
            Assert.IsTrue(String.Equals(score2, "15-0"));
            Assert.IsTrue(String.Equals(score3, "30-0"));
            Assert.IsTrue(String.Equals(score4, "40-0"));
            Assert.IsTrue(String.Equals(score5, "Deuce"));
            Assert.IsTrue(String.Equals(score6, "Adv-40"));
            Assert.IsTrue(String.Equals(score7, "40-Adv"));
        }

        [TestMethod]
        [TestCategory("Game")]
        public void IsDeuce()
        {
            IGame game = new Game();

            game.AwardPoint(1); //15
            game.AwardPoint(1); //30
            game.AwardPoint(1); //40
            game.AwardPoint(2); //15
            game.AwardPoint(2); //30
            game.AwardPoint(2); //40

            Assert.IsTrue(game.IsDeuce());
        }

        [TestMethod]
        [TestCategory("Game")]
        public void GetWinner1()
        {
            IGame game = new Game();

            game.AwardPoint(1); //15
            game.AwardPoint(1); //30
            game.AwardPoint(1); //40
            game.AwardPoint(1); //win

            Assert.IsTrue(String.Equals(game.GetWinner(), "Team 1"));
        }

        [TestMethod]
        [TestCategory("Game")]
        public void GetWinner2()
        {
            IGame game = new Game();

            game.AwardPoint(1); //15
            game.AwardPoint(1); //30

            Assert.IsNull(game.GetWinner());
        }

        [TestMethod]
        [TestCategory("Game")]
        public void Reset()
        {
            IGame game = new Game();

            game.AwardPoint(1); //15
            game.AwardPoint(1); //30
            game.Reset();

            Assert.IsTrue(String.Equals(game.GetScore(), "0-0"));
        }
    }
}
