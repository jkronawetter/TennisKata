using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class Game : IGame
    {
        private ITeam team1;
        private ITeam team2;

        public Game()
        {
            team1 = new Team();
            team2 = new Team();
        }

        public void AwardPoint(int teamNumber)
        {
            if(teamNumber == 1) team1.AwardPoint();
            else if (teamNumber == 2) team2.AwardPoint();
        }

        public bool GameOver()
        {
            return ((team1.Points > 3 && team1.Points > team2.Points + 1) || (team2.Points > 3 && team2.Points > team1.Points + 1));
        }

        public string GetWinner()
        {
            if (GameOver())
                return team1.Points > team2.Points ? "Team 1" : "Team 2";
            return null;
        }

        public string GetScore()
        {
            if (IsDeuce()) return "Deuce";
            if (team1.Points > 2 && team2.Points > 2 && team1.Points == team2.Points + 1) return "Adv-40";
            if (team1.Points > 2 && team2.Points > 2 && team2.Points == team1.Points + 1) return "40-Adv";
            return String.Format("{0}-{1}", team1.Score, team2.Score);
        }

        public bool IsDeuce()
        {
            return (team1.Points > 2 && team1.Points == team2.Points);
        }

        public void Reset()
        {
            team1 = new Team();
            team2 = new Team();
        }
    }
}
